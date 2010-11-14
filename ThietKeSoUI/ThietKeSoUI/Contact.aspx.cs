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
using MailSender.Accessor;
using MailSender.Helper;
namespace ThietKeSoUI
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            bool result = false;
            try
            {
                lbError.Visible = false;
                result = ValidateInputData();
                if (result)
                {
                    CustomerInformation customerInfo = new CustomerInformation();
                    customerInfo.Address = tbAddress.Text.Trim();
                    customerInfo.Content = tbContent.Text.Trim();
                    customerInfo.Email = tbEmail.Text.Trim();
                    customerInfo.Title = tbTitle.Text.Trim();
                    customerInfo.Name = tbName.Text.Trim();
                    customerInfo.Mobile = tbTel.Text.Trim();
                    //Utility.SendEmail("lienhe.thietkeso@gmail.com", tbTitle.Text.Trim(), tbContent.Text.Trim(), true);
                    Utility.SendEmail("lienhe.thietkeso@gmail.com",customerInfo,true);
                    //Gui mail lai cho khach hang
                }
            }
            catch (DataException ex) 
            {
                lbError.Text = ex.Message;
                lbError.Visible = true;
            }
            
        }
        private bool ValidateInputData()
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text.Trim()))
                    throw new DataException("ten deo duoc de trong");
                if (string.IsNullOrEmpty(tbEmail.Text.Trim()))
                    throw new DataException("Email deo duoc de trong");
                if (!Utility.CheckInputEmail(tbEmail.Text.Trim()))
                    throw new DataException("Nhap sai me dinh dang email roi");
                if (string.IsNullOrEmpty(tbTitle.Text.Trim()))
                    throw new DataException("Title deo duoc de trong");
                if (string.IsNullOrEmpty(tbContent.Text.Trim()))
                    throw new DataException("Content deo duoc de trong");
            }
            catch (DataException ex)
            {
                throw ex;
            }
            return true;
        }
    }
}