using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    class Aula
    {
        /*Atributos*/
        private int id;
        private Profesor profesor;
        private Alumno[] alumnos;
        private String asignatura;

        /*Constantes*/
        private readonly int MAX_ALUMNOS = 20;

        /*Constructores*/
        public Aula()
        {

            id = 1;

            profesor = new Profesor();
            alumnos = new Alumno[MAX_ALUMNOS];
            creaAlumnos();
            asignatura = Constantes.ASIGNATURAS[MetodosSueltos.generaNumeroAleatorio(0, 2)];

        }

        /*Metodos*/

        /**
         * Crea los alumnos para el aula
         */
        private void creaAlumnos()
        {

            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i] = new Alumno();
            }

        }


        /**
         * Indica si la asistencia de los alumnos es mayor del 50%
         * @return 
         */
        private bool asistenciaAlumnos()
        {

            int cuentaAsistencias = 0;

            //contamos las asistencias
            for (int i = 0; i < alumnos.Length; i++)
            {

                if (alumnos[i].isAsistencia())
                {
                    cuentaAsistencias++;
                }

            }

            //Muestro la asistencia total
            MessageBox.Show("Hay " + cuentaAsistencias + " alumnos");

            return cuentaAsistencias >= ((int)(alumnos.Length / 2));

        }

        /**
         * Indicamos si se puede dar clase
         * @return 
         */
        public bool darClase()
        {

            //Indicamos las condiciones para que se pueda dar la clase

            if (!profesor.isAsistencia())
            {
                MessageBox.Show("El profesor no esta, no se puede dar clase");
                return false;
            }
            else if (!profesor.getMateria().Equals(asignatura))
            {
                MessageBox.Show("La materia del profesor y del aula no es la misma, no se puede dar clase");
                return false;
            }
            else if (!asistenciaAlumnos())
            {
                MessageBox.Show("La asistencia no es suficiente, no se puede dar clase");
                return false;
            }

            MessageBox.Show("Se puede dar clase");
            return true;

        }

        /**
         * Indicamos las notas de los alumnos aprobados, chicos y chicas
         */
        public void notas()
        {

            int chicosApro = 0;
            int chicasApro = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {

                //Comprobamos si el alumno esta aprobado
                if (alumnos[i].getNota() >= 5)
                {
                    //Segun el sexo, aumentara uno o otro
                    if (alumnos[i].getSexo() == 'H')
                    {
                        chicosApro++;
                    }
                    else
                    {
                        chicasApro++;
                    }

                    MessageBox.Show(alumnos[i].toString());

                }

            }

            MessageBox.Show("Hay " + chicosApro + " chicos y " + chicasApro + " chicas aprobados/as");

        }
    }
}
