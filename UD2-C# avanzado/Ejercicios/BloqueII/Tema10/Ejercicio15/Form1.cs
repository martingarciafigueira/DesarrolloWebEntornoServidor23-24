using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        Baraja barajaES = new BarajaEspanhola(true);
        Baraja barajaFRA = new BarajaFrancesa();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barajaES.barajar();
            barajaFRA.barajar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(barajaES.siguienteCarta().toString());
            MessageBox.Show(barajaFRA.siguienteCarta().toString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay " + barajaES.cartasDisponible() + " cartas disponibles");
            MessageBox.Show("Hay " + barajaFRA.cartasDisponible() + " cartas disponibles");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numCartas;
            Carta<T>[] listaCartas;

            int.TryParse(textBox1.Text, out numCartas);
            listaCartas = barajaES.darCartas(numCartas);

            foreach (Carta<T> carta in listaCartas)
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
