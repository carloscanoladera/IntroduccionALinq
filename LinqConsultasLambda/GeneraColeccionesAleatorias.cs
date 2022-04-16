using System;
using System.Collections.Generic;
using System.Text;

namespace LinqConsultasLambda.Debug
{
    class GeneraColeccionesAleatorias
    {


        public static List<Empleado> ListaEmpleados(int numEmpleados)
        {

            List<Empleado> listaEmpleados = new List<Empleado>();

            Random r = new Random(); 

            for (int i= 0; i < numEmpleados; i++ )
            {

                Empleado emp=null;

               switch (r.Next()%2)
                {

                    case 0:

                        emp = new Administrativo(GenerarCamposAleatorios.apellidosAleatorio(),
                                                GenerarCamposAleatorios.nombreAleatorio(),
                                                GenerarCamposAleatorios.fechaNacimientoAleatoria(),
                                                GenerarCamposAleatorios.direccionAleatoria(),
                                                GenerarCamposAleatorios.SalarioAleatorio());
                        break;

                    case 1:


                        emp = new Ejecutivo(GenerarCamposAleatorios.apellidosAleatorio(),
                                                GenerarCamposAleatorios.nombreAleatorio(),
                                                GenerarCamposAleatorios.fechaNacimientoAleatoria(),
                                                GenerarCamposAleatorios.direccionAleatoria(),
                                                GenerarCamposAleatorios.SalarioAleatorio());
                        break;


                      

                }

                listaEmpleados.Add(emp);

            }

            return listaEmpleados;

        }
    }
}
