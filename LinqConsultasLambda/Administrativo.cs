using System;
using System.Collections.Generic;
using System.Text;

namespace LinqConsultasLambda
{
    class Administrativo : Empleado
    {


        public Administrativo()
        {


        }


        public Administrativo(String Apellido, String Nombre, DateTime FechaNac, string Direccion, double elSalario) : base(Apellido, Nombre, FechaNac,Direccion, elSalario)
        {

            

        }

        private const double PORCENTAJEIMPUESTOS = 0.10;
        public override double calculoImpuestos()
        {
            return PORCENTAJEIMPUESTOS*this.Salario;
        }

        public override double salarioNeto()
        {
            return this.Salario -this.calculoImpuestos();
        }
    }
}
