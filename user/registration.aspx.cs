using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class user_registration : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO `customer` (`id`, `firstname`, `lastname`, `email`, `password`, `address`,`city`,`pincode`,`mobile`) VALUES (NULL, '" + t1.Text + "', '" + t2.Text + "','" + t3.Text + "','" + t4.Text + "', '" + t5.Text + "','" + t6.Text + "','" + t7.Text + "','" + t8.Text + "')";
        cmd.ExecuteNonQuery();
        sqlconn.Close();

        t1.Text = "";
        t2.Text = "";
        t3.Text = "";
        t4.Text = "";
        t5.Text = "";
        t6.Text = "";
        t7.Text = "";
        t8.Text = "";

        l1.Text="Successfully signed up!";
        
    }
}