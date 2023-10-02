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
        BindingList<Libro> listaLibros = new BindingList<Libro>();
        public Form1()
        {
            InitializeComponent();
            lstLibros.DataSource = listaLibros;
        }

        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            int ISBN;
            string titulo;
            string autor;
            int numPaginas;

            int.TryParse(txtISBN.Text, out ISBN);
            titulo = txtTitulo.Text;
            autor = txtAutor.Text;
            int.TryParse(txtNumPaginas.Text, out numPaginas);

            Libro libro = new Libro(ISBN, titulo, autor, numPaginas);
            listaLibros.Add(libro);
        }

        private void lstLibros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indiceSeleccionado = lstLibros.SelectedIndex;
            MessageBox.Show(listaLibros[indiceSeleccionado].toString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libro libroConMasPaginas = null;
            foreach (Libro libro in listaLibros)
            {
                if (libroConMasPaginas == null) libroConMasPaginas = libro;
                if (libroConMasPaginas.compareTo(libro) == 1)
                {
                    libroConMasPaginas = libro;
                }
            }
            MessageBox.Show(libroConMasPaginas.toString());
        }
    }
}
