using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Profesor : Persona
    {
        /*Atributos*/
        private String materia;

        /*Constructores*/
        public Profesor() : base()
        {
            base.setEdad(MetodosSueltos.generaNumeroAleatorio(25, 50)); //llama al metodo padre

            materia = Constantes.ASIGNATURAS[MetodosSueltos.generaNumeroAleatorio(0, 2)];
        }

        /*Metodos*/

        /**
         * Devuelve la materia del profesor
         * @return 
         */
        public String getMateria()
        {
            return materia;
        }

        /**
         * Modifica la materia del profesor
         * @param materia 
         */
        public void setMateria(String materia)
        {
            this.materia = materia;
        }

        /**
         * Calcula la disponibilidad del profesor(20%)
         */
        public override void disponibilidad()
        {

            int prob = MetodosSueltos.generaNumeroAleatorio(0, 100);

            if (prob < 20)
            {
                base.setAsistencia(false);
            }
            else
            {
                base.setAsistencia(true);
            }

        }
    }
}
