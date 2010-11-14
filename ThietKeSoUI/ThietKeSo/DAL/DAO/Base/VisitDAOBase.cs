using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class VisitDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public VisitDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Selects all records from the Visit table.
		/// </summary>
		public CHRTList<VisitInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Visit_SelectAll"))
			{
				CHRTList<VisitInfo> visitInfoList = new CHRTList<VisitInfo>();
				while (dataReader.Read())
				{
					VisitInfo visitInfo = MakeVisitInfo(dataReader);
					visitInfoList.Add(visitInfo);
				}
				return visitInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Visit class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual VisitInfo MakeVisitInfo(SqlDataReader dataReader)
		{
			VisitInfo visitInfo = new VisitInfo();
			visitInfo.Visited = SqlClientUtility.GetInt32(dataReader,DbConstants.VISIT.VISITED, 0);
			visitInfo.Online = SqlClientUtility.GetInt32(dataReader,DbConstants.VISIT.ONLINE, 0);

			return visitInfo;
		}

		#endregion
	}
}
