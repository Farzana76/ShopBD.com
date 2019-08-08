using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        MySqlConnection sqlconn = new MySqlConnection(mainconn);

        if (Request.QueryString["search"] != null)
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
        if (Request.QueryString["search1"] != null)
        {
            MySqlCommand comm1 = new MySqlCommand("select * from product where p_name like('%" + Request.QueryString["search1"].ToString() + "%')");
            {
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                comm1.Connection = sqlconn;
                da1.SelectCommand = comm1;
                DataTable dt1 = new DataTable();
                {
                    da1.Fill(dt1);
                    d2.DataSource = dt1;
                    d2.DataBind();

                }
            }



        }

        if (Request.QueryString["search2"] != null)
        {
            MySqlCommand comm2 = new MySqlCommand("select * from product where p_name like('%" + Request.QueryString["search2"].ToString() + "%')");
            {
                MySqlDataAdapter da2 = new MySqlDataAdapter();
                comm2.Connection = sqlconn;
                da2.SelectCommand = comm2;
                DataTable dt2 = new DataTable();
                {
                    da2.Fill(dt2);
                    d3.DataSource = dt2;
                    d3.DataBind();

                }
            }

        }
    }
}