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
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.Show();
;        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            if(this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }
            Datos datos = new Datos();
            DataSet ds = datos.informacion("Select * from Datos");
            if(ds!=null)
            {
                dgvInformacion.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar la informacion","sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
