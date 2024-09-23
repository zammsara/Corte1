using Corte1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corte1.Clases;


namespace Corte1
{
    public partial class Form1 : Form
    {
        // Instancia de la clase Registro
        private Registro registro = new Registro();
        private Operacion operacion = new Operacion();

        public Form1()
        {
            InitializeComponent();
            // Agregar ciudades al ComboBox
            cbCiudad.Items.Add("Managua");
            cbCiudad.Items.Add("Matagalpa");
            cbCiudad.Items.Add("Leon");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         

        }

        private void dtbFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
