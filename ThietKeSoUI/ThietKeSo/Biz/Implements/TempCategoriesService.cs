using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class TempCategoriesService: ITempCategoriesService
	{
		/// <summary>
		/// Saves a record to the TempCategories table.
		/// </summary>
		public virtual void Insert(TempCategoriesInfo tempCategoriesInfo)
		{
			try
			{
				new TempCategoriesDAO().Insert(tempCategoriesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.TempCategories - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the TempCategories table.
		/// </summary>
		public virtual void Update(TempCategoriesInfo tempCategoriesInfo)
		{
			try
			{
				new TempCategoriesDAO().Update(tempCategoriesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.TempCategories - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the TempCategories table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new TempCategoriesDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.TempCategories - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the TempCategories table.
		/// </summary>
		public virtual TempCategoriesInfo Select(int iD)
		{
			try
			{
				return new TempCategoriesDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.TempCategories - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the TempCategories table.
		/// </summary>
		public CHRTList<TempCategoriesInfo> SelectAll()
		{
			try
			{
				return new TempCategoriesDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.TempCategories - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
