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
using System.Text;

using thietkeso.Biz.Services;
using thietkeso.Common.Models;

namespace ThietKeSoUI.UserControls
{
    public partial class LeftArea : System.Web.UI.UserControl
    {
        // <tr><td>Mr Hiếu</td><td><a href="ymsgr:sendIM?hdesign888" class="A"><img border="0" src="http://opi.yahoo.com/online?u=hdesign888&amp;m=g&amp;t=1"></a></td><td>0977.197.167</td></tr>
        private ISupporterService iSupporterService = new thietkeso.Biz.Implements.SupporterService();
        private CHRTList<SupporterInfo> lstSupporter = new CHRTList<SupporterInfo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Load Supporter            
            StringBuilder strbuilder = new StringBuilder(string.Empty);
            lstSupporter = iSupporterService.SelectAll();
            if (lstSupporter != null && lstSupporter.Count > 0)
            {
                foreach (SupporterInfo supporterInfo in lstSupporter)
                {
                    strbuilder.AppendFormat("<tr><td>{0}</td><td><a href='ymsgr:sendIM?{1}' class='A'><img border='0' src='http://opi.yahoo.com/online?u={2}&amp;m=g&amp;t=1'></a></td><td>{3}</td></tr>",
                        supporterInfo.Name, supporterInfo.Yahoo, supporterInfo.Yahoo, supporterInfo.Mobile);
                }
            }
            lbSupportHN.Text = strbuilder.ToString();
        }
    }
}