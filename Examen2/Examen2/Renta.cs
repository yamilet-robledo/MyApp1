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
    public partial class Renta : Form
    {
        Datos datos = new Datos();
        List<int> peliculasPorRentar = new List<int>();
        public Renta()
        {
            InitializeComponent();
        }

        private void Renta_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ActualizarGrid();
        }
        private void CargarCombos()
        {
            DataSet dsSuscriptores = datos.informacion("select id, nombre From suscriptor");
            if (dsSuscriptores != null && dsSuscriptores.Tables.Count > 0)
            {
                cbSuscriptor.DataSource = dsSuscriptores.Tables[0];
                cbSuscriptor.DisplayMember = "nombre";
                cbSuscriptor.ValueMember = "id";
            }

            DataSet dsPeliculas = datos.informacion("SELECT Peliculas.id, Peliculas.pelicula FROM Peliculas LEFT JOIN Rentas ON Peliculas.id = Rentas.idPelicula WHERE Rentas.idPelicula IS NULL");
            if (dsPeliculas != null && dsPeliculas.Tables.Count > 0)
            {
                cbPelicula.DataSource = dsPeliculas.Tables[0];
                cbPelicula.DisplayMember = "pelicula";
                cbPelicula.ValueMember = "id";
            }
            else
            {
                cbPelicula.DataSource = null; 
            }
        }
        private void ActualizarComboPeliculas()
        {
            string consulta = "SELECT Peliculas.id, Peliculas.pelicula FROM Peliculas " +
                "LEFT JOIN Rentas ON Peliculas.id = Rentas.idPelicula WHERE Rentas.idPelicula IS NULL";
            if (peliculasPorRentar.Count > 0)
            {
             string idExcluir = string.Join(",", peliculasPorRentar);
                consulta += " AND Peliculas.id NOT IN (" + idExcluir + ")";
            }
            DataSet dsPeliculas = datos.informacion(consulta);
            if(dsPeliculas != null && dsPeliculas.Tables.Count > 0)
            {
                cbPelicula.DataSource = dsPeliculas.Tables[0];
                cbPelicula.DisplayMember = "pelicula";
                cbPelicula.ValueMember = "id";
                cbPelicula.Enabled = true;
            }
            else
            {
                cbPelicula.DataSource = null;
                cbPelicula.Enabled = false;
            }

        }
        private void ActualizarGrid()
        {
            string comando = @"SELECT Rentas.ID, Suscriptor.Nombre, Peliculas.Pelicula
                                FROM     Peliculas INNER JOIN
                                Rentas ON Peliculas.ID = Rentas.IDPelicula INNER JOIN
                                Suscriptor ON Rentas.IDSuscriptor = Suscriptor.ID";
            DataSet ds = datos.informacion(comando);
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvRenta.DataSource = ds.Tables[0];
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbSuscriptor.SelectedValue != null && cbPelicula.SelectedValue != null)
            {
                string idSuscriptor = cbSuscriptor.SelectedValue.ToString();
                string idPelicula = cbPelicula.SelectedValue.ToString();
                int cantidadNuevasRentas = peliculasPorRentar.Count;

                DataSet dsConteo = datos.informacion("select count(*) as Total from Rentas where idSuscriptor = " + idSuscriptor);
                if (dsConteo != null && dsConteo.Tables.Count > 0)
                {
                    int conteo = Convert.ToInt32(dsConteo.Tables[0].Rows[0]["Total"]);
                    if (dsConteo != null && dsConteo.Tables.Count > 0)
                    {
                        int conteoActual = Convert.ToInt32(dsConteo.Tables[0].Rows[0]["Total"]);
                        int limiteMaximo = 2;

                        if ((conteoActual + cantidadNuevasRentas) > limiteMaximo)
                        {
                            MessageBox.Show("limite Excedido");
                            return;
                        }
                    }
                    bool exitoGeneral = true;
                    foreach (int idPelicula in peliculasPorRentar)
                    {
                        bool f = datos.ejecutar("Insert Into Rentas(idSuscriptor, idPelicula) values(" + idSuscriptor + ", " + idPelicula + ")");
                        if (!f)
                        {
                            exitoGeneral = false;

                        }

                    }
                    if (exitoGeneral)
                    {
                        MessageBox.Show("se registraron bien");
                        peliculasPorRentar.Clear();
                        ActualizarGrid();
                        CargarCombos();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un suscriptor y una película");
            }
        }

        private void cbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cbPelicula.SelectedValue != null)
            {
                int idPelicula = Convert.ToInt32(cbPelicula.SelectedValue);
                peliculasPorRentar.Add(idPelicula);
                MessageBox.Show("Película agregada");
                ActualizarComboPeliculas();
            }
            else
            {
                MessageBox.Show("Seleccione una película que si este disponible para agregar");
            }
        }
    }
}
