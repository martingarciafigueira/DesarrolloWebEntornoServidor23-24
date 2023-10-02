using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Producto
    {

        //Atributos
        private String nombre;
        private double precio;

        //Constructores
        public Producto(String nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        //Metodos
        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
        public String toString()
        {
            return "nombre=" + nombre + ", precio=" + precio + ", ";
        }

        /**
         * Indica el precio total segun una cantidad
         * @param cantidad
         * @return 
         */
        public double calcular(int cantidad)
        {
            return precio * cantidad;
        }

        public override string ToString()
        {
            return this.nombre;
        }


    }
}
