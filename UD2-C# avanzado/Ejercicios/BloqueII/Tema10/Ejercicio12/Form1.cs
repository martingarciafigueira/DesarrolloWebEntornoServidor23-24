using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        BindingList<Producto> listaProductos = new BindingList<Producto>();
        public Form1()
        {
            InitializeComponent();
            lstProductos.DataSource = listaProductos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            double precio;
            int diasACaducar;
            string tipo;
            string tipoProducto;
            Producto producto;

            tipoProducto = comboBox1.Text;
            nombre = textBox1.Text;
            double.TryParse(textBox2.Text, out precio);
            int.TryParse(textBox3.Text, out diasACaducar);
            tipo = textBox4.Text;

            if (tipoProducto == "PRODUCTO")
            {
                producto = new Producto(nombre, precio);
            }
            else if (tipoProducto == "PERECEDERO")
            {
                producto = new Perecedero(diasACaducar, nombre, precio);
            }
            else
            {
                producto = new NoPerecedero(tipo, nombre, precio);
            }
            listaProductos.Add(producto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad;
            Producto producto = (Producto)lstProductos.SelectedItem;
            int.TryParse(textBox5.Text, out cantidad);
            MessageBox.Show("Precio final: " + producto.calcular(cantidad));
        }
    }
}
