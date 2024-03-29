﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ThietKeSoUI.admincp
{
    public partial class AdminMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAuthenticated"] != null)
            {
                if (Session["UserAuthenticated"].ToString() == "0")
                    Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Session["UserAuthenticated"] = 0;
            Session["User"] = null;
            Session["UserID"] = null;
            Response.Redirect("Login.aspx");

        }
    }
}
