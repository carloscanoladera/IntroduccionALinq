using System;
using System.Collections.Generic;
using System.Text;

namespace LinqConsultasLambda
{
    public class Persona
    {


       
        private String elApellido;
        private String elNombre;
        private DateTime laFechaNac;
        private int laEdad;

        public Persona()
        {


        }

        public Persona(String Apellido, String Nombre, DateTime FechaNac)
        {

            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.FechaNac= FechaNac;

            laEdad = this.Edad; 


        }

        public String Apellido
        {
            get { return elApellido; }
            set { elApellido = value.ToUpper(); }
        }
        public String Nombre
        {
            get { return elNombre; }
            set { elNombre = value.ToLower(); }
        }
        public DateTime FechaNac
        {
            get { return laFechaNac; }
            set
            {
                if (value.Year >= 1900)
                {
                    laFechaNac = value;
                }
            }
        }


        public int Edad
        {

            get { return DateTime.Now.Year - FechaNac.Year; }

        }


        public override string ToString()
        {
            return String.Format("Apellidos: {0}, Nombre: {1}, FechaNac: {2:d}, Edad: {3} ", this.Apellido, this.Nombre, this.FechaNac, this.Edad);
        }
    }
}
