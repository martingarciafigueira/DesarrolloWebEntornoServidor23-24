using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Contacto
    {
        private String nombre;
        private int telefono;

        public Contacto(String nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public Contacto(String nombre)
        {
            this.nombre = nombre;
            this.telefono = 0;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public int getTelefono()
        {
            return telefono;
        }

        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public bool equals(Contacto c)
        {

            if (this.nombre.Trim().Equals(c.getNombre().Trim()))
            {
                return true;
            }

            return false;

        }
        public String toString()
        {
            return "nombre=" + nombre + ", telefono=" + telefono;
        }

    }
}
