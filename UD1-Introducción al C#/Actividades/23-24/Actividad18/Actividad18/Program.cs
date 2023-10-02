using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string claveSegurisima;

			claveSegurisima = GeneradorPassSuperSeguras();

			Console.WriteLine("La clave generada es: " + claveSegurisima);
			Console.ReadKey();
		}

		private static string GetClave(string tipoClave, int cantidad)
		{
			string clave = string.Empty;
			Random rand = new Random();

			switch (tipoClave)
			{
				case "LETRA MAYUSCULA":
					{
						for (int i = 0; i < cantidad; i++)
						{
							clave += ((char)rand.Next('A', 'Z' + 1)).ToString();
						}
						break;
					}
				case "DIGITO":
					{
						for (int i = 0; i < cantidad; i++)
						{
							clave += rand.Next(1, 9 + 1).ToString();
						}
						break;
					}
				case "SIMBOLO":
					{
						for (int i = 0; i < cantidad; i++)
						{
							clave += ((char)rand.Next(33, 47 + 1)).ToString();
						}
						break;
					}
				case "LETRA MINUSCULA":
					{
						for (int i = 0; i < cantidad; i++)
						{
							clave += ((char)rand.Next('a', 'z' + 1)).ToString();
						}
						break;
					}

				default:
					break;
			}

			return clave;
		}

		public static string GeneradorPassSuperSeguras()
		{
			string claveSegura = string.Empty;
			int numeroDigitos;

			Random random = new Random();

			numeroDigitos = random.Next(6, 8 + 1);

			claveSegura += GetClave("LETRA MAYUSCULA", 1);
			claveSegura += GetClave("DIGITO", numeroDigitos);
			claveSegura += GetClave("SIMBOLO", 1);
			claveSegura += GetClave("LETRA MINUSCULA", 2);

			return claveSegura;
		}
	}
}
