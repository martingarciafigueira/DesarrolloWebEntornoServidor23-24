using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorActual, valorMax, valorMin;

            valorActual = trackBar1.Value;
            int.TryParse(textBox1.Text, out valorMin);
            int.TryParse(textBox2.Text, out valorMax);

            Valores valor = new Valores();
            Valores valor2 = new Valores();

            valor.NuevoValor(valorActual);
            valor.MenorValor = valorMin;
            valor.MayorValor = valorMax;

            valor2.NuevoValor(valorActual * 2);

            valor.Comparar();
            valor.Comparar(valor2);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Minimum.ToString();
            textBox2.Text = trackBar1.Maximum.ToString();
        }
    }
}
