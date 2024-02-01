using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Windows_Forms___Progra_III
{
    class Persona
    {
        //Campos y Propiedades
        //Privados para cumplir con el encapsulado
        private string dpi;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;

        //Encapsulado
        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        //Metodos: Acciones que se realizan

        //Constructor de la clase:
        //Codigo que se ejecuta al crearse un objeto de esta clase
        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            //inicializar con la fecha de hoy
            fechaNacimiento = DateTime.Now;
        }

        public void PrimeraMayuscula()
        {
            if (nombre.Length > 0)
            {
                StringBuilder nombreMayuscula = new System.Text.StringBuilder(nombre);
                nombreMayuscula[0] = Char.ToUpper(nombreMayuscula[0]);
                nombre = nombreMayuscula.ToString();
            }

            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new System.Text.StringBuilder(apellido);
                apellidoMayuscula[0] = Char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
            }
        }

        public int edad()
        {
            int mes = fechaNacimiento.Month;
            int año = fechaNacimiento.Year;
            int edad;

            //calcular edad
            edad =  DateTime.Now.Year - año;

            if (mes > DateTime.Now.Month)
            {
                --edad;
            }
            return edad;
        }

        public void normalizaNombre()
        {
            //eliminar espacios en blanco
            string nombreSinEspacios = nombre.Trim();
            string apellidoSinEspacios = apellido.Trim();

            //eliminar simbolos
            StringBuilder nombreSimbolos = new StringBuilder();
            foreach(char c in nombreSinEspacios)
            {
                if(Char.IsLetter(c) || Char.IsWhiteSpace(c))
                {
                    nombreSimbolos.Append(c);
                }
            }
            string nombreSinSimbolos = nombreSimbolos.ToString();


            StringBuilder apellidoSimbolos = new StringBuilder();
            foreach (char c in apellidoSinEspacios)
            {
                if (Char.IsLetter(c) || Char.IsWhiteSpace(c))
                {
                    apellidoSimbolos.Append(c);
                }
            }
            string apellidoSinSimbolos = apellidoSimbolos.ToString();

            nombre = nombreSinSimbolos;
            apellido = apellidoSinSimbolos;
        }

    }
}

