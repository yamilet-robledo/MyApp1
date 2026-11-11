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
        Datos obj = new Datos();
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
            DataSet dsSuscriptores = obj.informacion("select id, nombre From suscriptor");
            if (dsSuscriptores != null && dsSuscriptores.Tables.Count > 0)
            {
                cbSuscriptor.DataSource = dsSuscriptores.Tables[0];
                cbSuscriptor.DisplayMember = "nombre";
                cbSuscriptor.ValueMember = "id";
            }
            DataSet dsPeliculas = obj.informacion("select id, nombre From peliculas");
            if (dsPeliculas != null && dsPeliculas.Tables.Count > 0)
            {
                cbPelicula.DataSource = dsPeliculas.Tables[0];
                cbPelicula.DisplayMember = "nombre";
                cbPelicula.ValueMember = "id";
            }
        }
        private void ActualizarGrid()
        {
            string comando = @"SELECT Rentas.ID, Suscriptor.Nombre, Peliculas.Pelicula
                                FROM     Peliculas INNER JOIN
                                Rentas ON Peliculas.ID = Rentas.IDPelicula INNER JOIN
                                Suscriptor ON Rentas.IDSuscriptor = Suscriptor.ID";
            DataSet ds = obj.informacion(comando);
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvRenta.DataSource = ds.Tables[0];
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbSuscriptor.SelectedValue != null && cbPelicula.SelectedValue != null)
            {
                string comando = "insert into Rentas (idSuscriptor, idPelicula) values (idSuscriptor, idPelicula) values (" +
                        cbSuscriptor.SelectedValue + "," + cbPelicula.SelectedValue + ")";
                bool exito = obj.ejecutar(comando);
                if (exito)
                {
                    MessageBox.Show("Renta registrada");
                    ActualizarGrid();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("agarra un suscriptor y una película");
            }
        }
    }
}
