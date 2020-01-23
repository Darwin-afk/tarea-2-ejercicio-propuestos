using System;

namespace Capitulo_8_3 //mostrar la hora del en formato AM/FM del año, el dia y el mes actual
{
    class Program
    {
        static void Main(string[] args)
        {
            String formato;

            formato = String.Format("La fecha es: {0:hh tt yyyy dddd MMMM}",DateTime.Now);

            Console.WriteLine("{0}",formato);
        }
    }
}
