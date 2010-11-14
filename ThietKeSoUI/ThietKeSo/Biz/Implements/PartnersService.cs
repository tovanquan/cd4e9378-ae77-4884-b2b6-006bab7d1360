using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
namespace thietkeso.Biz.Implements
{
	public class PartnersService: IPartnersService
	{
		/// <summary>
		/// Saves a record to the Partners table.
		/// </summary>
		public virtual void Insert(PartnersInfo partnersInfo)
		{
			try
			{
				new PartnersDAO().Insert(partnersInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Partners - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Partners table.
		/// </summary>
		public virtual void Update(PartnersInfo partnersInfo)
		{
			try
			{
				new PartnersDAO().Update(partnersInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Partners - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Partners table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new PartnersDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Partners - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Partners table.
		/// </summary>
		public virtual PartnersInfo Select(int iD)
		{
			try
			{
				return new PartnersDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Partners - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Partners table.
		/// </summary>
		public CHRTList<PartnersInfo> SelectAll()
		{
			try
			{
				return new PartnersDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Partners - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
