using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class PartnersDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public PartnersDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Partners table.
		/// </summary>
		public virtual void Insert(PartnersInfo partnersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Name", partnersInfo.Name),
				new SqlParameter("@Logo", partnersInfo.Logo)
			};

			partnersInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Partners_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Partners table.
		/// </summary>
		public virtual void Update(PartnersInfo partnersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", partnersInfo.ID),
				new SqlParameter("@Name", partnersInfo.Name),
				new SqlParameter("@Logo", partnersInfo.Logo)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Partners_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Partners table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Partners_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the Partners table.
		/// </summary>
		public virtual PartnersInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Partners_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakePartnersInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Partners table.
		/// </summary>
		public CHRTList<PartnersInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Partners_SelectAll"))
			{
				CHRTList<PartnersInfo> partnersInfoList = new CHRTList<PartnersInfo>();
				while (dataReader.Read())
				{
					PartnersInfo partnersInfo = MakePartnersInfo(dataReader);
					partnersInfoList.Add(partnersInfo);
				}

				return partnersInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Partners class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual PartnersInfo MakePartnersInfo(SqlDataReader dataReader)
		{
			PartnersInfo partnersInfo = new PartnersInfo();
			partnersInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.PARTNERS.ID, 0);
			partnersInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.PARTNERS.NAME, String.Empty);
			partnersInfo.Logo = SqlClientUtility.GetString(dataReader,DbConstants.PARTNERS.LOGO, String.Empty);

			return partnersInfo;
		}

		#endregion
	}
}
