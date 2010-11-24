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
using thietkeso.DAL;
using thietkeso.Common;
using thietkeso.Biz;
using thietkeso.Biz.Services;
using thietkeso.Common.Models;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Web.Configuration;


namespace ThietKeSoUI.admincp
{
    public partial class editArticleCtrl : System.Web.UI.Page
    {
        #region Properies

        static String sVirtualPath = string.Empty;
        static int iMaxWidth;
        static String sPath = string.Empty;

        /// <summary>
        /// Articles Service
        /// </summary>
        private IArticlesService iArticlesService = new thietkeso.Biz.Implements.ArticlesService();

        /// <summary>
        /// Categories service
        /// </summary>
        private ICategoriesService iCategoryService = new thietkeso.Biz.Implements.CategoriesService();
        #endregion

        #region Private method
        /// <summary>
        /// Init
        /// </summary>
        private void Initialize()
        {
            try
            {
                //read custom web config
                ReadConfig();

                //them su kien javascript cho button save
                btnSave.Attributes.Add("onclick", "javascript: SetHiddenFieldValue();");

                //Get newID
                string strID = Request["ID"];

                cboCategory.DataSource = iCategoryService.SelectAll();
                cboCategory.DataValueField = "ID";
                cboCategory.DataTextField = "Name";
                cboCategory.DataBind();
                int newID;
                if (!string.IsNullOrEmpty(strID))
                {
                    if (!int.TryParse(strID, out newID))
                    {
                        Response.Redirect("Error.aspx?msg=Invalid+NewID");
                    }
                    else
                    {
                        btnSave.Text = "Update";
                        GetNewData(newID);
                    }
                }
                else
                {
                    image.Visible = false;
                }

            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        private void ReadConfig()
        {

            Configuration rootWebConfig = WebConfigurationManager.OpenWebConfiguration("~\\Web.config");
            KeyValueConfigurationElement customSettingVPath = rootWebConfig.AppSettings.Settings["ArticleImageVitualPath"];
            KeyValueConfigurationElement customSettingMaxWidth = rootWebConfig.AppSettings.Settings["MaxWidthImage"];
            sVirtualPath = customSettingVPath.Value;
            int.TryParse(customSettingMaxWidth.Value, out iMaxWidth);
            sPath = HttpContext.Current.Server.MapPath(sVirtualPath);
        }

        /// <summary>
        /// Set display data to update
        /// </summary>
        /// <param name="intNewID"></param>
        private void GetNewData(int intNewID)
        {
            var newData = iArticlesService.Select(intNewID);
            if (newData != null)
            {
                tbxTitle.Text = newData.Title;
                tbxSummary.Text = newData.Summary;
                cboCategory.SelectedValue = newData.CategoryID + "";
                tbxContent.Value = newData.Contents;
                image.ImageUrl = newData.Image;
            }
        }
        #endregion

        #region Event handle

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Initialize();
            }

        }

        /// <summary>
        /// Cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticleCtrl.aspx");
        }

        /// <summary>
        ///Save click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTitle.Text.Trim()) || string.IsNullOrEmpty(tbxSummary.Text.Trim()) || string.IsNullOrEmpty(contentValue.Value.Trim()))
            {
                message.Text = "Something not inputed";
                return;
            }
            try
            {
                if (!string.IsNullOrEmpty(Request["ID"]))//Update
                {
                    string myPath = string.Empty;
                    int newID = int.Parse(Request["ID"]);
                    ArticlesInfo dataInfo = iArticlesService.Select(newID);
                    if (!string.IsNullOrEmpty(uploadedFile.FileName))
                    {
                        if (uploadedFile.PostedFile != null)
                        {
                            string[] temp = dataInfo.Image.Split('/');
                            string imageFile = temp.Last();
                            myPath = Process_Upload(imageFile);
                            if (myPath != null)
                            {
                                dataInfo.Author = Session["User"].ToString();
                                dataInfo.Avatar = myPath;
                                dataInfo.CategoryID = int.Parse(cboCategory.SelectedValue);
                                dataInfo.Contents = contentValue.Value.Trim();
                                dataInfo.CreateDate = DateTime.Now;
                                dataInfo.Image = myPath;
                                dataInfo.Summary = tbxSummary.Text.Trim();
                                dataInfo.Title = tbxTitle.Text.Trim();
                                iArticlesService.Update(dataInfo);
                                Response.Redirect("ArticleCtrl.aspx");
                            }
                        }
                    }
                    else
                    {
                        dataInfo.Author = Session["User"].ToString();
                        dataInfo.CategoryID = int.Parse(cboCategory.SelectedValue);
                        dataInfo.Contents = contentValue.Value.Trim();
                        dataInfo.CreateDate = DateTime.Now;
                        dataInfo.Summary = tbxSummary.Text.Trim();
                        dataInfo.Title = tbxTitle.Text.Trim();
                        iArticlesService.Update(dataInfo);
                        Response.Redirect("ArticleCtrl.aspx");
                    }
                }
                else //Add new
                {
                    if (uploadedFile.PostedFile != null)
                    {
                        string myPath = Process_Upload(string.Empty);
                        if (myPath != null)
                        {
                            ArticlesInfo dataInfo = new ArticlesInfo();
                            dataInfo.Author = Session["User"].ToString();
                            dataInfo.Avatar = myPath;
                            dataInfo.CategoryID = int.Parse(cboCategory.SelectedValue);
                            dataInfo.Contents = contentValue.Value.Trim();
                            dataInfo.CreateDate = DateTime.Now;
                            dataInfo.Image = myPath;
                            dataInfo.Summary = tbxSummary.Text.Trim();
                            dataInfo.Title = tbxTitle.Text.Trim();
                            iArticlesService.Insert(dataInfo);
                            Response.Redirect("ArticleCtrl.aspx");
                        }
                    }
                    else
                    {
                        message.Text = "please choose an image file!";
                    }
                }
            }
            catch (System.Threading.ThreadAbortException)
            {

            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");

            }

        }
        #endregion

        #region Upload Image

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        string Process_Upload(string fileName)
        {
            try
            {
                //Check for common errors.
                if (!Check_Upload(uploadedFile.PostedFile)) return null;

                //Initializing local variables
                HttpPostedFile myUpload = uploadedFile.PostedFile;
                int myLength = myUpload.ContentLength;
                String myType = myUpload.ContentType;
                String myName = fileName;
                if (string.IsNullOrEmpty(myName))
                {
                    myName = Guid.NewGuid().ToString();
                }

                //Running main image processing routine
                string mypath = Process_Image(myUpload.InputStream, Path.ChangeExtension(myName, ".jpg"));
                return mypath;
            }
            catch (Exception)
            {
                message.Text = "Failed to upload image";
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="myStream"></param>
        /// <param name="myName"></param>
        /// <returns></returns>
        string Process_Image(Stream myStream, String myName)
        {
            //Initializing local variables
            System.Drawing.Image myImage = System.Drawing.Image.FromStream(myStream);
            String myPath = Path.Combine(sPath, myName);
            int oldWidth = myImage.Width;
            int oldHeight = myImage.Height;
            int newWidth;
            int newHeight;

            //Determining new image size
            if ((iMaxWidth > 0) && (oldWidth > iMaxWidth))
            {
                newWidth = iMaxWidth;
                newHeight = (int)(oldHeight / ((Double)oldWidth / newWidth));
            }
            else
            {
                newWidth = oldWidth;
                newHeight = oldHeight;
            }

            //Creating new, re-sized image
            Bitmap myBitmap = new Bitmap(myImage, newWidth, newHeight);

            //Writing text overlayed image to disk and cleaning up
            myBitmap.Save(myPath, ImageFormat.Jpeg);
            myBitmap.Dispose();

            //Cleaning up parent image object
            myImage.Dispose();
            return Path.Combine(sVirtualPath, myName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileUpped"></param>
        /// <returns></returns>
        bool Check_Upload(HttpPostedFile fileUpped)
        {
            //Checking to see if field was left empty
            if (fileUpped.FileName == "")
            {
                message.Text = "Upload Failed: No image sbumitted";
                return false;
            }
            //Checking for Jpeg / Gif mime types
            if (!Regex.IsMatch(fileUpped.ContentType, "image/(?:\\w?jpeg|gif|png)", RegexOptions.IgnoreCase))
            {
                message.Text = "Upload Failed: Only JPG's and GIF's allowed";
                return false;
            }
            //Checking for zero length.  You could also use to check for large files.
            if (fileUpped.ContentLength == 0)
            {
                message.Text = "Upload Failed: File cannot be zero bytes.";
                return false;
            }

            return true;
        }
        #endregion




    }
}
