using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class CategoriesService: ICategoriesService
	{
		/// <summary>
		/// Saves a record to the Categories table.
		/// </summary>
		public virtual void Insert(CategoriesInfo categoriesInfo)
		{
			try
			{
				new CategoriesDAO().Insert(categoriesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Categories - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Categories table.
		/// </summary>
		public virtual void Update(CategoriesInfo categoriesInfo)
		{
			try
			{
				new CategoriesDAO().Update(categoriesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Categories - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Categories table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new CategoriesDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Categories - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Categories table.
		/// </summary>
		public virtual CategoriesInfo Select(int iD)
		{
			try
			{
				return new CategoriesDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Categories - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Categories table.
		/// </summary>
		public CHRTList<CategoriesInfo> SelectAll()
		{
			try
			{
				return new CategoriesDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Categories - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
