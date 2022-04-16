using System;
using System.Collections.Generic;
using System.Text;

namespace LinqConsultasLambda.Debug
{
    class GenerarCamposAleatorios
    {

        public static string[] nombres =  {"ANTONIO", "MANUEL", "JOSE", "FRANCISCO", "DAVID", "JUAN", "JOSE ANTONIO", "JAVIER", "DANIEL", "JOSE LUIS",
            "FRANCISCO JAVIER","CARLOS", "JESUS", "ALEJANDRO", "FRANCISCA", "LUCIA", "MARIA ISABEL", "MARIA JOSE", "ANTONIA", "DOLORES", "SARA",
"PAULA", "ELENA", "MARIA LUISA", "RAQUEL"};
        public static string[] apellidos = {"García", "González", "Rodríguez", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez",
"Martin", "Jiménez", "Ruiz", "Hernández", "Diaz", "Moreno", "Muñoz", "Álvarez", "Romero", "Alonso", "Gutiérrez", "Navarro",
"Torres", "Domínguez", "Vázquez", "Ramos", "Gil", "Ramírez", "Serrano", "Blanco", "Molina", "Morales", "Suarez", "Ortega",
"Delgado", "Castro", "Ortiz", "Rubio", "Marín", "Sanz", "Núñez", "Iglesias", "Medina", "Garrido", "Cortes", "Castillo", "Santos"};
        public static string[] direcciones = {"Alfonso López de Haro", "Calle de Alvarfáñez de Minaya", "Calle de Arcipreste de Hita",
"Calle de Arrabal del Agua", "Plaza de Beladíez", "Plaza de Caídos en la Guerra civil", "Calle Minaya", "Calle Hermanos Galiano"};

        private static Random rand = new Random();

        private static Func<int, int, int> randomFromTo = (ini, fin) => rand.Next() % (fin-ini) +ini;

        private static Func<int, int, double> randomFromToDouble = (ini, fin) => rand.NextDouble() * (fin - ini) + ini;

        public static string nombreAleatorio()
        {
            return nombres[randomFromTo(0, nombres.Length - 1)];

        }


        public static string apellidosAleatorio()
        {

            return apellidos[randomFromTo(0, apellidos.Length - 1)] + " " + apellidos[randomFromTo(0, apellidos.Length - 1)];
        }


        public static DateTime fechaNacimientoAleatoria()
        {

            return new DateTime(randomFromTo(1960, 2001), randomFromTo(1, 12), randomFromTo(1, 28));

        }

        public static string direccionAleatoria()
        {
            return direcciones[randomFromTo(0, direcciones.Length - 1)];

        }

        public static double SalarioAleatorio()
        {

            return randomFromToDouble(600, 4000);

        }

    }
}
