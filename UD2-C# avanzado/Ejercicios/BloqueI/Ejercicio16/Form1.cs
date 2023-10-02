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
        Dado miDado;
        public Form1()
        {
            InitializeComponent();
            miDado = new Dado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Versión 1
            /* Dado midado = new Dado(6);
            MessageBox.Show("El valor del dado es: " + midado.Valor);*/

            //Versión 2
            /*miDado.incrementar();
            MessageBox.Show("El valor del dado es: " + miDado.Valor);*/

            //Versión 3
            miDado.valorNuevo();
            MessageBox.Show("El valor del dado es: " + miDado.Valor);
        }
    }
}
