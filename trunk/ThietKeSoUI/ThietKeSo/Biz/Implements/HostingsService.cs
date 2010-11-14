using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class HostingsService: IHostingsService
	{
		/// <summary>
		/// Saves a record to the Hostings table.
		/// </summary>
		public virtual void Insert(HostingsInfo hostingsInfo)
		{
			try
			{
				new HostingsDAO().Insert(hostingsInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Hostings - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Hostings table.
		/// </summary>
		public virtual void Update(HostingsInfo hostingsInfo)
		{
			try
			{
				new HostingsDAO().Update(hostingsInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Hostings - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Hostings table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new HostingsDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Hostings - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the Hostings table by foreign key value.
		/// </summary>
		public void DeleteAllByCustomerID(int customerID)
		{
			try
			{
				new HostingsDAO().DeleteAllByCustomerID(customerID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Hostings - DeleteAllByCustomerID" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Hostings table.
		/// </summary>
		public virtual HostingsInfo Select(int iD)
		{
			try
			{
				return new HostingsDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Hostings - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Hostings table.
		/// </summary>
		public CHRTList<HostingsInfo> SelectAll()
		{
			try
			{
				return new HostingsDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Hostings - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Hostings table.
		/// </summary>
		public CHRTList<HostingsInfo> SelectAllByCustomerID(int customerID)
		{
			try
			{
				return new HostingsDAO().SelectAllByCustomerID(customerID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Hostings - SelectAllByCustomerID()" + ex.Message);
				throw;
			}

		}

	}
}
