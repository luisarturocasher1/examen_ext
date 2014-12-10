/*
 * Creado por SharpDevelop.
 * Usuario: Juan
 * Fecha: 10/12/2014
 * Hora: 10:31 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
namespace examen
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL()
		{
	
		}
		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=agenda;" +
	          	"User ID=root;" +
	          	"Password=;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}				
		
		
	}
}
