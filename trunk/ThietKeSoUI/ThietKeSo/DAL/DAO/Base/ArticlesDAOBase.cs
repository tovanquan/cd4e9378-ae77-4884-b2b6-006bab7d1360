using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class ArticlesDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public ArticlesDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Articles table.
		/// </summary>
		public virtual void Insert(ArticlesInfo articlesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CategoryID", articlesInfo.CategoryID),
				new SqlParameter("@Title", articlesInfo.Title),
				new SqlParameter("@Summary", articlesInfo.Summary),
				new SqlParameter("@Contents", articlesInfo.Contents),
				new SqlParameter("@Avatar", articlesInfo.Avatar),
				new SqlParameter("@Image", articlesInfo.Image),
				new SqlParameter("@Author", articlesInfo.Author),
				new SqlParameter("@CreateDate", articlesInfo.CreateDate)
			};

			articlesInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Articles_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Articles table.
		/// </summary>
		public virtual void Update(ArticlesInfo articlesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", articlesInfo.ID),
				new SqlParameter("@CategoryID", articlesInfo.CategoryID),
				new SqlParameter("@Title", articlesInfo.Title),
				new SqlParameter("@Summary", articlesInfo.Summary),
				new SqlParameter("@Contents", articlesInfo.Contents),
				new SqlParameter("@Avatar", articlesInfo.Avatar),
				new SqlParameter("@Image", articlesInfo.Image),
				new SqlParameter("@Author", articlesInfo.Author),
				new SqlParameter("@CreateDate", articlesInfo.CreateDate)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Articles_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Articles table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Articles_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the Articles table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByCategoryID(int categoryID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CategoryID", categoryID)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Articles_DeleteAllByCategoryID", parameters);
		}

		/// <summary>
		/// Selects a single record from the Articles table.
		/// </summary>
		public virtual ArticlesInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Articles_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeArticlesInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Articles table.
		/// </summary>
		public CHRTList<ArticlesInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Articles_SelectAll"))
			{
				CHRTList<ArticlesInfo> articlesInfoList = new CHRTList<ArticlesInfo>();
				while (dataReader.Read())
				{
					ArticlesInfo articlesInfo = MakeArticlesInfo(dataReader);
					articlesInfoList.Add(articlesInfo);
				}

				return articlesInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the Articles table by a foreign key.
		/// </summary>
		public virtual CHRTList<ArticlesInfo> SelectAllByCategoryID(int categoryID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CategoryID", categoryID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Articles_SelectAllByCategoryID", parameters))
			{
				CHRTList<ArticlesInfo> articlesInfoList = new CHRTList<ArticlesInfo>();
				while (dataReader.Read())
				{
					ArticlesInfo articlesInfo = MakeArticlesInfo(dataReader);
					articlesInfoList.Add(articlesInfo);
				}

				return articlesInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Articles class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual ArticlesInfo MakeArticlesInfo(SqlDataReader dataReader)
		{
			ArticlesInfo articlesInfo = new ArticlesInfo();
			articlesInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.ARTICLES.ID, 0);
			articlesInfo.CategoryID = SqlClientUtility.GetInt32(dataReader,DbConstants.ARTICLES.CATEGORYID, 0);
			articlesInfo.Title = SqlClientUtility.GetString(dataReader,DbConstants.ARTICLES.TITLE, String.Empty);
			articlesInfo.Summary = SqlClientUtility.GetString(dataReader,DbConstants.ARTICLES.SUMMARY, String.Empty);
			articlesInfo.Contents = SqlClientUtility.GetString(dataReader,DbConstants.ARTICLES.CONTENTS, String.Empty);
			articlesInfo.Avatar = SqlClientUtility.GetString(dataReader,DbConstants.ARTICLES.AVATAR, String.Empty);
			articlesInfo.Image = SqlClientUtility.GetString(dataReader,DbConstants.ARTICLES.IMAGE, String.Empty);
			articlesInfo.Author = SqlClientUtility.GetString(dataReader,DbConstants.ARTICLES.AUTHOR, String.Empty);
			articlesInfo.CreateDate = SqlClientUtility.GetDateTime(dataReader,DbConstants.ARTICLES.CREATEDATE, DateTime.Now);

			return articlesInfo;
		}

		#endregion
	}
}
