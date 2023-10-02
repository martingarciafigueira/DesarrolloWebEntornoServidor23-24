using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Complejo
    {
        double parteReal;
        double parteImaginaria;

        public Complejo() { }

        public Complejo(double parteReal, double parteImaginaria)
        {
            this.ParteReal = parteReal;
            this.ParteImaginaria = parteImaginaria;
        }

        public double ParteReal { get => parteReal; set => parteReal = value; }
        public double ParteImaginaria { get => parteImaginaria; set => parteImaginaria = value; }

        public Complejo Suma(Complejo numero)
        {
            Complejo numeroSumado = new Complejo();

            numeroSumado.parteReal = this.parteReal + numero.parteReal;
            numeroSumado.parteImaginaria = this.parteImaginaria + numero.parteImaginaria;

            return numeroSumado;
        }

        public Complejo Producto(Complejo numero)
        {
            Complejo numeroMultiplicado = new Complejo();

            numeroMultiplicado.parteReal = this.parteReal * numero.parteReal + this.parteImaginaria * numero.parteImaginaria;
            numeroMultiplicado.parteImaginaria = this.parteReal * numero.parteImaginaria + this.parteImaginaria * numero.parteReal;

            return numeroMultiplicado;
        }
    }
}
