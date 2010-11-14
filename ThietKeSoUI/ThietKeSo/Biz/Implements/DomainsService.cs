using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class DomainsService: IDomainsService
	{
		/// <summary>
		/// Saves a record to the Domains table.
		/// </summary>
		public virtual void Insert(DomainsInfo domainsInfo)
		{
			try
			{
				new DomainsDAO().Insert(domainsInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Domains - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Domains table.
		/// </summary>
		public virtual void Update(DomainsInfo domainsInfo)
		{
			try
			{
				new DomainsDAO().Update(domainsInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Domains - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Domains table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new DomainsDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Domains - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the Domains table by foreign key value.
		/// </summary>
		public void DeleteAllByCustomerID(int customerID)
		{
			try
			{
				new DomainsDAO().DeleteAllByCustomerID(customerID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Domains - DeleteAllByCustomerID" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Domains table.
		/// </summary>
		public virtual DomainsInfo Select(int iD)
		{
			try
			{
				return new DomainsDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Domains - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Domains table.
		/// </summary>
		public CHRTList<DomainsInfo> SelectAll()
		{
			try
			{
				return new DomainsDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Domains - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Domains table.
		/// </summary>
		public CHRTList<DomainsInfo> SelectAllByCustomerID(int customerID)
		{
			try
			{
				return new DomainsDAO().SelectAllByCustomerID(customerID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Domains - SelectAllByCustomerID()" + ex.Message);
				throw;
			}

		}

	}
}
