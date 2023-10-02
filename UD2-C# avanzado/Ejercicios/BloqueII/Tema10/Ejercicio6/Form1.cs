using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        BindingList<Alumno> listaAlumnos = new BindingList<Alumno>();
        BindingList<Profesor> listaProfesores = new BindingList<Profesor>();
        BindingList<Aula> listaAulas = new BindingList<Aula>();
        public Form1()
        {
            InitializeComponent();
            lstAlumnos.DataSource = listaAlumnos;
            lstProfesores.DataSource = listaProfesores;
            lstAulas.DataSource = listaAulas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            char sexo;
            int edad;

            nombre = textBox1.Text;
            sexo = textBox2.Text[0];
            int.TryParse(textBox3.Text, out edad);

            Alumno alumno = new Alumno();
            alumno.setNombre(nombre);
            alumno.setSexo(sexo);
            alumno.setEdad(edad);

            listaAlumnos.Add(alumno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre;
            char sexo;
            int edad;

            nombre = textBox1.Text;
            sexo = textBox2.Text[0];
            int.TryParse(textBox3.Text, out edad);

            Profesor profe = new Profesor();
            profe.setNombre(nombre);
            profe.setSexo(sexo);
            profe.setEdad(edad);

            listaProfesores.Add(profe);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula();
            listaAulas.Add(aula);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = lstAulas.SelectedIndex;
            //listaAulas[indiceSeleccionado].
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = lstAulas.SelectedIndex;
            listaAulas[indiceSeleccionado].darClase();
        }
    }
}
