using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class ArticlesService: IArticlesService
	{
		/// <summary>
		/// Saves a record to the Articles table.
		/// </summary>
		public virtual void Insert(ArticlesInfo articlesInfo)
		{
			try
			{
				new ArticlesDAO().Insert(articlesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Articles - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Articles table.
		/// </summary>
		public virtual void Update(ArticlesInfo articlesInfo)
		{
			try
			{
				new ArticlesDAO().Update(articlesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Articles - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Articles table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new ArticlesDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Articles - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the Articles table by foreign key value.
		/// </summary>
		public void DeleteAllByCategoryID(int categoryID)
		{
			try
			{
				new ArticlesDAO().DeleteAllByCategoryID(categoryID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Articles - DeleteAllByCategoryID" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Articles table.
		/// </summary>
		public virtual ArticlesInfo Select(int iD)
		{
			try
			{
				return new ArticlesDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Articles - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Articles table.
		/// </summary>
		public CHRTList<ArticlesInfo> SelectAll()
		{
			try
			{
				return new ArticlesDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Articles - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the Articles table.
		/// </summary>
		public CHRTList<ArticlesInfo> SelectAllByCategoryID(int categoryID)
		{
			try
			{
				return new ArticlesDAO().SelectAllByCategoryID(categoryID);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Articles - SelectAllByCategoryID()" + ex.Message);
				throw;
			}

		}

	}
}
