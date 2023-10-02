using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porra_2
{
    class Equipo
    {
        private string nombre;
        private int division;

        public Equipo(string nombre, int division)
        {
            this.Nombre = nombre;
            this.Division = division;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Division { get => division; set => division = value; }
    }
}
