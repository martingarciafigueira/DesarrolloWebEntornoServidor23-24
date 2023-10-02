using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    abstract class Persona
    {
        /*Atributos*/
        private String nombre;
        private char sexo;
        private int edad;
        private bool asistencia;

        /*Contantes*/
        private readonly string[] NOMBRES_CHICOS = { "Pepe", "Fernando", "Alberto", "Nacho", "Eustaquio" };
        private readonly string[] NOMBRES_CHICAS = { "Alicia", "Laura", "Clotilde", "Pepa", "Elena" };
        private readonly int CHICO = 0;
        private readonly int CHICA = 1;

        /*Constructores*/
        public Persona()
        {

            //entre 0 y 1
            int determinar_sexo = MetodosSueltos.generaNumeroAleatorio(0, 1);

            //Si es 0 es un chico
            if (determinar_sexo == CHICO)
            {
                nombre = NOMBRES_CHICOS[MetodosSueltos.generaNumeroAleatorio(0, 4)];
                sexo = 'H';
            }
            else
            {
                nombre = NOMBRES_CHICAS[MetodosSueltos.generaNumeroAleatorio(0, 4)];
                sexo = 'M';
            }

            //Indicamos la disponibilidad
            disponibilidad();

        }

        /*Metodos*/

        /**
         * Devuelve el nombre
         * @return 
         */
        public String getNombre()
        {
            return nombre;
        }

        /**
         * Modifica el nombre
         * @param nombre 
         */
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        /**
         * Devuelve el sexo de la persona
         * @return 
         */
        public char getSexo()
        {
            return sexo;
        }

        /**
         * Modifica el sexo de la persona
         * @param sexo 
         */
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        /**
         * Devuelve la edad de la persona
         * @return 
         */
        public int getEdad()
        {
            return edad;
        }

        /**
         * Modifica la edad de la edad
         * @param edad 
         */
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        /**
         * Indica la asistencia de la persona
         * @return 
         */
        public bool isAsistencia()
        {
            return asistencia;
        }

        /**
         * Modifica la asistencia de la persona
         * @param asistencia 
         */
        public void setAsistencia(bool asistencia)
        {
            this.asistencia = asistencia;
        }

        //abtracto, las clases hijas deben implementarlo
        public abstract void disponibilidad();

        public override string ToString()
        {
            return this.getNombre();
        }
    }
}
