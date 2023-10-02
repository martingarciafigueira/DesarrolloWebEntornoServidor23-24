using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            double.TryParse(textBox1.Text, out a);
            double.TryParse(textBox2.Text, out b);
            double.TryParse(textBox3.Text, out c);

            Raices raiz = new Raices(a, b, c);

            raiz.calcular();
        }
    }
}
