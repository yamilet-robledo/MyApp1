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
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool f = obj.ejecutar("Insert Into Peliculas (pelicula)" +
                "values('" + txtPelicula.Text + "')");
            if (f)
            {
                ActualizarGrid("Selected id, pelicula From Peliculas");
            }
        }
        private void ActualizarGrid (string comando) {

            DataSet ds = object.Informacion(comando);
    }
}
