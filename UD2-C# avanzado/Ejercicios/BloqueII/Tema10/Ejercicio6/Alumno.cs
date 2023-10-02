using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Alumno : Persona
    {

        /*Atributos*/
        private int nota;

        /*Constructor*/
        public Alumno() : base()
        {
            nota = MetodosSueltos.generaNumeroAleatorio(0, 10);

            base.setEdad(MetodosSueltos.generaNumeroAleatorio(12, 15));

        }

        /*Metodos*/

        /**
         * Devuelve la nota
         * @return nota del alumno
         */

        public int getNota()
        {
            return nota;
        }

        /**
         * Modifica la nota del alumno
         * @param nota 
         */
        public void setNota(int nota)
        {
            this.nota = nota;
        }

        /**
         * Indica si el alumno esta disponible (50%)
         */
        
    public override void disponibilidad()
        {

            int prob = MetodosSueltos.generaNumeroAleatorio(0, 100);

            if (prob < 50)
            {
                base.setAsistencia(false);
            }
            else
            {
                base.setAsistencia(true);
            }

        }

        /**
         * Muestra la informacion del alumno
         * @return informacion
         */
        public String toString()
        {

            return "Nombre: " + base.getNombre() + " ,sexo: " + base.getSexo() + " , nota: " + nota;

        }
    }
}
