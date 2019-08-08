using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class admin_delete : System.Web.UI.Page
{
    string category;
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);

    protected void Page_Load(object sender, EventArgs e)
    {
        category = Request.QueryString["category"].ToString();
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from category where category='"+category.ToString()+"'";
        cmd.ExecuteNonQuery();

        MySqlCommand cmd1 = sqlconn.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "delete from product where p_category='" + category.ToString() + "'";
        cmd1.ExecuteNonQuery();

        sqlconn.Close();

        Response.Redirect("add_category.aspx");


    }
}