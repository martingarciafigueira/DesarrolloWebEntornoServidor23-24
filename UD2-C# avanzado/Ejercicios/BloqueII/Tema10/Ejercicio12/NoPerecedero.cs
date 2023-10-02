using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class NoPerecedero : Producto
    {
        //Atributos
        private String tipo;

        //constructores
        public NoPerecedero(String tipo, String nombre, double precio) : base(nombre, precio)
        {
            this.tipo = tipo;
        }

        //Metodos
        public String getTipo()
        {
            return tipo;
        }

        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }
        public new String toString()
        {
            return base.toString() + " tipo=" + tipo + '}';
        }

    }
}
