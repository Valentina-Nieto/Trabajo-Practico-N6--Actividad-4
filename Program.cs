using System;

namespace actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Solicitar que se ingresen 2 números enteros, realizar la operación de suma y mostrar
            resultado por pantalla.*/
            
            string entrada = "";
            int a = 0;
            int b = 0;
            int resultado = 0;

            Console.Clear();

            Console.WriteLine("Ingrese un entero");
            entrada = Console.ReadLine();

            a = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese otro número entero");
            entrada = Console.ReadLine();

            b = Convert.ToInt32(entrada);

            resultado = a + b;

            Console.WriteLine("El resultado es {0}", resultado);

            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
