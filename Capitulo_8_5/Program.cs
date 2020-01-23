using System;

namespace Capitulo_8_5 //solicitar dos cades y mostrarlas en orden alfabetico
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena1, cadena2;

            Console.Write("Ingrese la primera cadena: ");
            cadena1 = Console.ReadLine();
            Console.Write("Ingrese la segunda cadena: ");
            cadena2 = Console.ReadLine();

            if (cadena1.CompareTo(cadena2) < 0)
                Console.WriteLine("{0}\n{1}", cadena1, cadena2);
            else
                Console.WriteLine("{0}\n{1}", cadena2, cadena1);
        }
    }
}
