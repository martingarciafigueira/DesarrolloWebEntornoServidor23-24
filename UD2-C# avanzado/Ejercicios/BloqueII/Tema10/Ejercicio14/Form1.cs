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
        Agenda agenda = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre;
            int telefono;
            Contacto c;

            nombre = textBox1.Text;
            int.TryParse(textBox2.Text, out telefono);
            //Creo el contacto
            c = new Contacto(nombre, telefono);
            agenda.aniadirContacto(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agenda.listarContactos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombre;
            nombre = textBox1.Text;

            agenda.buscarPorNombre(nombre);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String nombre;
            nombre = textBox1.Text;

            //Creo el contacto auxiliar
            Contacto c = new Contacto(nombre, 0);

            if (agenda.existeContacto(c))
            {
                MessageBox.Show("Existe contacto");
            }
            else
            {
                MessageBox.Show("No existe contacto");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String nombre;
            nombre = textBox1.Text;
            //Creo el contacto auxiliar
            Contacto c = new Contacto(nombre, 0);
            agenda.eliminarContacto(c);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay " + agenda.huecosLibre() + " contactos libre");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (agenda.agendaLlena())
            {
                MessageBox.Show("La agenda esta llena");
            }
            else
            {
                MessageBox.Show("Aun puedes meter contactoss");
            }
        }
    }
}
