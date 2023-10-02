using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int altura, ancho;

            int.TryParse(txtAltura.Text, out altura);
            int.TryParse(txtAncho.Text, out ancho);

            Cuadrado cuadrado = new Cuadrado(altura, ancho);

            MessageBox.Show("El área del cuadrado es: " + cuadrado.Area());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int altura, ancho, profundidad;

            int.TryParse(txtAltura.Text, out altura);
            int.TryParse(txtAncho.Text, out ancho);
            int.TryParse(txtProfundidad.Text, out profundidad);

            Caja caja = new Caja(altura, ancho, profundidad);

            MessageBox.Show("El volumen de la caja es: " + caja.Volumen());
        }
    }
}
