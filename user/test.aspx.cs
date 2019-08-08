using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_test : System.Web.UI.Page
{
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        s= Convert.ToString(Request.Cookies["aa"].Value);
        string[] strArr = s.Split('.');

        for (int i = 0; i < strArr.Length; i++)
        {
        Response.Write(strArr[i].ToString());
        Response.Write("<br>");

        }

        
    }
}