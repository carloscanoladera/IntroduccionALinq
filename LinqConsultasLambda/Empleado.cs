using System;
using System.Collections.Generic;
using System.Text;

namespace LinqConsultasLambda
{
    public abstract class Empleado : Persona
    {

        private double salario;
        private string direccion;


        public Empleado()
        {


        }


        public Empleado(String Apellido, String Nombre, DateTime FechaNac, string direccion, double elSalario) : base(Apellido, Nombre, FechaNac) {
            this.Direccion = direccion;
            this.Salario = elSalario;

        }

        public abstract double calculoImpuestos();

        public abstract double salarioNeto();


        public string  Direccion { get{ return direccion; } set {direccion=value; } }

        public double Salario { get { return salario; } set { salario = value; } }

        



        public override string ToString()
        {
            return String.Format("{0} Direccion: {1} Salario: {2}", base.ToString(), this.Direccion, this.Salario);
        }
    }
}
