using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    class Agenda
    {
        //Atributos
        private Contacto[] contactos;

        //Constructores
        public Agenda()
        {
            this.contactos = new Contacto[10]; //por defecto
        }

        public Agenda(int tamanio)
        {
            this.contactos = new Contacto[tamanio]; //tamaño que nosotros queramos
        }

        //Metodos
        /**
         * Añade un contacto a la agenda
         *
         * @param c
         */
        public void aniadirContacto(Contacto c)
        {

            if (existeContacto(c))
            { //Indico si existe el contacto
                MessageBox.Show("El contacto con ese nombre ya existe");
            }
            else if (agendaLlena())
            { //Indico si la agenda esta o no llena
                MessageBox.Show("La agenda esta llena, no se pueden meter mas contactos");
            }
            else
            {

                bool encontrado = false;
                for (int i = 0; i < contactos.Length && !encontrado; i++)
                {
                    if (contactos[i] == null)
                    { //controlo los nulos
                        contactos[i] = c; //Inserto el contacto 
                        encontrado = true; //Indico que lo he encontrado
                    }
                }

                if (encontrado)
                {
                    MessageBox.Show("Se ha añadido");
                }
                else
                {
                    MessageBox.Show("No se ha podido añadir");
                }
            }

        }

        /**
         * Indica si existe un contacto
         *
         * @param c
         * @return
         */
        public bool existeContacto(Contacto c)
        {

            for (int i = 0; i < contactos.Length; i++)
            {
                //Controlo nulos e indico si el contacto es el mismo
                if (contactos[i] != null && c.equals(contactos[i]))
                {
                    return true;
                }
            }
            return false;

        }

        /**
         * Lista los contactos de la agenda
         */
        public void listarContactos()
        {

            if (huecosLibre() == contactos.Length)
            {
                MessageBox.Show("No hay contactos que mostrar");
            }
            else
            {
                for (int i = 0; i < contactos.Length; i++)
                {
                    if (contactos[i] != null)
                    { //Controlo nulos
                        MessageBox.Show(contactos[i].toString());
                    }
                }
            }

        }

        /**
         * Busca un contacto por su nombre
         *
         * @param nombre
         */
        public void buscarPorNombre(String nombre)
        {

            bool encontrado = false;
            for (int i = 0; i < contactos.Length && !encontrado; i++)
            {
                //Controlo nulos y cxompruebo que es el contacto buscado (forma mas engorrosa)
                if (contactos[i] != null && contactos[i].getNombre().Trim().Equals(nombre.Trim()))
                {
                    MessageBox.Show("Su telefono es " + contactos[i].getTelefono()); //muestro el telefono
                    encontrado = true; //Indico que lo he encontrado
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado el contacto");
            }

        }

        /**
         * Indica si la agenda esta llena o no
         *
         * @return
         */
        public bool agendaLlena()
        {

            for (int i = 0; i < contactos.Length; i++)
            {
                if (contactos[i] == null)
                { //Controlo nulos
                    return false; //indico que no esta llena
                }
            }

            return true; //esta llena

        }

        /**
         * Elimina el contacto de la agenda
         *
         * @param c
         */
        public void eliminarContacto(Contacto c)
        {

            bool encontrado = false;
            for (int i = 0; i < contactos.Length && !encontrado; i++)
            {
                if (contactos[i] != null && contactos[i].equals(c))
                {
                    contactos[i] = null; //Controlo nulos
                    encontrado = true; //Indico que lo he encontrado
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Se ha eliminado el contacto");
            }
            else
            {
                MessageBox.Show("No se ha eliminado el contacto");
            }

        }

        /**
         * Indica cuantos contactos más podemos meter
         *
         * @return
         */
        public int huecosLibre()
        {

            int contadorLibres = 0;
            for (int i = 0; i < contactos.Length; i++)
            {
                if (contactos[i] == null)
                { //Controlo nulos
                    contadorLibres++; //Acumulo
                }
            }

            return contadorLibres;

        }
    }
}
