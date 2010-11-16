using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
using thietkeso.Biz.Implements;
using System.Text;

namespace ThietKeSoUI.admincp
{
    public partial class TempCategories : System.Web.UI.Page
    {
        ITempCategoriesService iTempCateService = new TempCategoriesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTableTemplateCategories();
        }

        protected void CreateTableTemplateCategories()
        {
            CHRTList<TempCategoriesInfo> lstTempCateInfo = new CHRTList<TempCategoriesInfo>();
            lstTempCateInfo = iTempCateService.SelectAll();
            StringBuilder strTb = new StringBuilder();
            if (lstTempCateInfo != null && lstTempCateInfo.Count() > 0)
            {
                foreach (TempCategoriesInfo tempCateInfo in lstTempCateInfo)
                {
                    strTb.AppendFormat("<tr class=\"odd\"> <td>{0}</td> <td>{1}</td> <td class=\"action\"> <a onclick= \"DisplayEditPanel('{0}','{1}','{2}');\" href=\"#\" class=\"edit\">Edit</a> <a href=\"#\" class=\"delete\">Delete</a>",
                        tempCateInfo.Name, //0 
                        tempCateInfo.Description, //1
                        tempCateInfo.ID); //2                   
                }
            }
            lbTableTempCate.Text = strTb.ToString();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //SupporterInfo supporterInfo = new SupporterInfo();
            //int _id = 0;
            //int.TryParse(hdEditID.Value.Trim(), out _id);
            //supporterInfo.ID = _id;
            //supporterInfo.Name = tbName.Text.Trim();
            //supporterInfo.Yahoo = tbYahoo.Text.Trim();
            //supporterInfo.Skype = tbSkype.Text.Trim();
            //supporterInfo.Mail = tbMail.Text.Trim();
            //supporterInfo.Mobile = tbMobile.Text.Trim();
            //iSupporterService.Update(supporterInfo);
        }
    }
}
