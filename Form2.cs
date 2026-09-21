using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form2 : Form
    {
        public Form2(String nombre, String correo)
        {
            InitializeComponent();
            txtnombre.Text = nombre;
            txtcorreo.Text = correo;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
