using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC, perimetro, semi;
            ladoA = double.Parse(textBox1.Text);
            ladoB = double.Parse(textBox2.Text);
            ladoC = double.Parse(textBox3.Text);    

            perimetro = ladoA + ladoB + ladoC;
            semi = perimetro / 2;

            textBox4.Text = semi.ToString("F1");

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double area, ladoA, ladoB;
            ladoA = double.Parse(textBox1.Text);
            ladoB = double.Parse(textBox2.Text);

            area = (ladoA * ladoB) / 2;
            textBox5.Text = area.ToString("F1");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
