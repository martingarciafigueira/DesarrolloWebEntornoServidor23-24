using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        BindingList<Pelicula> listaPeliculas = new BindingList<Pelicula>();
        BindingList<Espectador> listaEspectadores = new BindingList<Espectador>();
        BindingList<Cine> listaCines = new BindingList<Cine>();
        public Form1()
        {
            InitializeComponent();
            lstPeliculas.DataSource = listaPeliculas;
            lstEspectadores.DataSource = listaEspectadores;
            lstCines.DataSource = listaCines;
            comboBox1.DataSource = listaPeliculas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String titulo;
            int duracion;
            int edadMinima;
            String director;

            titulo = textBox1.Text;
            int.TryParse(textBox2.Text, out duracion);
            int.TryParse(textBox3.Text, out edadMinima);
            director = textBox4.Text;

            Pelicula peli = new Pelicula(titulo, duracion, edadMinima, director);

            listaPeliculas.Add(peli);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombre;
            int edad;
            double dinero;

            nombre = textBox8.Text;
            int.TryParse(textBox7.Text, out edad);
            double.TryParse(textBox6.Text, out dinero);

            Espectador fulano = new Espectador(nombre, edad, dinero);

            listaEspectadores.Add(fulano);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int filas;
            int columnas;
            double precio;
            Pelicula peli;

            int.TryParse(textBox10.Text, out filas);
            int.TryParse(textBox9.Text, out columnas);
            double.TryParse(textBox5.Text, out precio);

            peli = (Pelicula)comboBox1.SelectedItem;

            Cine cine = new Cine(filas, columnas, precio, peli);

            listaCines.Add(cine);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Espectador espectador = (Espectador)lstEspectadores.SelectedItem;
            Cine cine = (Cine)lstCines.SelectedItem;

            if (cine.sePuedeSentar(espectador) && cine.haySitio())
            {
                for (int i = 0; i < cine.getFilas(); i++)
                {
                    if (!sentar(cine,espectador,i)) break;
                }
            }
            else
            {
                MessageBox.Show("No se puede sentar");
            }

        }

        private bool sentar(Cine cine, Espectador espectador, int fila)
        {
            for (int j = 0; j < cine.getColumnas(); j++)
            {
                char letra = (char)('A' + j);
                if (cine.haySitioButaca(fila, (char)('A' + j)))
                {
                    if (cine.sentar(fila, letra, espectador))
                    {
                        MessageBox.Show("Espectador " + espectador.getNombre() + " en asiento " + fila + letra);
                        return false;
                    }
                }
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cine cine = (Cine)lstCines.SelectedItem;
            cine.mostrar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Espectador espectador = (Espectador)lstEspectadores.SelectedItem;
            MessageBox.Show(espectador.toString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pelicula peli = (Pelicula)lstPeliculas.SelectedItem;
            MessageBox.Show(peli.toString());
        }
    }
}
