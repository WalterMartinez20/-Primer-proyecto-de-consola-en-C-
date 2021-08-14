using System;

namespace Primer_proyecto_de_Consola_C_Sharp
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
            Console.WriteLine("Por favor escribir otro numero y presione Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Pedir al usuario que elija una opción.
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\ta - Agregar");
            Console.WriteLine("\ts - Sustraer");
            Console.WriteLine("\tm - Multipicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Tu opcion? "); 

            // Use una declaración de cambio para hacer los cálculos.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espere a que el usuario responda antes de cerrar.
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}
