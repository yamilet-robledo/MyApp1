using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
   
    public partial class frmAgregar : Form
    {
        bool updateMode = false;
        Datos datos;
       
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(String nombre, string paterno, string materno, string telefono, string correo)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtPaterno.Text = paterno;  
            txtMaterno.Text = materno;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            btnAgregar.Text = "Actualiza";
            updateModde = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
                datos = new Datos();
                bool f = datos.ejecutar("Insert Into Datos(nombre, paterno, materno, telefono, correo)Values" +
                    "('" + txtNombre.Text + "','" + txtPaterno.Text + "','" + txtMaterno.Text + "','" + txtTelefono.Text
                    + "','" + txtCorreo.Text + "')");
                if(f)
                {
                    MessageBox.Show("Registros agregados correctamente");
                    this.Close();
                }
                else
                {
                    //MessageBox.Show("Error al agregar el registro");
                   SqlCommand comando = new SqlCommand("Update Datos set nombre =@nombre, " +
                        "paterno = @paterno, materno = @materno, telefono = @telefono," +
                        " correo = @correo where id = @id");
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@paterno", txtPaterno.Text);
                comando.Parameters.AddWithValue("@materno", txtMaterno.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comando.Parameters.AddWithValue("@id", 1); // Assuming you have an ID to update
                bool f = datos.ejecutar(comando);
                if (f)
                {
                    MessageBox.Show("Registro actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro");
                }
            }
            }
           
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
