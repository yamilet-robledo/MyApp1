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
    public partial class frmRentar : Form
    {
        public frmRentar()
        {
            InitializeComponent();
           
        }

        private void frmRentar_Load(string Nombre, string Apellido, string Edad, string Telefono, string Correo)
        {
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtTelefono.Text = Telefono;
            txtCorreo.Text = Correo;
        }

        private void frmRentar_Load(object sender, EventArgs e)
        {

        }
    }
}
