using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        BindingList<Electrodomestico> listaElectrodomesticos = new BindingList<Electrodomestico>();
        public Form1()
        {
            InitializeComponent();
            lstElectrodomesticos.DataSource = listaElectrodomesticos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precioBase;
            double peso;
            char consumoEnergetico;
            string color;
            int carga;

            double.TryParse(txtPrecioBase.Text, out precioBase);
            double.TryParse(txtPeso.Text, out peso);
            char.TryParse(txtConsumoEnergetico.Text, out consumoEnergetico);
            color = txtColor.Text;
            int.TryParse(txtCarga.Text, out carga);

            Lavadora lavadora = new Lavadora(precioBase, peso, consumoEnergetico, color, carga);

            listaElectrodomesticos.Add(lavadora);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precioBase;
            double peso;
            char consumoEnergetico;
            string color;
            int resolucion;
            bool sintonizadorTDT = false;

            double.TryParse(txtPrecioBase.Text, out precioBase);
            double.TryParse(txtPeso.Text, out peso);
            char.TryParse(txtConsumoEnergetico.Text, out consumoEnergetico);
            color = txtColor.Text;
            int.TryParse(txtResolucion.Text, out resolucion);

            if (cbTDT.Text == "Sí")
            {
                sintonizadorTDT = true;
            }

            Television television = new Television(precioBase, peso, consumoEnergetico, color, resolucion, sintonizadorTDT);

            listaElectrodomesticos.Add(television);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Electrodomestico objeto = (Electrodomestico)lstElectrodomesticos.SelectedItem;
            if (objeto is Lavadora)
            {
                Lavadora lavadora = (Lavadora)objeto;
                MessageBox.Show("El precio final de la lavadora es: " + lavadora.precioFinal());
            }
            else
            {
                Television television = (Television)objeto;
                MessageBox.Show("El precio final de la televisión es: " + television.precioFinal());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double precioTelevisiones = 0;
            double precioLavadoras = 0;

            foreach (Electrodomestico item in listaElectrodomesticos)
            {
                if (item is Lavadora)
                {
                    precioLavadoras += ((Lavadora)item).precioFinal();
                }
                else if (item is Television)
                {
                    precioTelevisiones += ((Television)item).precioFinal();
                }
            }
            MessageBox.Show("El precio de las lavadoras es: " + precioLavadoras);
            MessageBox.Show("El precio de las televisiones es: " + precioTelevisiones);
            MessageBox.Show("El precio total es: " + (precioLavadoras + precioTelevisiones));
        }
    }
}
