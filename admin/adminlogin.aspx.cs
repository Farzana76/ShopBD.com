using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


public partial class admin_adminlogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=I:\SD lab 3.2\online_shopping\App_Data\shop.mdf;Integrated Security=True;User Instance=True");
     int i;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        
      /*  if (!this.IsPostBack)
        {
            i = 0;
            string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            MySqlCommand comm = new MySqlCommand("select * from admin_login where adminname='" + t1.Text + "' and password='" + t2.Text + "'");
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                comm.Connection = sqlconn;
                da.SelectCommand = comm;
                DataTable dt = new DataTable();
                {
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    //if (i == 1)
                    //{
                      //  Response.Redirect("test.aspx");
                    //}
                    //else
                    //{

                      //  l1.Text = "Invalid name or password";
                    //}
                    Response.Write(i);
                    //d1.DataSource = dt;
                   // d1.DataBind();

                }
            }

        }*/
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from admin_login where adminname='" + t1.Text + "' and password='" + t2.Text + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        i = Convert.ToInt32(dt.Rows.Count.ToString());

        if (i == 1)
        {
            Response.Redirect("add_item.aspx");
        }
        else {

            l1.Text="Invalid name or password";
        }


        con.Close();
    }
}