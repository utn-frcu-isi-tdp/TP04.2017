using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.FRCU.ISI.Taller
{
    class Program
    {
        static void Main(string[] args)
        {


            IList<int> lista = new List<int>();

            lista.Add(5);
            lista.Add(10);
            lista.Add(1);
            lista.Add(7);
            lista.Add(21);

            Console.Write("El mínimo es {0} y el máximo es {1}.",
                          lista.Min<int>(),
                          lista.Max<int>());


            IList<Estudiante> listaEstudiantes = new List<Estudiante>();

            listaEstudiantes.Add(new Estudiante { NroLegajo = "1234", Nombre = "Juan", Apellido = "Pérez" });
            listaEstudiantes.Add(new Estudiante { NroLegajo = "56789", Nombre = "Cristian", Apellido = "Ríos" });

            foreach (Estudiante estudiante in listaEstudiantes.OrderBy(pEstudiante => pEstudiante.Nombre))
            {
                Console.WriteLine("Nombre y apellido: {0} {1}", estudiante.Nombre, estudiante.Apellido);
            }

            //try
            //{
            //    // Código que puede lanzar una excepción.

            //    Exception unaExcepcion = new Exception();

            //    throw unaExcepcion;

            //}
            //catch (IndexOutOfRangeException)
            //{
            //    // Manejo de excepciones IndexOutOfRangeException
            //    Console.WriteLine("Se ha intentado acceder fuera de los límites del array.");
            //}
            //catch (Exception exception)
            //{
            //    // Manejo de excepciones de tipo Excepcion
            //    Console.WriteLine("Ha ocurrido una excepción genérica: {0}", exception);
            //}
            //finally
            //{
            //    // Código que se ejecuta siempre, ocurra o no una excepción.
            //}

            //// Creo una lista de estudiantes.
            //IList<Estudiante> listaEstudiantes = new List<Estudiante>();

            //// Se crea un objeto de la clase Estudiante y se agrega a la lista.
            //listaEstudiantes.Add(new Estudiante
            //    {
            //        NroLegajo = "10000000/6",
            //        Nombre = "Juan Carlos",
            //        Apellido = "Pérez"
            //    });

            //// Se crea un otra instancia de Estudiante y se agrega a la lista.
            //listaEstudiantes.Add(new Estudiante
            //{
            //    NroLegajo = "35700000/9",
            //    Nombre = "Lucía",
            //    Apellido = "González"
            //});

            //// Se crea un diccionario, el cual es una colección cuyos elementos son pares clave / valor, donde la clave no puede repetirse.
            //// Este diccionario almacena las notas por alumno, identificando los mismos por su número de legajo, el cual se usa como clave,
            //// que es un String. El valor del diccionario es la nota.
            //IDictionary<String, int> notasPorLegajo = new Dictionary<String, int>();

            //// Se agrega la nota para el alumno Juan Carlos Pérez.
            //notasPorLegajo.Add("10000000/6", 7);

            //// Se agrega la nota para la alumna Lucía González.
            //notasPorLegajo.Add("35700000/9", 8);

            //// Se itera por la lista de estudiantes, imprimiendo sus datos en pantalla.
            //foreach (Estudiante estudiante in listaEstudiantes)
            //{
            //    Console.WriteLine(estudiante);

            //    // Se imprime la nota, accediendo al diccionario por la clave (el número de legajo).
            //    Console.WriteLine("Nota: {0}", notasPorLegajo[estudiante.NroLegajo]);
            //}

            //Console.WriteLine();

            //// Una forma de iterar el diccionario:
            //foreach (String nroLegajo in notasPorLegajo.Keys)
            //{
            //    Console.WriteLine("La nota del estudiante que tiene el legajo {0} es {1}.", nroLegajo, notasPorLegajo[nroLegajo]);
            //}

            DateTime fecha1 = DateTime.Now;
            DateTime fecha2 = new DateTime(1985, 1, 1);

            Console.WriteLine(DateTime.MinValue.AddYears(75).Subtract(DateTime.MinValue.AddYears(18)).TotalDays);



            Console.ReadKey();

        }
    }
}
