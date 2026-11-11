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
    public partial class frmPeliculas : Form
    {
        Datos datos= new Datos();
        public  frmPeliculas()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           bool f = datos.ejecutar("Insert Into Peliculas(pelicula)" +
            "values('" + txtPelicula.Text + "')");
            if (f)
            {
                ActualizaGrid("Select id,pelicula From Peliculas");
            }
        }
        private void ActualizaGrid(string comando)
        {
          DataSet ds = datos.informacion(comando);
           if(ds != null)
            {
            dgvPeliculas.DataSource = ds.Tables[0];
            }
         
        }
        private void frmPeliculas_Load(object sender,EventArgs e)
        {
            dgvPeliculas.AutoGenerateColumns = false;
            ActualizaGrid("Select id,pelicula From Peliculas");
        }

        private void frmPeliculas_Load_1(object sender, EventArgs e)
        {
            dgvPeliculas.AutoGenerateColumns = false;
            ActualizaGrid("Select id,pelicula From Peliculas");

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPelicula.Text))
            {
                bool f = datos.ejecutar("Insert Into Peliculas(pelicula)" +
                "values('" + txtPelicula.Text + "')");
                if (f)
                {
                    MessageBox.Show("Pelicula agregada");
                    ActualizaGrid("Select id,pelicula From Peliculas");
                    txtPelicula.Clear();
                    txtPelicula.Focus();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la pelicula");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvPeliculas.SelectedRows.Count > 0 || dgvPeliculas.CurrentRow != null)
            {
                string id = dgvPeliculas.CurrentRow.Cells["id"].Value.ToString();

                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar esta película?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    bool f = datos.ejecutar("DELETE FROM Peliculas WHERE id = " + id);
                    if (f)
                    {
                        MessageBox.Show("Película eliminada correctamente.");
                        ActualizaGrid("Select id,pelicula From Peliculas");
                        txtPelicula.Clear();
                        txtPelicula.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la película.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película de la tabla para eliminar.");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow != null && !string.IsNullOrEmpty(txtPelicula.Text))
            {   
                string id = dgvPeliculas.CurrentRow.Cells["id"].Value.ToString();
                string nuevoNombre = txtPelicula.Text;

                bool f = datos.ejecutar("UPDATE Peliculas SET pelicula = '" + nuevoNombre + "' WHERE id = " + id);

                if (f)
                {
                    MessageBox.Show("Película modificada correctamente.");
                    ActualizaGrid("Select id,pelicula From Peliculas");
                    txtPelicula.Clear();
                    txtPelicula.Focus();
                }
                else
                {
                    MessageBox.Show("Error al modificar la película.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una película de la tabla y escribe el nuevo nombre en la caja de texto.");
            }
        }

        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPeliculas.Rows[e.RowIndex];
                
                txtPelicula.Text = row.Cells["pelicula"].Value.ToString();
            }
        }
    }
}
