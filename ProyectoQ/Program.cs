using System;
using System.Collections.Generic;

namespace ProyectoQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al organizador de datos de empleados");
            Console.WriteLine("");
            Console.WriteLine("─── ❖ ── ✦ ── ❖ ─── ✦ ─── ❖ ── ✦ ── ❖ ───");
            Console.WriteLine("");
            Console.WriteLine("A continuacion hay dos opciones seleccione la que necesite");
            Console.WriteLine("");
            Console.WriteLine("1- Ver todos los salarios");
            Console.WriteLine("2- Buscar salario por un ID");
            Console.WriteLine("3- Salir");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Aqui estan los salarios");
            }
            else if (opcion == 2)
            {

                Console.WriteLine("Aqui buscas un salario por ID");

            }
            else if (opcion == 3)
            {

                Console.WriteLine("Adios!");

            }
            
            string path = "C:\\Users\\ryome\\OneDrive\\Escritorio\\Nueva carpeta (4)\\ProyectoQ\\ProyectoQ\\Archivos\\Empleados.txt";

            LeerArchivo leerArchivo = new LeerArchivo(path);
           
          Imprimirenpantalla(leerArchivo.LeerNombres());
            // ahora vamos con la escritura del documento
            EscribirArchivo escribirArchivo = new EscribirArchivo(path);
            Console.Write("escriba un nombre y apellidos: ");
            escribirArchivo.EscribirNombre(Console.ReadLine());
            Imprimirenpantalla(leerArchivo.LeerNombres());
        }

        private static void Imprimirenpantalla(List<string> nombres)
            {
                  foreach (var nombre in nombres )
                    Console.WriteLine(nombre);
        }

       
      

























































            // Dioooooss estaaa aqui estaa aquiii
        
    }
}
