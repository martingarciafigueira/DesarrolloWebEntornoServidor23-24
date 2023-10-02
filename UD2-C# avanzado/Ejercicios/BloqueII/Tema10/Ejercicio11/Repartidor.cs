using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    class Repartidor : Empleado
    {
        //Atributos
        private String zona;

        //Constructores
        public Repartidor(String zona, String nombre, int edad, double salario) : base(nombre, edad, salario)
        {
            this.zona = zona;
        }

        //Metodos
        public String getZona()
        {
            return zona;
        }

        public void setZona(String zona)
        {
            this.zona = zona;
        }

    public new String toString()
        {
            return base.toString() + " zona=" + zona;
        }

        /**
         * Si tiene menos de 25 años y la zona es "zona 3",
         * aumentamos el sueldo al empleado
         * @return 
         */
    public override bool plus()
        {

            if (base.getEdad() < 25 && this.zona.Equals("zona 3"))
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
