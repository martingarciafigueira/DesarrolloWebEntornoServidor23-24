using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    class Comercial : Empleado
    {
        //Atributos
        private double comision;

        //Constructores
        public Comercial(double comision, String nombre, int edad, double salario) : base(nombre, edad, salario)
        {
            this.comision = comision;
        }

        //Metodos
        public double getComision()
        {
            return comision;
        }

        public void setComision(double comision)
        {
            this.comision = comision;
        }

        /**
         * Devuelve el estado del objeto, llama primero al toString de la clase
         * padre
         *
         * @return
         */
        public new String toString()
        {
            return base.toString() + " comision=" + comision;
        }

        /**
         * Si tiene mas de 30 años y la comision es mayor que 200, aumentamos el
         * sueldo al empleado
         *
         * @return
         */
        public override bool plus()
        {

            if (base.getEdad() > 30 && this.comision > 200)
            {
                //Con super. llamo a un metodo de la clase padre
                double nuevoSalario = base.getSalario() + base.PLUS;
                base.setSalario(nuevoSalario);
                MessageBox.Show("Se le añadido el plus, al empleado " + base.getNombre());
                return true;
            }

            return false;

        }
    }
}
