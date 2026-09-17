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
    public partial class Form1 : Form
    {
        List<persona> personas = new List<persona>();
        public Form1()
        {
            InitializeComponent();
            personas.Add(new persona(1, "yamilet esmeralda", "87151087889"));
            personas.Add(new persona(2, "Galen Lorenzo", "87154622213"));
            personas.Add(new persona(3, "Nancy Judith", "85498745465"));
            personas.Add(new persona(4, "Demi Mendoza", "4851658465"));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvInformacion.Rows.Add();
            dgvInformacion[0, dgvInformacion.Rows.Count - 1].Value = dgvInformacion.Rows.Count;
            dgvInformacion[1, dgvInformacion.Rows.Count-1].Value = txtNombre.Text;
            dgvInformacion[2,dgvInformacion.Rows.Count-1].Value=mtbTelefono.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var personas in personas)
            {
                dgvInformacion.Rows.Add();
                dgvInformacion[0, dgvInformacion.Rows.Count - 1].Value = personas.Id;
                dgvInformacion[1, dgvInformacion.Rows.Count - 1].Value = personas.nombre;
                dgvInformacion[2, dgvInformacion.Rows.Count - 1].Value = personas.telefono;

            }
            //dgvInformacion.DataSource = personas;
        }
    }
}
