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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suscriptoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuscriptores suscriptor = new frmSuscriptores();
            suscriptor.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeliculas pelicula = new frmPeliculas();
            pelicula.ShowDialog();
        }

        private void rentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Renta renta = new Renta();
            renta.ShowDialog();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucion devolucion = new frmDevolucion();
            devolucion.ShowDialog();
        }
    }
}
