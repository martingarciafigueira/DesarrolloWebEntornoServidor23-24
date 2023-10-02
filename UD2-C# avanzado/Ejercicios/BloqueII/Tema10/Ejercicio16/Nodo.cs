using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Nodo<T>
    {
        //Atributos
        private T elemento;
        private Nodo<T> siguiente; //Apunta al siguiente nodo

        //Contructor
        public Nodo(T elemento, Nodo<T> siguiente)
        {
            this.elemento = elemento;
            this.siguiente = siguiente;
        }

        //Metodos
        public T getElemento()
        {
            return elemento;
        }

        public void setElemento(T elemento)
        {
            this.elemento = elemento;
        }

        public Nodo<T> getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(Nodo<T> siguiente)
        {
            this.siguiente = siguiente;
        }

        @Override
    public String toString()
        {
            return elemento + "\n";
        }

    }
}
