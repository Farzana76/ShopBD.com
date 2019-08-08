using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class admin_add_category : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);

    protected void Page_Load(object sender, EventArgs e)
    {
       // if (Session["admin"] == null)
       // {
          //  Response.Redirect("adminlogin.aspx");
        
        //}

        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from category";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);
        sqlconn.Close();
        d1.DataSource = dt;
        d1.DataBind();

    }
    protected void b1_Click(object sender, EventArgs e)
    {

        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO `category` (`id`, `category`) VALUES (NULL, '" + t1.Text + "')";
        cmd.ExecuteNonQuery();
        sqlconn.Close();
        
        Response.Write("<script>alert('Category added successfully');</script>");
    }
}