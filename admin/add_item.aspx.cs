using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class admin_add_item : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);
    string b;

    protected void Page_Load(object sender, EventArgs e)
    {
       // if (Session["admin"] == null)
       // {
           // Response.Redirect("adminlogin.aspx");

      //  }
        if (IsPostBack) return;
        dd.Items.Clear();
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from category";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            dd.Items.Add(dr["category"].ToString());
        
        }
        sqlconn.Close();

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        f1.SaveAs(Request.PhysicalApplicationPath + "./images/" + f1.FileName.ToString());
        b = "images/" + f1.FileName.ToString();
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO `product` (`id`, `p_name`, `p_description`, `p_price`, `p_quantity`, `p_image`,`p_category`) VALUES (NULL, '" + t1.Text + "', '" + t2.Text + "'," + t3.Text + "," + t4.Text + ", '" + b.ToString() + "','"+dd.SelectedItem.ToString()+"')";
        cmd.ExecuteNonQuery();
        sqlconn.Close();
        




    }
}