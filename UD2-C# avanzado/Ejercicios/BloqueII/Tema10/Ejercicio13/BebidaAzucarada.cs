using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class BebidaAzucarada : Bebida
    {
        private double porcentajeAzucar;
        private bool promocion;

        public BebidaAzucarada(double porcentajeAzucar, bool promocion, double cantidad, double precio, String marca) : base(cantidad, precio, marca)
        {
            this.porcentajeAzucar = porcentajeAzucar;
            this.promocion = promocion;
        }

        public double getPorcentajeAzucar()
        {
            return porcentajeAzucar;
        }

        public void setPorcentajeAzucar(double porcentajeAzucar)
        {
            this.porcentajeAzucar = porcentajeAzucar;
        }

        public bool isPromocion()
        {
            return promocion;
        }

        public void setPromocion(bool promocion)
        {
            this.promocion = promocion;
        }

        public new double getPrecio()
        {
            if (isPromocion())
            {
                return base.getPrecio() * 0.9;
            }
            else
            {
                return base.getPrecio();
            }
        }
        public new String toString()
        {
            return base.toString() + "porcentajeAzucar=" + porcentajeAzucar + ", promocion=" + promocion;
        }
    }
}
