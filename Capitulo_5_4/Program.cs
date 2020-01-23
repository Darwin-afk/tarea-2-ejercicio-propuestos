using System;

namespace Capitulo_5_4
{
    class Program //calcular el factorial de un numero
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El factorial de {0} es {1}", num, factorial(num));
        }

        public static int factorial(int num)
        {
            int res = 1;

            for(int i = num; i > 1; i--)
            {
                res *= i;
            }

            return res;
        }
    }
}
