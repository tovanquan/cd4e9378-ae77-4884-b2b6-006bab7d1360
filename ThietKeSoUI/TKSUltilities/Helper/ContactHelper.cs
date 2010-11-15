using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using TKSUltilities.Accessor;
using System.Xml.Linq;
using System.Xml.Schema;
namespace TKSUltilities.Helper
{
    public static class ContactHelper
    {
        public static List<CustomerInformation> GetContactList(string filePath) 
        {
            try 
            {
                if (!CheckFileExist(filePath)) 
                {
                    return null;
                }
                XDocument objDocument = XDocument.Load(filePath, LoadOptions.PreserveWhitespace);

                var objContactList = objDocument.Elements("Contacts").Elements("Customer").Select(objItem => new CustomerInformation
                {
                    Address = objItem.Element("Address").Value,
                    Email = objItem.Element("Email").Value,
                    Mobile = objItem.Element("Mobile").Value,
                    Name = objItem.Element("Name").Value,
                });
                return objContactList.ToList();
            }
            catch (Exception) 
            {
                // log to file
                return null;
            }
        }
        public static bool AddToContactList(CustomerInformation contactInfo, string filePath) 
        {
            if (!File.Exists(filePath)) 
            {
                if(!CreateContactFile(filePath))
                    return false;
            }
            try
            {
                XDocument document = XDocument.Load(filePath, LoadOptions.PreserveWhitespace);

                document.Element("Contacts").Add(
                    new XElement("Customer",
                        new XElement("Name", contactInfo.Name),
                        new XElement("Email", contactInfo.Email),
                        new XElement("Mobile", contactInfo.Mobile),
                        new XElement("Address", contactInfo.Address)));
                document.Save(filePath);
                return true;
            }
            catch (Exception) 
            {
                //log to file
                return false;
            }
        }
        public static bool CreateContactFile(string filePath) 
        {
            //initialize new blank document
            XDocument document = new XDocument();

            try
            {
                //create declaration
                document.Declaration = new XDeclaration("1.0", "UTF-8", "Yes");

                //create root element
                XElement rootElement = new XElement("Contacts");

                //add element to document
                document.Add(rootElement);
                //create file
                document.Save(filePath);
                return true;
            }
            catch (Exception) 
            {
                // log to file
                return false;
            }
        }
        public static bool CheckFileExist(string filePath)
        {
            try
            {
                return File.Exists(filePath);
            }
            catch (Exception)
            {
                // log file
                return false;
            }
        }
    }
}
