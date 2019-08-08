using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class user_display : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);

            if (Request.QueryString["category"] == null)
            {

                MySqlCommand comm = new MySqlCommand("select * from product");
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
            else {

                MySqlCommand comm = new MySqlCommand("select * from product where p_category='" + Request.QueryString["category"].ToString()+ "'");
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

            if (Request.QueryString["category"] == null && Request.QueryString["search"] != null)
            {
                MySqlCommand comm = new MySqlCommand("select * from product where p_name like('%" + Request.QueryString["search"].ToString() + "%')");
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
           
           

        }

    }
}