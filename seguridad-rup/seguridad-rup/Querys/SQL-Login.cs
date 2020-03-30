using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace seguridad_rup
{
	
	class SQL_Login
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public string Ingresar(string User, string Pass, string modulo) {
			bool  succes = ConsultarUsuario(User, Pass);
			string respuesta = "";
			if (succes)
			{
				string sql = "SELECT permiso FROM permisos_modulos WHERE id_usuario= " +
				"(Select id_usuario from usuarios where nombre_usuario ='" + User + "') AND id_modulo=" + modulo + " AND estatus ='activo';";
				OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
				OdbcDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					respuesta = "Exito";
				}
				else
				{
					respuesta = "Fallo";
				}
			}
			else { respuesta = "No Existe"; }
			return respuesta;
		}
		bool ConsultarUsuario(string User, string Pass) {
			string sql = "SELECT estatus FROM usuarios WHERE nombre_usuario='" + User + "' AND clave=MD5('" + Pass + "');";
			bool respuesta = false;
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows && reader.GetValue(0).ToString() == "activo")
			{
				respuesta = true;
			}
			else
			{
				respuesta = false;
			}
			return respuesta;
		}

	}
}
