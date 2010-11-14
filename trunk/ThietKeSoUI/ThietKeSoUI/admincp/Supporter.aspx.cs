using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using TKSUltilities;
using TKSUltilities.Helper;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
using System.Text;
namespace ThietKeSoUI.admincp
{
    public partial class Supporter : System.Web.UI.Page
    {

        ISupporterService iSupporterService = new thietkeso.Biz.Implements.SupporterService();

        protected void Page_Load(object sender, EventArgs e)
        {
            BuildTableSupporterView();
        }
        protected void BuildTableSupporterView()
        {
            CHRTList<SupporterInfo> lstSupporterInfo = new CHRTList<SupporterInfo>();
            
            lstSupporterInfo = iSupporterService.SelectAll();

            StringBuilder strTS = new StringBuilder();
            if (lstSupporterInfo != null && lstSupporterInfo.Count() > 0)
            {
                foreach (SupporterInfo supporterInfo in lstSupporterInfo)
                {
                    strTS.AppendFormat("<tr class=\"odd\"><td>{0}</td><td>{1}</td><td>{2}</td><td class=\"action\"><a href=\"#\" class=\"edit\">Edit</a><a href=\"#\" class=\"delete\">Delete</a></td></tr>",
                        supporterInfo.Name,supporterInfo.Yahoo,supporterInfo.Mobile);
                }
            }
            lbTableSupporter.Text = strTS.ToString();
        }
    }
}
