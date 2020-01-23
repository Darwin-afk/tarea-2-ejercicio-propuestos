using System;
using System.Collections;

namespace Capitulo_7_5 //Hacer una agenda telefonica que guarde el nombre de la persona y su numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable agenda = new Hashtable();

            int cant;

            String nombre;
            int numero;

            Console.Write("Ingrese la cantidad de personas a digitar: ");
            cant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cant; i++)
            {
                Console.Write("Ingrese el nombre de la persona {0}: ", i + 1);
                nombre = Console.ReadLine();
                Console.Write("Ingrese su numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                agenda.Add(nombre, numero);
            }

            foreach (DictionaryEntry dato in agenda)
            {
                Console.WriteLine("{0} - {1}", dato.Key, dato.Value);
            }
        }
    }
}
