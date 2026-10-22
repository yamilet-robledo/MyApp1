using CsvHelper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Globalization;
using System.IO;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofdCSV.FileName);
                CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                var registrosEstados = csv.GetRecords<Estado>().ToList();
                reader.Close();

                dgvRegistros.Rows.Clear();

                string conexionStr = "Server=TU_SERVIDOR;Database=Practica4_Topicos;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(conexionStr);

                conn.Open();

                foreach (var estado in registrosEstados)
                {
                    dgvRegistros.Rows.Add(estado.ID, estado.NOMBRE);
                    string query = "INSERT INTO ESTADOS (ID, NOMBRE) VALUES (@id, @nombre)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", estado.ID);
                    cmd.Parameters.AddWithValue("@nombre", estado.NOMBRE);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }


        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntCargarMunicipios_Click(object sender, EventArgs e)
        {
            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofdCSV.FileName);
                CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                var registrosMunicipios = csv.GetRecords<Municipio>().ToList();
                reader.Close();

                dgvRegistros.Rows.Clear();
                string conexionStr = "Server=TU_SERVIDOR;Database=Practica4_Topicos;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(conexionStr);

                conn.Open();

                foreach (var mun in registrosMunicipios)
                {
                    dgvRegistros.Rows.Add(mun.ID, mun.NOMBRE);

                    string query = "INSERT INTO MUNICIPIO (ID, NOMBRE, IDESTADO) VALUES (@id, @nombre, @idestado)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", mun.ID);
                    cmd.Parameters.AddWithValue("@nombre", mun.NOMBRE);
                    cmd.Parameters.AddWithValue("@idestado", mun.IDESTADO);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                MessageBox.Show("Municipios guardados correctamente en la base de datos.");
            }
        }
    }
    
   
}