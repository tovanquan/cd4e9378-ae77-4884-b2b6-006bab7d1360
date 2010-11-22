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
using thietkeso.Biz.Services;
using thietkeso.Common.Models;
using System.Security.Cryptography;
using ThietKeSoUI;
using System.Text;

namespace ThietKeSoUI.admincp
{
    
    public partial class Login : System.Web.UI.Page
    {
        private IUsersService iUserSevice = new thietkeso.Biz.Implements.UsersService();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAuthenticated"].ToString() == "1")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string passMd5 = EncodePassword(tbPassword.Text);
            string user = tbUserName.Text;
            
            UsersInfo usersInfo = iUserSevice.SelectByUserName(user);
            if (passMd5.Trim().Equals(usersInfo.Password.Trim()))
            {
                Session["UserAuthenticated"] = 1;
                Session["User"] = user;
                Session["UserID"] = usersInfo.ID;
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Encode Passwork
        /// </summary>
        /// <param name="originalPassword"></param>
        /// <returns></returns>
        private string EncodePassword(string originalPassword)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }
    }
}
