using MyApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class frmSuscriptores : Form
    {
        Datos datos = new Datos();    
        public frmSuscriptores()
        {
            InitializeComponent();
        }

        private void frmSuscriptores_Load(object sender, EventArgs e)
        {
            dgvSuscriptores.AutoGenerateColumns = false;

            ActualizarGrid("Select id, nombre From Suscriptor");

        }
        private void ActualizarGrid(string comando)
        {
           DataSet ds = datos.informacion(comando);
            if (ds != null)
            {
                dgvSuscriptores.DataSource = ds.Tables[0];
            }
        }
        

        private void btnAgg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNom.Text))
            {
                bool f = datos.ejecutar("insert Into Suscriptor (nombre)" +
                    "values ('" + txtNom.Text + "')");
                if (f)
                {
                    MessageBox.Show("Suscriptor agregado correctamente");
                    ActualizarGrid("Select id,nombre From Suscriptor");
                    txtNom.Clear();
                    txtNom.Focus();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
                } 
                else
                {   
                MessageBox.Show("Ingrese un nombre");
                }

            }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvSuscriptores.CurrentRow != null && !string.IsNullOrWhiteSpace(txtNom.Text))
            {
                string id = dgvSuscriptores.CurrentRow.Cells["id"].Value.ToString();
                string nuevoNombre = txtNom.Text;

                bool f = datos.ejecutar("UPDATE Suscriptor SET nombre = '" + nuevoNombre + "' WHERE id = " + id);

                if (f)
                {
                    MessageBox.Show("Suscriptor modificado correctamente.");
                    ActualizarGrid("Select id, nombre From Suscriptor");
                    txtNom.Clear();
                    txtNom.Focus();
                }
                else
                {
                    MessageBox.Show("Error al modificar el suscriptor.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un suscriptor de la tabla y escribe el nuevo nombre.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvSuscriptores.CurrentRow != null)
            {
                string id = dgvSuscriptores.CurrentRow.Cells["id"].Value.ToString();

                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este suscriptor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    bool f = datos.ejecutar("DELETE FROM Suscriptor WHERE id = " + id);
                    if (f)
                    {
                        MessageBox.Show("Suscriptor eliminado correctamente.");
                        ActualizarGrid("Select id, nombre From Suscriptor");
                        txtNom.Clear();
                        txtNom.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el suscriptor (puede que tenga rentas activas asociadas).");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un suscriptor de la tabla para eliminar.");
            }
        }
        

        private void dgvSuscriptores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuscriptores.Rows[e.RowIndex];
                txtNom.Text = row.Cells["nombre"].Value.ToString();
            }
        }
    }
    
}

