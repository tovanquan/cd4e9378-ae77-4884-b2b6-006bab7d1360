using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailSender.Common
{
    public class CustomerInformation
    {
        private string name;
        private string address;
        private string email;
        private string mobile;
        private string title;
        private string content;

        #region Properties

        /// <summary>
        /// Gets or sets the name value.
        /// </summary>
        public string Name 
        {
            get { return this.name; }
            set { this.name = value;}
        }

        /// <summary>
        /// Gets or sets the address value.
        /// </summary>
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        /// <summary>
        /// Gets or sets the email value.
        /// </summary>
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        /// <summary>
        /// Gets or sets the mobile value.
        /// </summary>
        public string Mobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }
        /// <summary>
        /// Gets or sets the title value.
        /// </summary>
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        /// <summary>
        /// Gets or sets the content value.
        /// </summary>
        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }
        #endregion
        /// <summary>
        /// Initializes a new instance of the CustomerInformation class.
		/// </summary>
        public CustomerInformation() { }

		/// <summary>
        /// Initializes a new instance of the CustomerInformation class.
		/// </summary>
        public CustomerInformation(string name, string address, string email, string mobile, string title, string content)
		{
            this.name = name;
			this.address = address;
			this.content = content;
			this.email = email;
            this.mobile = mobile;
            this.title = title;
		}
    }
}
