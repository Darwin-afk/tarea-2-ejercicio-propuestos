using System;

namespace Capitulo_5_5 //dado un numero regresar una cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            String cad;

            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            cad = num.ToString();

            Console.Write("La cadena es: {0}", cad);
        }
    }
}
