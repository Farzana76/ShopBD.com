using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


public partial class user_userlogin : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);
    int tot = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from customer where email='"+t1.Text+"' and password='"+t2.Text+"'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);

        tot = Convert.ToInt32(dt.Rows.Count.ToString());

        if (tot > 0)
        {
            if (Session["checkoutButton"] == "yes")
            {
                Session["user"] = t1.Text;
                Response.Redirect("update_order_details.aspx");
            }
            else
            {
                Session["user"] = t1.Text;
                Response.Redirect("order_details.aspx");
            }
        }
        else
        {
            l1.Text = "Invalid user name or password";
        }

        sqlconn.Close();

    }
}