using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
namespace thietkeso.Biz.Implements
{
	public class WebsitesService: IWebsitesService
	{
		/// <summary>
		/// Saves a record to the Websites table.
		/// </summary>
		public virtual void Insert(WebsitesInfo websitesInfo)
		{
			try
			{
				new WebsitesDAO().Insert(websitesInfo);
			}
			catch (Exception ex)
			{
				////Provider.Log.Error(ex, "thietkeso.Biz.Implements.Websites - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Websites table.
		/// </summary>
		public virtual void Update(WebsitesInfo websitesInfo)
		{
			try
			{
				new WebsitesDAO().Update(websitesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Websites - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Websites table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new WebsitesDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Websites - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the Websites table by foreign key value.
		/// </summary>
		public void DeleteAllByCustomerID(int customerID)
		{
			try
			{
				new WebsitesDAO().DeleteAllByCustomerID(customerID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Websites - DeleteAllByCustomerID" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Websites table.
		/// </summary>
		public virtual WebsitesInfo Select(int iD)
		{
			try
			{
				return new WebsitesDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Websites - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Websites table.
		/// </summary>
		public CHRTList<WebsitesInfo> SelectAll()
		{
			try
			{
				return new WebsitesDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Websites - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Websites table.
		/// </summary>
		public CHRTList<WebsitesInfo> SelectAllByCustomerID(int customerID)
		{
			try
			{
				return new WebsitesDAO().SelectAllByCustomerID(customerID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Websites - SelectAllByCustomerID()" + ex.Message);
				throw;
			}

		}

	}
}
