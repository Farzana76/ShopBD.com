using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


public partial class user_update_order_details : System.Web.UI.Page
{
    static string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
    MySqlConnection sqlconn = new MySqlConnection(mainconn);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        { return; }
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from `customer` where email='"+Session["user"].ToString()+"'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            t1.Text = dr["firstname"].ToString();
            t2.Text = dr["lastname"].ToString();
            t3.Text = dr["address"].ToString();
            t4.Text = dr["city"].ToString();
            t5.Text = dr["mobile"].ToString();
        
        
        }


        sqlconn.Close();
    }
    protected void b1_Click(object sender, EventArgs e)
    {
        sqlconn.Open();
        MySqlCommand cmd = sqlconn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "UPDATE `customer` SET `firstname` = '" + t1.Text + "',`lastname` = '" + t2.Text + "',`address` = '" + t3.Text + "',`city` = '" + t4.Text + "',`mobile` = '" + t5.Text + "'where email='" + Session["user"].ToString() + "'";
        cmd.ExecuteNonQuery();
        sqlconn.Close();

        Response.Redirect("payment.aspx");
    }
}