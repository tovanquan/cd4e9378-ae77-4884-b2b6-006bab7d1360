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
                    strTS.AppendFormat("<tr class=\"odd\"><td>{0}</td><td>{1}</td><td>{2}</td><td class=\"action\"><a onclick=\"DisplayEditPanel('{3}','{4}','{5}','{6}', '{7}','{8}');\" href=\"#\" class=\"edit\">Edit</a><a href=\"#\" class=\"delete\" onclick=\"DeleteSupporter('{9}');\">Delete</a></td></tr>",
                        supporterInfo.Name,//0
                        supporterInfo.Yahoo,//1
                        supporterInfo.Mobile,//2
                        supporterInfo.Name,//3
                        supporterInfo.Yahoo,//4
                        supporterInfo.Skype,//5
                        supporterInfo.Mail,//6
                        supporterInfo.Mobile,//7
                        supporterInfo.ID, //8
                        supporterInfo.ID);//9
                }
            }
            lbTableSupporter.Text = strTS.ToString();
        }

        #region Event
        /// <summary>
        /// Event Button Edit Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SupporterInfo supporterInfo = new SupporterInfo();
            int _id= 0;
            int.TryParse(hdEditID.Value.Trim(),out _id);
            supporterInfo.ID = _id;
            supporterInfo.Name = tbName.Text.Trim();
            supporterInfo.Yahoo = tbYahoo.Text.Trim();
            supporterInfo.Skype = tbSkype.Text.Trim();
            supporterInfo.Mail = tbMail.Text.Trim();
            supporterInfo.Mobile = tbMobile.Text.Trim();
            iSupporterService.Update(supporterInfo);
        }
        /// <summary>
        /// Event Link Button Delete Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Click(object sender, EventArgs e)
        {
            int id= 0;
            int.TryParse(hdDelID.Value, out id);
            iSupporterService.Delete(id);
            Response.Redirect("Supporter.aspx");
        }
        #endregion
    }
}
