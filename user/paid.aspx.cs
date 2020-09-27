using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class user_paid : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn); 

    string order = "";
    string s;
    string t;
    string[] a = new string[6];
    string order_id;

    protected void Page_Load(object sender, EventArgs e)
    {

        sqlconn.Open();
        order = Request.QueryString["order"].ToString();

        if (order == Session["order_no"].ToString())
        {
            MySqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer where email='" + Session["user"].ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MySqlCommand cmd1 = sqlconn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "INSERT INTO `corder1`(`id`, `firstname`, `lastname`, `email`, `address`, `city`, `pincode`, `mobile`) values(NULL,'" + dr["firstname"].ToString() + "','" + dr["lastname"].ToString() + "','" + dr["email"].ToString() + "','" + dr["address"].ToString() + "','" + dr["city"].ToString() + "','" + dr["pincode"].ToString() + "','" + dr["mobile"].ToString() + "')";
                cmd1.ExecuteNonQuery();

            }


            MySqlCommand cmd2 = sqlconn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from corder1 where email='" + Session["user"].ToString() + "'order by id desc limit 1";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                order_id = dr2["id"].ToString();

            }


            if (Request.Cookies["aa"] != null)
            {
                s = Convert.ToString(Request.Cookies["aa"].Value);

                string[] strArr = s.Split('|');

                for (int i = 0; i < strArr.Length; i++)
                {
                    t = Convert.ToString(strArr[i].ToString());
                    string[] strArr1 = t.Split(',');

                    for (int j = 0; j < strArr1.Length; j++)
                    {
                        a[j] = strArr1[j].ToString();
                    }


                    MySqlCommand cmd3 = sqlconn.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "INSERT INTO `orders`(`id`, `order_id`, `p_name`, `p_price`, `p_quantity`, `p_image`) values(NULL,'" + order_id.ToString() + "','" + a[0].ToString() + "','" + a[1].ToString() + "','" + a[2].ToString() + "','" + a[4].ToString() + "')";
                    cmd3.ExecuteNonQuery();


                }


            }


        }
        else
        {
            Response.Redirect("userlogin.aspx");
        
        }

        sqlconn.Close();

        Session["user"] = "";
        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

        Response.Redirect("display.aspx");




    }
}