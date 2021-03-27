using System;

namespace A133590.Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 16.");
            Console.WriteLine("Programa que determina si un ingreso es un número entero.");
            Console.Write("Por favor, ingrese un número: ");
            int ingreso;
            bool exito = Int32.TryParse(Console.ReadLine(), out ingreso);
            if (exito)
            {
                Console.WriteLine("El ingreso puede ser interpretado como un número entero.");
            }
            else
            {
                Console.WriteLine("El ingreso no puede ser interpretado como un número entero.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
