using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        Baraja baraja = new Baraja();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baraja.barajar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.siguienteCarta().toString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay " + baraja.cartasDisponible() + " cartas disponibles");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numCartas;
            Carta[] listaCartas;

            int.TryParse(textBox1.Text, out numCartas);
            listaCartas = baraja.darCartas(numCartas);

            foreach (Carta carta in listaCartas)
            {
                MessageBox.Show(carta.toString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baraja.cartasMonton();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baraja.mostrarBaraja();
        }
    }
}
