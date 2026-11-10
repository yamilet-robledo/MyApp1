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
    public partial class frmSuscriptores : Form
    {
        public frmSuscriptores()
        {
            InitializeComponent();
        }

        private void frmSuscriptores_Load(object sender, EventArgs e)
        {

        }
        private void ActualizarGrid(object sender, EventArgs e) { }
        private void btnAgregar (object sender, EventArgs e) {
        bool f = obj.ejecutar("insert Into Suscriptor (nombre)" +
            "values ('" + txtNombre.text + '"' }
    }
}
