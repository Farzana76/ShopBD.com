using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class user_display_desc : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);
    int id;
    int qty;
    string p_name, p_description, p_price, p_quantity, p_image;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("display.aspx");
        }
        else
        {
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            MySqlCommand comm = new MySqlCommand("select * from product where id=" + id + "");
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                comm.Connection = sqlconn;
                da.SelectCommand = comm;
                DataTable dt = new DataTable();
                {
                    da.Fill(dt);
                    d1.DataSource = dt;
                    d1.DataBind();

                }
            }
        }

        qty = get_qty(id);

        if (qty == 0)
        {
            l2.Visible = false;
            t1.Visible = false;
            b1.Visible = false;
            l1.Text = "OUT of STOCK";

        }
    }
    protected void b1_Click(object sender, EventArgs e)
    {
        string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        MySqlConnection sqlconn = new MySqlConnection(mainconn);

        if (sqlconn.State == ConnectionState.Open)
        {
            sqlconn.Close();
        }
        sqlconn.Open();
        MySqlCommand comm = new MySqlCommand("select * from product where id=" + id + "");
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            comm.Connection = sqlconn;
            da.SelectCommand = comm;
            DataTable dt = new DataTable();
            {
                da.Fill(dt);
                // d1.DataSource = dt;
                // d1.DataBind();
                foreach (DataRow dr in dt.Rows)
                {
                    p_name = dr["p_name"].ToString();
                    p_price = dr["p_price"].ToString();
                    p_quantity = dr["p_quantity"].ToString();
                    p_description = dr["p_description"].ToString();
                    p_image = dr["p_image"].ToString();

                }


            }

        }

        if (Convert.ToInt32(t1.Text) > Convert.ToInt32(p_quantity))
        {

            l1.Text = "Not in stock";
        }
        else
        {
            l1.Text = "";

            if (Request.Cookies["aa"] == null)
            {
                Response.Cookies["aa"].Value = p_name.ToString() + "," + p_price.ToString() + "," + t1.Text + "," + p_description.ToString() + "," + p_image.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);

            }

            else
            {
                Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + p_name.ToString() + "," + p_price.ToString() + "," + t1.Text + "," + p_description.ToString() + "," + p_image.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);

            }


            MySqlCommand cmd1 = sqlconn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE `product` SET `p_quantity` = `p_quantity`-" + t1.Text + " WHERE `product`.`id` =" + id;
            cmd1.ExecuteNonQuery();
            Response.Redirect("display_desc.aspx?id=" + id.ToString());


        }

    }

    public int get_qty(int id)
    {
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from product where id=" + id + "";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            qty = Convert.ToInt32(dr["p_quantity"].ToString());

        }
        return qty;


    }
}