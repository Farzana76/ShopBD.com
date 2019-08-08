using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class user_feedback : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);

    protected void Page_Load(object sender, EventArgs e)
    {
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from feedback";
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
       // t1.Text = DateTime.Now.ToString();
        cmd.CommandText = "INSERT INTO `feedback` (`id`, `date`, `name`, `product_name`, `message`) VALUES (NULL, '"+DateTime.Now.ToString()+"', '" + t2.Text + "', '" + t3.Text + "', '" + t4.Text + "')";
        cmd.ExecuteNonQuery();
        sqlconn.Close();

        //Response.Write("<script>alert('Category added successfully');</script>");
    }
}