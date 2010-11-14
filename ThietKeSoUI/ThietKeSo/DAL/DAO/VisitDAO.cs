using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Base;
using thietkeso.DAL.Utils;

namespace thietkeso.DAL
{
	public class VisitDAO : VisitDAOBase
	{
		#region Constructors

		public VisitDAO()
			: base(Constants.CONNECTION_STRING_NAME)
		{
		}

		#endregion

		#region Methods


		#endregion
	}
}
