using System;
using System.Data;
namespace CCategoria
{
	public class DbHelper
	{
		public static void dbCommandAddParameter(IDbCommand dbCommand, string parameterName, object value){
			IDbDataParameter dbDataParameter = dbCommand.CreateParameter();
			dbDataParameter.ParameterName = parameterName ;
			dbDataParameter.Value = value ;
			dbCommand.Parameters.Add(dbDataParameter);
		}
	}
}

