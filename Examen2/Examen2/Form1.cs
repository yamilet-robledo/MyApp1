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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRentar Rentar = new frmRentar();
            Rentar.Show();
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolver Devolver = new frmDevolver();
            Devolver.Show();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmInformacion informacion = new frmInformacion();
            informacion.Show();
        }
    }
}
