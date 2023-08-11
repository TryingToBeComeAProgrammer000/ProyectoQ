using System;

namespace ProyectoQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


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










        }
    }
}
