using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        BindingList<Serie> listaSeries = new BindingList<Serie>();
        BindingList<Videojuego> listaVideojuegos = new BindingList<Videojuego>();
        public Form1()
        {
            InitializeComponent();
            lstSeries.DataSource = listaSeries;
            lstVideojuegos.DataSource = listaVideojuegos;
        }

        private void btnCrearSerie_Click(object sender, EventArgs e)
        {
            string titulo, genero, creador;
            int numeroTemporadas;

            titulo = txtTitulo.Text;
            int.TryParse(txtNumTemporadas.Text, out numeroTemporadas);
            genero = txtGenero.Text;
            creador = txtCreador.Text;

            Serie serie = new Serie(titulo, numeroTemporadas, genero, creador);
            listaSeries.Add(serie);
        }

        private void btnCrearVideojuego_Click(object sender, EventArgs e)
        {
            string titulo, genero, compañia;
            int horasEstimadas;

            titulo = txtTitulo2.Text;
            int.TryParse(txtHorasEstimadas.Text, out horasEstimadas);
            genero = txtGenero2.Text;
            compañia = txtCompañia.Text;

            Videojuego videojuego = new Videojuego(titulo, horasEstimadas, genero, compañia);
            listaVideojuegos.Add(videojuego);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstSeries.SelectedItem != null)
            {
                Serie objeto = (Serie)lstSeries.SelectedItem;
                objeto.entregar();
                MessageBox.Show("Serie entregada");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstVideojuegos.SelectedItem != null)
            {
                Videojuego objeto = (Videojuego)lstVideojuegos.SelectedItem;
                objeto.entregar();
                MessageBox.Show("Videojuego entregado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int seriesEntregadas = 0, videojuegosEntregados = 0;

            foreach (Serie item in listaSeries)
            {
                if (item.isEntregado())
                {
                    seriesEntregadas++;
                }
            }
            foreach (Videojuego item in listaVideojuegos)
            {
                if (item.isEntregado())
                {
                    videojuegosEntregados++;
                }
            }
            MessageBox.Show("Hay " + seriesEntregadas +" series entregadas");
            MessageBox.Show("Hay " + videojuegosEntregados + " videojuegos entregados");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Videojuego juegoConMasHoras = new Videojuego("", 0, "", "");
            Serie serieConMasTemporadas = new Serie("", 0, "", "");

            foreach (Serie item in listaSeries)
            {
                if (item.compareTo(serieConMasTemporadas) == 1)
                {
                    serieConMasTemporadas = item;
                }
            }
            foreach (Videojuego item in listaVideojuegos)
            {
                if (item.compareTo(juegoConMasHoras) == 1)
                {
                    juegoConMasHoras = item;
                }
            }
            MessageBox.Show(serieConMasTemporadas.toString());
            MessageBox.Show(juegoConMasHoras.toString());
        }
    }
}
