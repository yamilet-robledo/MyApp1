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
        string cadenaConexion = "Server=localhost,1434;Database=Agenda" +
            ";User Id=sa;Password=Y25130232?;TrustServerCertificate=True;";
        public Datos()
        {

        }
        private void conexionOpen()
        {
            try
            {
               SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return null;
            }
        }
        private void conexionClose(SqlConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());

            }
        }
        public bool ejecutar( string command)
        {
            try
            { 
                SqlConnection conectar = conexionOpen();
                SqlConnection sqlCommand = new SqlCommand(command, conectar);
                sqlCommand.ExecuteNonQuery();
                conexionClose(conectar);
                return true;
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }
        }
        public bool ejecutar(SqlCommand command)
        {
            try
            {
                SqlConnection conectar = conexionOpen();
                command.Connection = conectar;
                command.ExecuteNonQuery();
                conexionClose(conectar);
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
              SqlConnection conecta = conexionOpen();
                SqlDataAdapter da = new SqlDataAdapter(comando, conecta);
                da.Fill(ds);
                conexionClose(conecta);
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
