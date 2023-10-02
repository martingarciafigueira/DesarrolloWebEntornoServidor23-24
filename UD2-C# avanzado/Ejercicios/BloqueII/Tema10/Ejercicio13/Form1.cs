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
        Almacen a = new Almacen();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bebida b;
            int id;
            double cantidad;
            double precio;
            String marca;
            string manantial;
            double porcentajeAzucar;
            bool enPromocion = false;
            string tipoProducto = comboBox1.Text;

            int.TryParse(textBox1.Text, out id);
            double.TryParse(textBox2.Text, out cantidad);
            double.TryParse(textBox3.Text, out precio);
            marca = textBox4.Text;
            manantial = textBox5.Text;
            double.TryParse(textBox6.Text, out porcentajeAzucar);
            enPromocion = checkBox1.Checked;

            if (tipoProducto == "AGUA MINERAL")
            {
                b = new AguaMineral(manantial, cantidad, precio, marca);
            }
            else if (tipoProducto == "BEBIDA AZUCARADA")
            {
                b = new BebidaAzucarada(porcentajeAzucar, enPromocion, cantidad, precio, marca);
            }
            else
            {
                b = new Bebida(cantidad, precio, marca);
            }
            a.agregarBebida(b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idSeleccionado;
            int.TryParse(textBox7.Text, out idSeleccionado);
            a.eliminarBebida(idSeleccionado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Precio de todas las bebidas" + a.calcularPrecioBebidas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.mostrarBebidas();
        }
    }
}
