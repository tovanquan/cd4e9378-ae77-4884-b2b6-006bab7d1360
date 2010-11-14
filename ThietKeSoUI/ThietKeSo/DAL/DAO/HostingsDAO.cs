using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Base;
using thietkeso.DAL.Utils;

namespace thietkeso.DAL
{
	public class HostingsDAO : HostingsDAOBase
	{
		#region Constructors

		public HostingsDAO()
			: base(Constants.CONNECTION_STRING_NAME)
		{
		}

		#endregion

		#region Methods


		#endregion
	}
}
