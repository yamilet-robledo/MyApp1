using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Datos
    {
        SqlConnection conexion;
        string cadenaConexion = "Server=localhost,1434;Database=Agenda;User Id=sa;Password=Y25130232?;TrustServerCertificate=True;";
        public Datos()
        {

        }
        private void conexionOpen()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
        private SqlConnection conexionClose(SqlConnection conexion)
        {
            try
            {
                conexion.Close();
                return conexion;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return null;
            }
        }
        public bool Insertar(string nombre, string paterno, string materno, string telefono, string correo)
        {
            try
            {
                conexionOpen();
                string comando = "Insert Into Datos(nombre, paterno, materno, telefono, " +
                    "correo)Values('" + nombre + "','" + paterno + "','" + materno + "','" + telefono + "','" + correo + "')";
                SqlCommand sqlCommand = new SqlCommand(comando, conexion);
                sqlCommand.ExecuteNonQuery();
                conexionClose(conexion);
                return true;
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }
        }
        public DataSet informacion(string comando)
        {
            DataSet ds = new DataSet();
            try
            {
                conexionOpen();
                SqlDataAdapter da = new SqlDataAdapter(comando, conexion);
                da.Fill(ds);
                conexionClose(conexion);
                return ds;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return null;
            }
        }
    }
}
