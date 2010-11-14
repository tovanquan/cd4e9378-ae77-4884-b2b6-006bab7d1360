using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
namespace thietkeso.Biz.Implements
{
	public class TemplatesService: ITemplatesService
	{
		/// <summary>
		/// Saves a record to the Templates table.
		/// </summary>
		public virtual void Insert(TemplatesInfo templatesInfo)
		{
			try
			{
				new TemplatesDAO().Insert(templatesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Templates - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Templates table.
		/// </summary>
		public virtual void Update(TemplatesInfo templatesInfo)
		{
			try
			{
				new TemplatesDAO().Update(templatesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Templates - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Templates table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new TemplatesDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Templates - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the Templates table by foreign key value.
		/// </summary>
		public void DeleteAllByTempCategoryID(int tempCategoryID)
		{
			try
			{
				new TemplatesDAO().DeleteAllByTempCategoryID(tempCategoryID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Templates - DeleteAllByTempCategoryID" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Templates table.
		/// </summary>
		public virtual TemplatesInfo Select(int iD)
		{
			try
			{
				return new TemplatesDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Templates - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Templates table.
		/// </summary>
		public CHRTList<TemplatesInfo> SelectAll()
		{
			try
			{
				return new TemplatesDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Templates - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Templates table.
		/// </summary>
		public CHRTList<TemplatesInfo> SelectAllByTempCategoryID(int tempCategoryID)
		{
			try
			{
				return new TemplatesDAO().SelectAllByTempCategoryID(tempCategoryID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Templates - SelectAllByTempCategoryID()" + ex.Message);
				throw;
			}

		}

	}
}
