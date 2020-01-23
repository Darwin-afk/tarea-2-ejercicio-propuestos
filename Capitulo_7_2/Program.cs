using System;
using System.Collections;

namespace Capitulo_7_2 //hacer un diccionarion con palabra y definicion usando el hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable diccionario = new Hashtable();

            int cant;
            String palabra, definicion;

            Console.Write("Ingrese la cantidad de palabras a digitar: ");
            cant = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < cant; i++)
            {
                Console.Write("Ingrese la palabra {0}: ",i+1);
                palabra = Console.ReadLine();
                Console.Write("Ingrese su definicion: ");
                definicion = Console.ReadLine();

                diccionario.Add(palabra, definicion);
            }

            foreach(DictionaryEntry dato in diccionario)
            {
                Console.WriteLine("{0}: {1}", dato.Key, dato.Value);
            }
        }
    }
}
