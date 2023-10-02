using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class AguaMineral : Bebida
    {
        //Atributos
        private String manantial;

        //Constructores
        public AguaMineral(String manantial, double cantidad, double precio, String marca) : base(cantidad, precio, marca)
        {
            this.manantial = manantial;
        }

        //Metodos
        public String getManatial()
        {
            return manantial;
        }

        public void setManatial(String manatial)
        {
            this.manantial = manatial;
        }

        public new String toString()
        {
            return base.toString() + "manatial=" + manantial;
        }

    }
}
