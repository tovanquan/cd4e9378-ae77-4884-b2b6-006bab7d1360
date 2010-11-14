using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class TempCategoriesDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public TempCategoriesDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the TempCategories table.
		/// </summary>
		public virtual void Insert(TempCategoriesInfo tempCategoriesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Name", tempCategoriesInfo.Name),
				new SqlParameter("@Description", tempCategoriesInfo.Description)
			};

			tempCategoriesInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "TempCategories_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the TempCategories table.
		/// </summary>
		public virtual void Update(TempCategoriesInfo tempCategoriesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", tempCategoriesInfo.ID),
				new SqlParameter("@Name", tempCategoriesInfo.Name),
				new SqlParameter("@Description", tempCategoriesInfo.Description)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TempCategories_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the TempCategories table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "TempCategories_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the TempCategories table.
		/// </summary>
		public virtual TempCategoriesInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "TempCategories_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeTempCategoriesInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the TempCategories table.
		/// </summary>
		public CHRTList<TempCategoriesInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "TempCategories_SelectAll"))
			{
				CHRTList<TempCategoriesInfo> tempCategoriesInfoList = new CHRTList<TempCategoriesInfo>();
				while (dataReader.Read())
				{
					TempCategoriesInfo tempCategoriesInfo = MakeTempCategoriesInfo(dataReader);
					tempCategoriesInfoList.Add(tempCategoriesInfo);
				}

				return tempCategoriesInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the TempCategories class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual TempCategoriesInfo MakeTempCategoriesInfo(SqlDataReader dataReader)
		{
			TempCategoriesInfo tempCategoriesInfo = new TempCategoriesInfo();
			tempCategoriesInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.TEMPCATEGORIES.ID, 0);
			tempCategoriesInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.TEMPCATEGORIES.NAME, String.Empty);
			tempCategoriesInfo.Description = SqlClientUtility.GetString(dataReader,DbConstants.TEMPCATEGORIES.DESCRIPTION, String.Empty);

			return tempCategoriesInfo;
		}

		#endregion
	}
}
