using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace seguridad_rup
{
	internal class SQL_Conexion
	{
		
			public OdbcConnection conexion()
			{
				OdbcConnection conn = new OdbcConnection("Dsn=rup");// creacion de la conexion via ODBC
				try
				{
					conn.Open();
				}
				catch (OdbcException)
				{
					Console.WriteLine("No Conectó");
				}
				return conn;
			}

			public void Desconexion(OdbcConnection conn)
			{
				try
				{
					conn.Close();
				}
				catch (OdbcException)
				{
					Console.WriteLine("No Conectó");
				}

			}
		
	}
}