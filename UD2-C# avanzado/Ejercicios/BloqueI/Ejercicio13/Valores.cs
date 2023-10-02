using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    class Valores
    {
        int valor;
        int menorValor;
        int mayorValor;
        public int Valor { get => valor; set => valor = value; }
        public int MenorValor { get => menorValor; set => menorValor = value; }
        public int MayorValor { get => mayorValor; set => mayorValor = value; }

        public void NuevoValor(int valor)
        {
            this.valor = valor;
        }

        public void Comparar()
        {
            MessageBox.Show("El valor mínimo es: " + menorValor + " , el valor máximo es: " + mayorValor + " y el valor actual es: " + valor);
        }

        public void Comparar(Valores valor2)
        {
            MessageBox.Show("El valor1 es: " + this.valor + " , el valor2 es: " + valor2.valor);
        }

    }
}
