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
    public partial class frmSuscriptores : Form
    {
        Datos obj = new Datos();    
        public frmSuscriptores()
        {
            InitializeComponent();
        }

        private void frmSuscriptores_Load(object sender, EventArgs e)
        {
            ActualizarGrid("Select id, nombre From Suscriptor");
        }
        private void ActualizarGrid(string comando)
        {
           DataSet ds = obj.informacion(comando);
            if (ds != null)
            {
                dgvSuscriptores.DataSource = ds.Tables[0];
            }
        }
        private void btnAgregar(object sender, EventArgs e)
        {
               bool f = obj.ejecutar("insert Into Suscriptor (nombre)" +
                   "values ('" + txtBuscar.Text + "')" );
            if (f)
            { 
                ActualizarGrid("Selected id,nombre From Suscriptores");
            }
        }
    }
}
