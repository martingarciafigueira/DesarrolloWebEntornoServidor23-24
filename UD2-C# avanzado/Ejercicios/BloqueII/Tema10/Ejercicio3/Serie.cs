using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Serie : IEntregable
    {
        //Constantes

        /**
         * Numero de temporadas por defecto
         */
        private readonly static int NUM_TEMPORADAS_DEF = 3;

        /**
         * Constante que indica que un objeto es mayor que otro
         */
        public readonly static int MAYOR = 1;

        /**
         * Constante que indica que un objeto es menor que otro
         */
        public readonly static int MENOR = -1;

        /**
         * Constante que indica que un objeto es igual que otro
         */
        public readonly static int IGUAL = 0;

        //Atributos

        /**
         * Titulo de la serie
         */
        private String titulo;

        /**
         * Numero de temporadas de la serie
         */
        private int numeroTemporadas;

        /**
         * Indica si esta entregado la serie
         */
        private bool entregado;

        /**
         * Genero de la serie
         */
        private String genero;

        /**
         * Creador de la serie
         */
        private String creador;

        //Métodos publicos

        /**
         * Devuelve el titulo de la serie
         * @return titulo de la serie
         */
        public String getTitulo()
        {
            return titulo;
        }

        /**
         * Modifica el titulo de la serie
         * @param titulo a cambiar
         */
        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        /**
         * Devuelve la numeroTemporadas de la serie
         * @return numeroTemporadas de la serie
         */
        public int getnumeroTemporadas()
        {
            return numeroTemporadas;
        }

        /**
         * Modifica la numeroTemporadas de la serie
         * @param numeroTemporadas a cambiar
         */
        public void setnumeroTemporadas(int numeroTemporadas)
        {
            this.numeroTemporadas = numeroTemporadas;
        }

        /**
         * Devuelve el genero de la serie
         * @return genero de la serie
         */
        public String getGenero()
        {
            return genero;
        }

        /**
         * Modifica el genero de la serie
         * @param genero a cambiar
         */
        public void setGenero(String genero)
        {
            this.genero = genero;
        }

        /**
         * Devuelve el creador de la serie
         * @return creador de la serie
         */
        public String getcreador()
        {
            return creador;
        }

        /**
         * Modifica el creador de la serie
         * @param creador a cambiar
         */
        public void setcreador(String creador)
        {
            this.creador = creador;
        }

        /**
         * Cambia el estado de entregado a true
         */
        public void entregar()
        {
            entregado = true;
        }

        /**
         * Cambia el estado de entregado a false
         */
        public void devolver()
        {
            entregado = false;
        }

        /**
         * Indica el estado de entregado
         */
        public bool isEntregado()
        {
            if (entregado)
            {
                return true;
            }
            return false;
        }

        /**
         * Compara dos series segun su numero de temporadas
         * @param objeto a comparar
         * @return codigo numerico
         * <ul>
         * <li>1: La Serie 1 es mayor que la Serie 2</li>
         * <li>0: Las Series son iguales</li>
         * <li>-1: La Serie 1 es menor que la Serie 2</li></ul>
         */
        public int compareTo(Object a)
        {
            int estado = MENOR;

            //Hacemos un casting de objetos para usar el metodo get
            Serie objetoRecibido = (Serie)a;
            if (numeroTemporadas > objetoRecibido.getnumeroTemporadas())
            {
                estado = MAYOR;
            }
            else if (numeroTemporadas == objetoRecibido.getnumeroTemporadas())
            {
                estado = IGUAL;
            }

            return estado;
        }

        /**
         * Muestra informacion de la Serie
         * @return cadena con toda la informacion de la Serie
         */
        public String toString()
        {
            return "Informacion de la Serie: \n" +
                    "\tTitulo: " + titulo + "\n" +
                    "\tNumero de temporadas: " + numeroTemporadas + "\n" +
                    "\tGenero: " + genero + "\n" +
                    "\tCreador: " + creador;
        }

        /**
         * Indica si dos Series son iguales, siendo el titulo y creador iguales
         * @param a Serie a comparar
         * @return true si son iguales y false si son distintos
         */
        public bool equals(Serie a)
        {
            if (titulo.Equals(a.getTitulo()) && creador.Equals(a.getcreador()))
            {
                return true;
            }
            return false;
        }

        //Constructor

        /**
         * Constructor por defecto
         */
        public Serie() : this("", NUM_TEMPORADAS_DEF, "", "")
        {
        }

        /**
         * Contructor con 2 parametros
         * @param titulo de la Serie
         * @param creador de la Serie
         */
        public Serie(String titulo, String creador) : this(titulo, NUM_TEMPORADAS_DEF, "", creador)
        {
        }

        /**
         * Constructor con 4 parametros
         * @param titulo de la Serie
         * @param numeroTemporadas de la Serie
         * @param genero de la Serie
         * @param creador de la Serie
         */
        public Serie(String titulo, int numeroTemporadas, String genero, String creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            this.genero = genero;
            this.creador = creador;
            this.entregado = false;
        }
        public override string ToString()
        {
            return this.titulo;
        }

    }
}
