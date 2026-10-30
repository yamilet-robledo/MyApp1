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
         Datos datos;
      
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
            DataSet ds = datos.informacion("select ID, nombre, paterno, materno, telefono, correo, Estados,Municipio * from Datos\r\nInner Join Estados  On Datos.IDEstado = Estados\r\nInner Join Municipio On Datos.IDMunicipio=Municipios.IDMunicipio");

            if(ds != null)
            {
                dgvInformacion.AutoGenerateColumns = false;

                
                dgvInformacion.Columns[0].DataPropertyName = "Id";
                dgvInformacion.Columns[1].DataPropertyName = "nombre";
                dgvInformacion.Columns[2].DataPropertyName = "paterno";
                dgvInformacion.Columns[3].DataPropertyName = "materno";
                dgvInformacion.Columns[4].DataPropertyName = "telefono";
                dgvInformacion.Columns[5].DataPropertyName = "correo";
                dgvInformacion.Columns[6].DataPropertyName = "Estados";
                dgvInformacion.Columns[7].DataPropertyName = "Municipio";

                dgvInformacion.DataSource = ds.Tables[0];
                //dgvInformacion.CurrentCell = null;
                //dgvInformacion.DataSource = null;
                //dgvInformacion.DataSource = ds.Tables[0];
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInformacion.SelectedRows.Count > 0)
            {
             
                DataGridViewRow fila = dgvInformacion.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells[0].Value);
                string nombre = fila.Cells[1].Value.ToString();
                string paterno = fila.Cells[2].Value.ToString();
                string materno = fila.Cells[3].Value.ToString();
                string telefono = fila.Cells[4].Value.ToString();
                string correo = fila.Cells[5].Value.ToString();
                frmAgregar modificarForm = new frmAgregar(id, nombre, paterno, materno, telefono, correo);
                modificarForm.Show();
                ActualizarGrid();
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInformacion.SelectedRows.Count > 0) { 

            int id = Convert.ToInt32(dgvInformacion.SelectedRows[0].Cells[0].Value);
            datos = new Datos();

            if (datos.ejecutar($"Delete from Datos where id = {id}"))
            {
                ActualizarGrid();
            }
          }           
        }

        private void dgvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              frmAgregar actualizar = new frmAgregar(dgvInformacion.Rows[e.RowIndex].Cells[0].Value.ToString(),

                dgvInformacion.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[2].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[3].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[4].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[5].Value.ToString(),  

                Convert.ToInt32(dgvInformacion.Rows[e.RowIndex].Cells[0].Value));
                actualizar.ShowDialog();
                ActualizarGrid();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvInformacion_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}

