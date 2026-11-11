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

                DataSet dsConteo = datos.informacion("select count(*) as Total from Rentas where idSuscriptor = " + idSuscriptor);
                if (dsConteo != null && dsConteo.Tables.Count > 0)
                {
                    int conteo = Convert.ToInt32(dsConteo.Tables[0].Rows[0]["Total"]);
                    if (conteo >= 2)
                    {
                        MessageBox.Show("limite de rentas alcanzado");
                        return;
                    }
                }
                bool f = datos.ejecutar("insert into Rentas (idSuscriptor, idPelicula) values (" + idSuscriptor + "," + idPelicula + ")");
                if (f)
                {
                    MessageBox.Show("Renta registrada");
                    ActualizarGrid();
                    CargarCombos();

                }
                else
                {
                    MessageBox.Show("error");
                }
                
            }
        }

        private void cbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
