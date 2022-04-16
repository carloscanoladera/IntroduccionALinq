using System;
using System.Collections.Generic;
using System.Text;

namespace LinqConsultasLambda
{ 
    class Ejecutivo : Empleado, IBonus

{
        private const double PORCENTAJEIMPUESTOS = 0.30;

        private const double BONUS = 400;



        public Ejecutivo()
        {


        }


        public Ejecutivo(String Apellido, String Nombre, DateTime FechaNac, string Direccion, double elSalario) : base(Apellido, Nombre, FechaNac, Direccion, elSalario)
        {



        }

        public double calculoBonus()
        {
            return BONUS;
        }

        public override double calculoImpuestos()
    {
            return (this.Salario + BONUS) * PORCENTAJEIMPUESTOS;
    }

    public override double salarioNeto()
    {
            return Salario + calculoBonus() - calculoImpuestos();
    }
}
}
