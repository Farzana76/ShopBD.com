using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class user_delete_cart : System.Web.UI.Page
{
    string s;
    string t;
    string[] a = new string[6];
    int id;
    string p_name, p_description, p_price, p_quantity, p_image;
    int count = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["id"].ToString());

        DataTable dt = new DataTable();
        dt.Rows.Clear();

        dt.Columns.AddRange(new DataColumn[6] { new DataColumn("p_name"), new DataColumn("p_price"), new DataColumn("p_quantity"), new DataColumn("p_description"), new DataColumn("p_image"), new DataColumn("id") });

        if (Request.Cookies["aa"] != null)
        {
            s = Convert.ToString(Request.Cookies["aa"].Value);

            string[] strArr = s.Split('|');

            for (int i = 0; i < strArr.Length; i++)
            {
                t = Convert.ToString(strArr[i].ToString());
                string[] strArr1 = t.Split(',');

                for (int j = 0; j < strArr1.Length; j++)
                {
                    a[j] = strArr1[j].ToString();
                }

                dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), i.ToString());


            }
        }

        dt.Rows.RemoveAt(id);

        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

        foreach (DataRow dr in dt.Rows)
        {
            p_name = dr["p_name"].ToString();
            p_price = dr["p_price"].ToString();
            p_quantity = dr["p_quantity"].ToString();
            p_description = dr["p_description"].ToString();
            p_image = dr["p_image"].ToString();

            count = count + 1;




            if (count == 1)
            {
                Response.Cookies["aa"].Value = p_name.ToString() + "," + p_price.ToString() + "," + p_quantity.ToString() + "," + p_description.ToString() + "," + p_image.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);

            }

            else
            {
                Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + p_name.ToString() + "," + p_price.ToString() + "," + p_quantity.ToString() + "," + p_description.ToString() + "," + p_image.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);

            }
        }

        Response.Redirect("view_cart.aspx");
    
    }
        

    
}