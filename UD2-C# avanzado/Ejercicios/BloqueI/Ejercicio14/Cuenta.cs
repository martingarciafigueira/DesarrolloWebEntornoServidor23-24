using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    class Cuenta
    {
        double saldoActual;

        public Cuenta(double saldoActual)
        {
            this.SaldoActual = saldoActual;
        }

        public double SaldoActual { get => saldoActual; set => saldoActual = value; }

        public void Depositar(double ingreso)
        {
            this.saldoActual += ingreso;
        }

        public void Retirar(double retirada)
        {
            this.saldoActual -= retirada;
            if (saldoActual < 0)
            {
                MessageBox.Show("La cuenta está en números rojos");
            }
        }

    }
}
