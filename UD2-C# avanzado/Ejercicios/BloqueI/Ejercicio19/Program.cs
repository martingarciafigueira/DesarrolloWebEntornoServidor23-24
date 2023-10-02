using System;

namespace Ejercicio32
{

    public class Persona
    {

        //Constantes
        /**
         * Sexo por defecto
         */
        private const char SEXO_DEF = 'H';

        /**
         * El peso de la persona esta por debajo del peso ideal
         */
        public const int INFRAPESO = -1;

        /**
         * El peso de la persona esta en su peso ideal
         */
        public const int PESO_IDEAL = 0;

        /**
         * El peso de la persona esta por encima del peso ideal
         */
        public const int SOBREPESO = 1;

        //Atributos
        /**
         * Nombre de la persona
         */
        private String nombre;

        /**
         * Edad de la persona
         */
        private int edad;

        /**
         * DNI de la persona, se genera al construir el objeto
         */
        private String DNI;

        /**
         * Sexo de la persona, H hombre M mujer
         */
        private char sexo;

        /**
         * Peso de la persona
         */
        private double peso;

        /**
         * Altura de la persona
         */
        private double altura;

        //Contructores
        /**
         * Constructor por defecto
         */
        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.sexo = SEXO_DEF;
            this.peso = 0;
            this.altura = 0;
        }

        /**
         * Constructor con 3 parametroe
         *
         * @param nombre de la persona
         * @param edad de la persona
         * @param sexo de la persona
         */
        public Persona(String nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
        }

        /**
         * Constructor con 5 parametros
         *
         * @param nombre de la persona
         * @param edad de la persona
         * @param sexo de la persona
         * @param peso de la persona
         * @param altura de la persona
         */
        public Persona(String nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
            generarDni();
            this.sexo = sexo;
            comprobarSexo();
        }

        //Métodos privados
        private void comprobarSexo()
        {

            //Si el sexo no es una H o una M, por defecto es H
            if (sexo != 'H' && sexo != 'M')
            {
                this.sexo = SEXO_DEF;
            }
        }

        private void generarDni()
        {
            int divisor = 23;

            Random numeroAleatorio = new Random();

            //Generamos un número de 8 digitos
            int numDNI = ((int)Math.Floor((double)numeroAleatorio.Next(1,9) * (100000000 - 10000000) + 10000000));
            int res = numDNI - (numDNI / divisor * divisor);

            //Calculamos la letra del DNI
            char letraDNI = generaLetraDNI(res);

            //Pasamos el DNI a String
            DNI = numDNI.ToString() + letraDNI;
        }

        private char generaLetraDNI(int res)
        {
            char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y',
            'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z',
            'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};

            return letras[res];
        }

        //Métodos publicos
        /**
         * Modifica el nombre de la persona
         *
         * @param nombre a cambiar
         */
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        /**
         * Modifica la edad de la persona
         *
         * @param edad a cambiar
         */
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        /**
         * Modifica el sexo de la persona, comprueba que es correcto
         *
         * @param sexo a cambiar
         */
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        /**
         * Modifica el peso de la persona
         *
         * @param peso a cambiar
         */
        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        /**
         * Modifica la altura de la persona
         *
         * @param altura a cambiar
         */
        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        /**
         * Calcula el indice de masa corporal
         *
         * @return codigo numerico
         * <ul><li>-1: la persona esta por debajo de su peso ideal</li>
         * <li>0: la persona esta en su peso ideal</li>
         * <li>1: la persona esta por encima de su peso ideal</li></ul>
         */
        public int calcularIMC()
        {
            //Calculamos el peso de la persona
            double pesoActual = peso / (Math.Pow(altura, 2));
            //Segun el peso, devuelve un codigo
            if (pesoActual >= 20 && pesoActual <= 25)
            {
                return PESO_IDEAL;
            }
            else if (pesoActual < 20)
            {
                return INFRAPESO;
            }
            else
            {
                return SOBREPESO;
            }
        }

        /**
         * Indica si la persona es mayor de edad
         *
         * @return true si es mayor de edad y false es menor de edad
         */
        public bool esMayorDeEdad()
        {
            bool mayor = false;
            if (edad >= 18)
            {
                mayor = true;
            }
            return mayor;
        }

        /**
         * Devuelve informacion del objeto
         *
         * @return cadena con toda la informacion
         */
        public String toString()
        {
            String sexo;
            if (this.sexo == 'H')
            {
                sexo = "hombre";
            }
            else
            {
                sexo = "mujer";
            }
            return "Informacion de la persona:\n"
                    + "Nombre: " + nombre + "\n"
                    + "Sexo: " + sexo + "\n"
                    + "Edad: " + edad + " años\n"
                    + "DNI: " + DNI + "\n"
                    + "Peso: " + peso + " kg\n"
                    + "Altura: " + altura + " metros\n";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Introducimos los datos
            Console.WriteLine("Introduce el nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Introduce la edad");
            String texto = Console.ReadLine();
            int edad = int.Parse(texto);

            Console.WriteLine("Introduce el sexo");
            char sexo = (char) Console.Read();
            Console.ReadLine();

            Console.WriteLine("Introduce el peso");
            texto = Console.ReadLine();
            double peso = double.Parse(texto);

            Console.WriteLine("Introduce la altura");
            texto = Console.ReadLine();
            double altura = double.Parse(texto);

            //Creamos objetos con cada constructor
            Persona persona1 = new Persona();
            Persona persona2 = new Persona(nombre, edad, sexo);
            Persona persona3 = new Persona(nombre, edad, sexo, peso, altura);

            //Los datos que no esten completos los insertamos con los metodos set
            persona1.setNombre("Laura");
            persona1.setEdad(30);
            persona1.setSexo('M');
            persona1.setPeso(60);
            persona1.setAltura(1.60);

            persona2.setPeso(90.5);
            persona2.setAltura(1.80);

            //Usamos metodos para realizar la misma accion para cada objeto
            Console.WriteLine("Persona1");
            MuestraMensajePeso(persona1);
            MuestraMayorDeEdad(persona1);
            Console.WriteLine(persona1.toString());

            Console.WriteLine("Persona2");
            MuestraMensajePeso(persona2);
            MuestraMayorDeEdad(persona2);
            Console.WriteLine(persona2.toString());

            Console.WriteLine("Persona3");
            MuestraMensajePeso(persona3);
            MuestraMayorDeEdad(persona3);
            Console.WriteLine(persona3.toString());

            Console.ReadKey();
        }

        public static void MuestraMensajePeso(Persona p)
        {
            int IMC = p.calcularIMC();
            switch (IMC)
            {
                case Persona.PESO_IDEAL:
                    Console.WriteLine("La persona esta en su peso ideal");
                    break;
                case Persona.INFRAPESO:
                    Console.WriteLine("La persona esta por debajo de su peso ideal");
                    break;
                case Persona.SOBREPESO:
                    Console.WriteLine("La persona esta por encima de su peso ideal");
                    break;
            }
        }

        public static void MuestraMayorDeEdad(Persona p)
        {

            if (p.esMayorDeEdad())
            {
                Console.WriteLine("La persona es mayor de edad");
            }
            else
            {
                Console.WriteLine("La persona no es mayor de edad");
            }
        }
    }
}
