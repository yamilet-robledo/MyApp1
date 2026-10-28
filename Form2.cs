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
        int id;
        Datos datos;
       
        public frmAgregar()
        {
            InitializeComponent();
         
        }
       
        public frmAgregar(int id, string nombre, string paterno, string materno, string telefono, string correo)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtPaterno.Text = paterno;  
            txtMaterno.Text = materno;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            btnAgregar.Text = "Actualiza";

            updateMode = true;
            this.id = id;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            datos = new Datos();
            if (updateMode == false)
            {
            bool f = datos.ejecutar("Insert Into Datos(nombre, paterno, materno, telefono, correo)Values" +
                "('" + txtNombre.Text + "','" + txtPaterno.Text + "','" + txtMaterno.Text + "','" + txtTelefono.Text
                + "','" + txtCorreo.Text + "')");
            if (f)
            {
                MessageBox.Show("Registros agregados correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el registro");
            } 
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
                comando.Parameters.AddWithValue("@id", this.id);
          
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

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            datos = new Datos();
            DataSet dsEstados, dsMunicipios;
            dsEstados = datos.informacion("Select * from Estados");
            if(dsEstados!=null && dsEstados.Tables.Count > 0)
            {
                cmbEstado.DataSource = dsEstados.Tables[0];
                cmbEstado.DisplayMember = "Estado";
                cmbEstado.ValueMember = "idEstado";

                dsMunicipios=datos.informacion("Select * from Municipios where idEstado = " + cmbEstado.SelectedValue);
                if(dsMunicipios!=null && dsMunicipios.Tables.Count > 0)
                {
                    cmbMunicipio.DataSource = dsMunicipios.Tables[0];
                    cmbMunicipio.DisplayMember = "Municipio";
                    cmbMunicipio.ValueMember = "idMunicipio";
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}



