
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class TemplatesDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public TemplatesDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Templates table.
		/// </summary>
		public virtual void Insert(TemplatesInfo templatesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TempCategoryID", templatesInfo.TempCategoryID),
				new SqlParameter("@Name", templatesInfo.Name),
				new SqlParameter("@Description", templatesInfo.Description),
				new SqlParameter("@Image", templatesInfo.Image)
			};

			templatesInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Templates_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Templates table.
		/// </summary>
		public virtual void Update(TemplatesInfo templatesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", templatesInfo.ID),
				new SqlParameter("@TempCategoryID", templatesInfo.TempCategoryID),
				new SqlParameter("@Name", templatesInfo.Name),
				new SqlParameter("@Description", templatesInfo.Description),
				new SqlParameter("@Image", templatesInfo.Image)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Templates_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Templates table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Templates_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the Templates table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByTempCategoryID(int tempCategoryID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TempCategoryID", tempCategoryID)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Templates_DeleteAllByTempCategoryID", parameters);
		}

		/// <summary>
		/// Selects a single record from the Templates table.
		/// </summary>
		public virtual TemplatesInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Templates_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeTemplatesInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Templates table.
		/// </summary>
		public CHRTList<TemplatesInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Templates_SelectAll"))
			{
				CHRTList<TemplatesInfo> templatesInfoList = new CHRTList<TemplatesInfo>();
				while (dataReader.Read())
				{
					TemplatesInfo templatesInfo = MakeTemplatesInfo(dataReader);
					templatesInfoList.Add(templatesInfo);
				}

				return templatesInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the Templates table by a foreign key.
		/// </summary>
		public virtual CHRTList<TemplatesInfo> SelectAllByTempCategoryID(int tempCategoryID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TempCategoryID", tempCategoryID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Templates_SelectAllByTempCategoryID", parameters))
			{
				CHRTList<TemplatesInfo> templatesInfoList = new CHRTList<TemplatesInfo>();
				while (dataReader.Read())
				{
					TemplatesInfo templatesInfo = MakeTemplatesInfo(dataReader);
					templatesInfoList.Add(templatesInfo);
				}

				return templatesInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Templates class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual TemplatesInfo MakeTemplatesInfo(SqlDataReader dataReader)
		{
			TemplatesInfo templatesInfo = new TemplatesInfo();
			templatesInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.TEMPLATES.ID, 0);
			templatesInfo.TempCategoryID = SqlClientUtility.GetInt32(dataReader,DbConstants.TEMPLATES.TEMPCATEGORYID, 0);
			templatesInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.TEMPLATES.NAME, String.Empty);
			templatesInfo.Description = SqlClientUtility.GetString(dataReader,DbConstants.TEMPLATES.DESCRIPTION, String.Empty);
			templatesInfo.Image = SqlClientUtility.GetString(dataReader,DbConstants.TEMPLATES.IMAGE, String.Empty);

			return templatesInfo;
		}

		#endregion
	}
}
