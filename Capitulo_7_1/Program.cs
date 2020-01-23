using System;
using System.Collections;

namespace Capitulo_7_1 //calcular el promedio, calificacion maxima y minima de un salon de clases usando array list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList calificacion = new ArrayList();

            int cant;

            Console.Write("Ingrese la cantidad de estudiantes: ");
            cant = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < cant; i++)
            {
                Console.Write("Ingrese calificacion {0}: ", i + 1);
                calificacion.Add(Convert.ToSingle(Console.ReadLine()));
            }

            Console.WriteLine("\nEl promedio es: {0}", promedio(calificacion));
            Console.WriteLine("\nEl minimo es: {0}", menor(calificacion));
            Console.WriteLine("\nEl maximo es: {0}", mayor(calificacion));
        }

        public static float promedio(ArrayList calif)
        {
            float prom = 0.0f;

            foreach(float nota in calif)
            {
                prom += (float)nota;
            }

            prom /= calif.Count;

            return prom;
        }

        public static float menor(ArrayList calif)
        {
            float menor = (float) calif[0];

            foreach (float nota in calif)
            {
                if (nota < menor)
                    menor = nota;
            }

            return menor;
        }

        public static float mayor(ArrayList calif)
        {
            float mayor = (float)calif[0];

            foreach (float nota in calif)
            {
                if (nota > mayor)
                    mayor = nota;
            }

            return mayor;
        }
    }
}
