using System;
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
            if (Session["UserAuthenticated"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Session["UserAuthenticated"] = null;
            Session["User"] = null;
            Session["UserID"] = null;
        }
    }
}
