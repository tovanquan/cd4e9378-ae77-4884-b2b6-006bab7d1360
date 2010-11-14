using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class SupporterService: ISupporterService
	{
		/// <summary>
		/// Saves a record to the Supporter table.
		/// </summary>
		public virtual void Insert(SupporterInfo supporterInfo)
		{
			try
			{
				new SupporterDAO().Insert(supporterInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Supporter - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Supporter table.
		/// </summary>
		public virtual void Update(SupporterInfo supporterInfo)
		{
			try
			{
				new SupporterDAO().Update(supporterInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Supporter - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Supporter table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new SupporterDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Supporter - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Supporter table.
		/// </summary>
		public virtual SupporterInfo Select(int iD)
		{
			try
			{
				return new SupporterDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Supporter - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Supporter table.
		/// </summary>
		public CHRTList<SupporterInfo> SelectAll()
		{
			try
			{
				return new SupporterDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Supporter - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
