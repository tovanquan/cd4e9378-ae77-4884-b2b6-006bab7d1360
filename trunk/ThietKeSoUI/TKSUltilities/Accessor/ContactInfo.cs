using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKSUltilities.Accessor
{
    public class ListContact 
    {
        public List<ContactInfo> listContact;
        public ListContact() 
        {
            listContact = new List<ContactInfo>();
        }
    }
    public class ContactInfo
    {
        private string name;
        private string address;
        private string email;
        private string mobile;

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
        #endregion
        /// <summary>
        /// Initializes a new instance of the CustomerInformation class.
		/// </summary>
        public ContactInfo() { }

		/// <summary>
        /// Initializes a new instance of the CustomerInformation class.
		/// </summary>
        public ContactInfo(string name, string address, string email, string mobile)
		{
            this.name = name;
			this.address = address;
			this.email = email;
            this.mobile = mobile;
		}
    }
}
