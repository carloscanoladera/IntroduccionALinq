using LinqConsultasLambda.Debug;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqConsultasLambda
{
    class Program
    {
        static void Main(string[] args)
        {
       

            List<Empleado> listaEmp = GeneraColeccionesAleatorias.ListaEmpleados(1000);

            IEnumerable<Empleado> consulta = listaEmp.Where<Empleado>(emp => emp.Edad == 50 || emp.Edad == 48)
                                                     .OrderByDescending(emp=>emp.Apellido)
                  
                                                                     


            foreach ( var empleado in consulta)
            {

                Console.WriteLine(empleado);

            }


            IEnumerable<IGrouping<int, Empleado>> consultaAgrupada = listaEmp.Where<Empleado>(emp => emp.Edad == 50 || emp.Edad == 48)
                                                     .OrderByDescending(emp => emp.Apellido).ThenByDescending(emp => emp.Nombre)
                                                     .GroupBy(emp=> emp.Edad);


            foreach (IGrouping<int, Empleado> empleadoGroup in consultaAgrupada)
            {
                Console.WriteLine("Vueltas");
                foreach ( Empleado empleado in empleadoGroup) { 

                Console.WriteLine(empleado);

                

                }

            }



            var consulta2 = listaEmp.Where<Empleado>(emp => emp.Edad == 50 || emp.Edad == 48)
                                                     .OrderByDescending(emp => emp.Apellido).ThenByDescending(emp => emp.Nombre)
                                                     .Select(emp=> new { emp.Nombre, emp.Apellido, emp.Edad } ).GroupBy(emp => emp.Edad);

            foreach (var obj in consulta2)
            {

                Console.WriteLine(obj);

            }


            IEnumerable<dynamic> consulta3 = listaEmp.Where<Empleado>(emp => emp.Edad == 50 || emp.Edad == 48)
                                                    .OrderByDescending(emp => emp.Apellido).ThenByDescending(emp => emp.Nombre)
                                                    .Select(emp => new { emp.Nombre, emp.Apellido, emp.Edad });




            var consultaJoin = consulta.Join(consulta3, emp=> emp.Edad, emp3=>emp3.Edad , (emp, emp3)=> new { emp.Nombre, emp.Apellido, emp.Direccion });
                       


            foreach (var obj in consultaJoin)
            {

                Console.WriteLine(obj);

            }



        }
    }
}
