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
        Datos obj = new Datos();
        public  frmPeliculas()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           bool f = obj.ejecutar("Insert Into Peliculas(pelicula)" +
            "values('" + txtPelicula.Text + "')");
            if (f)
            {
                ActualizaGrid("Select id,pelicula From Peliculas");
            }
        }
        private void ActualizaGrid(string comando)
        {
          DataSet ds = obj.informacion(comando);
           if(ds != null)
            {
            dgvPeliculas.DataSource = ds.Tables[0];
            }
         
        }
        private void frmPeliculas_Load(object sender,EventArgs e)
        {
            ActualizaGrid("Select id,pelicula From Peliculas");
        }

        private void frmPeliculas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
