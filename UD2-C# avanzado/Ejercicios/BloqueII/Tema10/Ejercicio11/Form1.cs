using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        BindingList<Empleado> listaEmpleados = new BindingList<Empleado>();
        public Form1()
        {
            InitializeComponent();
            lstEmpleados.DataSource = listaEmpleados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;
            double salario;
            double comision;
            string zona;
            string tipo;
            Empleado empleado;

            nombre = textBox1.Text;
            int.TryParse(textBox2.Text, out edad);
            double.TryParse(textBox3.Text, out salario);
            double.TryParse(textBox4.Text, out comision);
            zona = textBox5.Text;
            tipo = comboBox1.Text;

            if (tipo == "COMERCIAL")
            {
                empleado = new Comercial(comision, nombre, edad, salario);
            }
            else
            {
                empleado = new Repartidor(zona, nombre, edad, salario);
            }

            //Llamamos a plus
            empleado.plus();

            //Mostramos la informacion
            MessageBox.Show(empleado.toString());

            listaEmpleados.Add(empleado);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = (Empleado)lstEmpleados.SelectedItem;
            empleado.plus();
        }
    }
}
