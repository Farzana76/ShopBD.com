using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


public partial class user_user : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);


            MySqlCommand comm = new MySqlCommand("select * from category");
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                comm.Connection = sqlconn;
                da.SelectCommand = comm;
                DataTable dt = new DataTable();
                {
                    da.Fill(dt);
                    dd.DataSource = dt;
                    dd.DataBind();

                }
            }
        }
            
    }
}
