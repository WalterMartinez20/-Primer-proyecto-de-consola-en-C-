using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables para luego inicializar desde cero.
            int num1 = 0; int num2 = 0;

            // Mostrar el titulo para la aplicacion de calculadora.
            Console.WriteLine("Primer proyecto subido a versionador Git\r");
            Console.WriteLine("------------------------\n");

            // Aqui ay que pedirle al usuario que escriba el primer numero.
            Console.WriteLine("Por favor escriba un numero y presione Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Pedir al usuario que escriba el segundo numero.
            Console.WriteLine("De favor escribir otro numero y presione Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Pedir al usuario que elija una opción.
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multipicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Tu opcion? "); 

           
            
        }
    }
}
