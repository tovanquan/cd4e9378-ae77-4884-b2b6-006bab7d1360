using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThietKeSoUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnHide.Attributes.Add("onclick", "return hideButton()");
            btnShow.Attributes.Add("onclick", "return ShowButton()");
            //WebForm1.Document.InvokeScript("example_function", args);  
        }
    }
}
