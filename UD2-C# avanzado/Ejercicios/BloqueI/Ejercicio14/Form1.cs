using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        Cuenta cuenta;
        public Form1()
        {
            InitializeComponent();
            cuenta = new Cuenta(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ingreso = 0;
            double.TryParse(textBox1.Text, out ingreso);
            cuenta.Depositar(ingreso);
            textBox2.Text = cuenta.SaldoActual.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double retirada = 0;
            double.TryParse(textBox1.Text, out retirada);
            cuenta.Retirar(retirada);
            textBox2.Text = cuenta.SaldoActual.ToString();
        }
    }
}
