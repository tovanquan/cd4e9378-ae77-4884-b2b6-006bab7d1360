using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class CustomersService: ICustomersService
	{
		/// <summary>
		/// Saves a record to the Customers table.
		/// </summary>
		public virtual void Insert(CustomersInfo customersInfo)
		{
			try
			{
				new CustomersDAO().Insert(customersInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Customers - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Customers table.
		/// </summary>
		public virtual void Update(CustomersInfo customersInfo)
		{
			try
			{
				new CustomersDAO().Update(customersInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Customers - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Customers table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new CustomersDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Customers - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Customers table.
		/// </summary>
		public virtual CustomersInfo Select(int iD)
		{
			try
			{
				return new CustomersDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Customers - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Customers table.
		/// </summary>
		public CHRTList<CustomersInfo> SelectAll()
		{
			try
			{
				return new CustomersDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Customers - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
