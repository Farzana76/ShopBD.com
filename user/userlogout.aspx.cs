using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_userlogout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Clear();
        if (Request.Cookies["aa"] != null)
        {
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
        }
        Response.Redirect("userlogin.aspx");
    }
}