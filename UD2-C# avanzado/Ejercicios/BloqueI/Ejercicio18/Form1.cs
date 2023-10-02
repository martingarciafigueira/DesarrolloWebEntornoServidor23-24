using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double real1, real2, imaginaria1, imaginaria2;

            double.TryParse(textBox1.Text, out real1);
            double.TryParse(textBox2.Text, out imaginaria1);
            double.TryParse(textBox3.Text, out real2);
            double.TryParse(textBox4.Text, out imaginaria2);

            Complejo numero1 = new Complejo(real1, imaginaria1);
            Complejo numero2 = new Complejo(real2, imaginaria2);

            Complejo sumado = numero1.Suma(numero2);

            MessageBox.Show("La parte real de la suma es: " + sumado.ParteReal);
            MessageBox.Show("La parte imaginaria de la suma es: " + sumado.ParteImaginaria);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double real1, real2, imaginaria1, imaginaria2;

            double.TryParse(textBox1.Text, out real1);
            double.TryParse(textBox2.Text, out imaginaria1);
            double.TryParse(textBox3.Text, out real2);
            double.TryParse(textBox4.Text, out imaginaria2);

            Complejo numero1 = new Complejo(real1, imaginaria1);
            Complejo numero2 = new Complejo(real2, imaginaria2);

            Complejo producto = numero1.Producto(numero2);

            MessageBox.Show("La parte real del producto es: " + producto.ParteReal);
            MessageBox.Show("La parte imaginaria del producto es: " + producto.ParteImaginaria);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
