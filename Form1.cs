using Ejercicio_1_Windows_Forms___Progra_III;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EjerEjercicio_1_Windows_Forms___Progra_III
{
    public partial class Form1 : Form
    {
        //Instanciar una clase:
        //
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Dpi = textBox1.Text;
            persona.Nombre = textBox2.Text;
            persona.Apellido = textBox3.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            persona.edad();
            label5.Text = persona.Dpi;
            label6.Text = persona.Nombre;
            label7.Text = persona.Apellido;
            label8.Text = persona.FechaNacimiento.ToString();
            label9.Text = "Edad: " + persona.edad().ToString();

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayuscula();
            label6.Text = persona.Nombre;
            label7.Text = persona.Apellido;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            persona.normalizaNombre();
            label6.Text = persona.Nombre;
            label7.Text = persona.Apellido;
        }
    }
}

