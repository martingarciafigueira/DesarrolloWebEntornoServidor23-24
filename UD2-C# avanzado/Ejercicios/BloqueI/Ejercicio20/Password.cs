using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio21
{
    class Password
    {

        //Constantes

        /**
         * Longitud por defecto
         */
        private const int LONG_DEF = 8;

        //Atributos

        /**
         * Longitud de la contraseña
         */
        private int longitud;
        /**
         * caracteres de la contraseña
         */
        private String contraseña;

        //Metodos publicos

        /**
         * Devuelve la longitud
         * @return longitud de la contraseña
         */
        public int getLongitud()
        {
            return longitud;
        }

        /**
         * Modifica la longitud de la contraseña
         * @param longitud a cambiar
         */
        public void setLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        /**
         * Devuelve la contraseña
         * @return contraseña
         */
        public String getContraseña()
        {
            return contraseña;
        }

        /**
         * Genera una contraseña al azar con la longitud que este definida
         * @return contraseña
         */
        public String generaPassword()
        {
            String password = "";
            Random generadorAleatorio = new Random();
            for (int i = 0; i < longitud; i++)
            {
                //Generamos un numero aleatorio, segun este elige si añadir una minuscula, mayuscula o numero
                int eleccion = generadorAleatorio.Next() * 3 + 1;

                if (eleccion == 1)
                {
                    char minusculas = (char)(generadorAleatorio.Next() * (123 - 97) + 97);
                    password += minusculas;
                }
                else
                {
                    if (eleccion == 2)
                    {
                        char mayusculas = (char)(generadorAleatorio.Next() * (91 - 65) + 65);
                        password += mayusculas;
                    }
                    else
                    {
                        char numeros = (char)(generadorAleatorio.Next() * (58 - 48) + 48);
                        password += numeros;
                    }
                }
            }
            return password;
        }

        /**
         * Comprueba la fortaleza de la contraseña
         * @return
         */
        public bool esFuerte()
        {
            int cuentanumeros = 0;
            int cuentaminusculas = 0;
            int cuentamayusculas = 0;
            //Vamos caracter a caracter y comprobamos que tipo de caracter es
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (contraseña[i] >= 97 && contraseña[i] <= 122)
                {
                    cuentaminusculas += 1;
                }
                else
                {
                    if (contraseña[i] >= 65 && contraseña[i] <= 90)
                    {
                        cuentamayusculas += 1;
                    }
                    else
                    {
                        cuentanumeros += 1;
                    }
                }
            }
            //Si la constraseña tiene mas de 5 numeros, mas de 1 minuscula y mas de 2 mayusculas
            if (cuentanumeros >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Constructores
        /**
         * Crea una contraseña al azar
         */
        public Password()
        {
            this.longitud = LONG_DEF;
        }

        /**
         * La contraseña sera la pasada por parametro
         * @param longitud
         */
        public Password(int longitud)
        {
            this.longitud = longitud;
            contraseña = generaPassword();
        }

    }
}
