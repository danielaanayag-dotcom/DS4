using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblVelocidad_Click(object sender, EventArgs e)
        {

        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {
   
        }

        private void lblDistanciaTotal_Click(object sender, EventArgs e)
        {
         }

        private void DistanciaRecorrida_Click(object sender, EventArgs e)
        {
       
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double velocidad, tiempo;

            velocidad = double.Parse(textBox1.Text);
            tiempo = double.Parse(textBox2.Text);

            double distancia = velocidad * tiempo;
            textBox3.Text = distancia.ToString("F1") + "km";


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
