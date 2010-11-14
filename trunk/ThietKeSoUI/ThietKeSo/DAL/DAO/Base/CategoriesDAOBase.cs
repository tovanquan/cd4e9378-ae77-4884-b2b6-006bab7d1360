using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class CategoriesDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public CategoriesDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Categories table.
		/// </summary>
		public virtual void Insert(CategoriesInfo categoriesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Name", categoriesInfo.Name),
				new SqlParameter("@Description", categoriesInfo.Description)
			};

			categoriesInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Categories_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Categories table.
		/// </summary>
		public virtual void Update(CategoriesInfo categoriesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", categoriesInfo.ID),
				new SqlParameter("@Name", categoriesInfo.Name),
				new SqlParameter("@Description", categoriesInfo.Description)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Categories_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Categories table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Categories_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the Categories table.
		/// </summary>
		public virtual CategoriesInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Categories_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCategoriesInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Categories table.
		/// </summary>
		public CHRTList<CategoriesInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Categories_SelectAll"))
			{
				CHRTList<CategoriesInfo> categoriesInfoList = new CHRTList<CategoriesInfo>();
				while (dataReader.Read())
				{
					CategoriesInfo categoriesInfo = MakeCategoriesInfo(dataReader);
					categoriesInfoList.Add(categoriesInfo);
				}

				return categoriesInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Categories class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual CategoriesInfo MakeCategoriesInfo(SqlDataReader dataReader)
		{
			CategoriesInfo categoriesInfo = new CategoriesInfo();
			categoriesInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.CATEGORIES.ID, 0);
			categoriesInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.CATEGORIES.NAME, String.Empty);
			categoriesInfo.Description = SqlClientUtility.GetString(dataReader,DbConstants.CATEGORIES.DESCRIPTION, String.Empty);

			return categoriesInfo;
		}

		#endregion
	}
}
