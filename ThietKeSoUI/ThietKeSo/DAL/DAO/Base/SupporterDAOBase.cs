
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class SupporterDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public SupporterDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Supporter table.
		/// </summary>
		public virtual void Insert(SupporterInfo supporterInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Name", supporterInfo.Name),
				new SqlParameter("@Yahoo", supporterInfo.Yahoo),
				new SqlParameter("@Skype", supporterInfo.Skype),
				new SqlParameter("@Mail", supporterInfo.Mail),
				new SqlParameter("@Mobile", supporterInfo.Mobile)
			};

			supporterInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Supporter_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Supporter table.
		/// </summary>
		public virtual void Update(SupporterInfo supporterInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", supporterInfo.ID),
				new SqlParameter("@Name", supporterInfo.Name),
				new SqlParameter("@Yahoo", supporterInfo.Yahoo),
				new SqlParameter("@Skype", supporterInfo.Skype),
				new SqlParameter("@Mail", supporterInfo.Mail),
				new SqlParameter("@Mobile", supporterInfo.Mobile)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Supporter_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Supporter table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Supporter_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the Supporter table.
		/// </summary>
		public virtual SupporterInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Supporter_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeSupporterInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Supporter table.
		/// </summary>
		public CHRTList<SupporterInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Supporter_SelectAll"))
			{
				CHRTList<SupporterInfo> supporterInfoList = new CHRTList<SupporterInfo>();
				while (dataReader.Read())
				{
					SupporterInfo supporterInfo = MakeSupporterInfo(dataReader);
					supporterInfoList.Add(supporterInfo);
				}

				return supporterInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Supporter class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual SupporterInfo MakeSupporterInfo(SqlDataReader dataReader)
		{
			SupporterInfo supporterInfo = new SupporterInfo();
			supporterInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.SUPPORTER.ID, 0);
			supporterInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.SUPPORTER.NAME, String.Empty);
			supporterInfo.Yahoo = SqlClientUtility.GetString(dataReader,DbConstants.SUPPORTER.YAHOO, String.Empty);
			supporterInfo.Skype = SqlClientUtility.GetString(dataReader,DbConstants.SUPPORTER.SKYPE, String.Empty);
			supporterInfo.Mail = SqlClientUtility.GetString(dataReader,DbConstants.SUPPORTER.MAIL, String.Empty);
			supporterInfo.Mobile = SqlClientUtility.GetString(dataReader,DbConstants.SUPPORTER.MOBILE, String.Empty);

			return supporterInfo;
		}

		#endregion
	}
}
