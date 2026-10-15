using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="" || txtEdad.Text== "")
            {
                MessageBox.Show("completa todos los campos.");
                return;
            }
            int edad;
            if (!int.TryParse(txtEdad.Text, out edad))
            {
                MessageBox.Show("ingresa una edad válida.");
                return;
            }

            String intereses = "";
            if(cbDeporte.Checked)
            {
                intereses += "Deporte, ";
            }
            if (cbMusica.Checked)
            {
                intereses += "Música, ";
            }                   
            if(cbLectura.Checked)
            {
                intereses += "Lectura, ";
            }
            
           
            String genero = "";
            if(rdbMasc.Checked)
            {
                genero = "Masculino";
            }
            else if (rdbFem.Checked)
            {
                genero = "Femenino";
            }
            else if (rdbOtro.Checked)
            {
                genero = "Otro";
            }
            lblResumen.Text = "Nombre: " + txtNombre.Text + " Edad: " + edad + " Intereses: " + intereses + " Género: " + genero;
        }
    }
}
