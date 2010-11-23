using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace ThietKeSoUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            btnHide.Attributes.Add("onclick", "return hideButton()");
            btnShow.Attributes.Add("onclick", "return ShowButton()");
            //Webform1.DomDocument.InvokeScript("example_function", args);  
        }
    }
}
