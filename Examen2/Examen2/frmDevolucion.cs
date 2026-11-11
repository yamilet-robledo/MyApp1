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
    public partial class frmDevolucion : Form
    {
        Datos datos = new Datos();
        bool inicio = false;
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            CargarSuscriptoresConRentas();
            inicio = true;

            if (cmbSuscriptor.SelectedValue != null)
            {
                CargarPeliculasDelSuscriptor(Convert.ToInt32(cmbSuscriptor.SelectedValue));
            }
        }
        private void CargarSuscriptoresConRentas()
        {
            string consulta = "SELECT DISTINCT Suscriptor.id, Suscriptor.nombre FROM Suscriptor INNER JOIN Rentas ON Suscriptor.id = Rentas.idSuscriptor";
            DataSet ds = datos.informacion(consulta);

            if (ds != null && ds.Tables.Count > 0)
            {
                cmbSuscriptor.DataSource = ds.Tables[0];
                cmbSuscriptor.DisplayMember = "nombre";
                cmbSuscriptor.ValueMember = "id";
            }
            else
            {
                cmbSuscriptor.DataSource = null;
                cmbPelicula.DataSource = null;
            }
        }
        private void CargarPeliculasDelSuscriptor(int idSuscriptor)
        {
            string consulta = "SELECT Peliculas.id, Peliculas.pelicula FROM Peliculas INNER JOIN Rentas ON Peliculas.id = Rentas.idPelicula WHERE Rentas.idSuscriptor = " + idSuscriptor;
            DataSet ds = datos.informacion(consulta);

            cmbPelicula.DataSource = null;
            if (ds != null && ds.Tables.Count > 0)
            {
                cmbPelicula.DataSource = ds.Tables[0];
                cmbPelicula.DisplayMember = "pelicula";
                cmbPelicula.ValueMember = "id";
            }
        }

        private void cmbSuscriptor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicio && cmbSuscriptor.SelectedValue != null)
            {
                int idSuscriptor;
                if (int.TryParse(cmbSuscriptor.SelectedValue.ToString(), out idSuscriptor))
                {
                    CargarPeliculasDelSuscriptor(idSuscriptor);
                }
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (cmbSuscriptor.SelectedValue != null && cmbPelicula.SelectedValue != null)
            {
                string idSuscriptor = cmbSuscriptor.SelectedValue.ToString();
                string idPelicula = cmbPelicula.SelectedValue.ToString();

                string queryDelete = "DELETE FROM Rentas WHERE idSuscriptor = " + idSuscriptor + " AND idPelicula = " + idPelicula;
                bool exito = datos.ejecutar(queryDelete);

                if (exito)
                {
                    MessageBox.Show("Película devuelta correctamente.");

                    CargarSuscriptoresConRentas();
                    if (cmbSuscriptor.SelectedValue != null)
                    {
                        CargarPeliculasDelSuscriptor(Convert.ToInt32(cmbSuscriptor.SelectedValue));
                    }
                }
                else
                {
                    MessageBox.Show("Error al procesar la devolución en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un suscriptor y una película válida para devolver.");
            }
        }
    }
}


