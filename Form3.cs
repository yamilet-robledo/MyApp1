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
    public partial class frmInformacion : Form
    {
        private Datos datos;
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.Show();
;        }

        private void ActualizarGrid()
        {
             datos = new Datos();
            DataSet ds = datos.informacion("Select * from datos");
            if(ds != null)
            {
                dgvInformacion.AutoGenerateColumns = false;

                
                dgvInformacion.Columns[0].DataPropertyName = "Id";
                dgvInformacion.Columns[1].DataPropertyName = "nombre";
                dgvInformacion.Columns[2].DataPropertyName = "paterno";
                dgvInformacion.Columns[3].DataPropertyName = "materno";
                dgvInformacion.Columns[4].DataPropertyName = "correo";
                dgvInformacion.Columns[5].DataPropertyName = "telefono";
                dgvInformacion.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudo obtener la información de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         

                
        }
        private void frmInformacion_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void frmInformacion_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
