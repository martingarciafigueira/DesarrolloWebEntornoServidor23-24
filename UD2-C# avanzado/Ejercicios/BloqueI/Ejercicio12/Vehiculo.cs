using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
    class Vehiculo
    {
        string tipo;
        string fabricante;
        int n_Ruedas;
        int pasajeros;
        public static double precioGasolina;
        private static double consumo;
        public string Tipo { get => tipo; set => tipo = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public int N_Ruedas { get => n_Ruedas; set => n_Ruedas = value; }
        public int Pasajeros { get => pasajeros; set => pasajeros = value; }
        public static double PrecioGasolina { get => precioGasolina; set => precioGasolina = value; }
        public static double Consumo { get => consumo; set => consumo = value; }
        public static double PrecioPorKm()
        {
            return (consumo * precioGasolina) / 100;
        }
    }
}
