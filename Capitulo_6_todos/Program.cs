using System;

namespace Capitulo_6_todos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos
            String valor ="";


            // Pedimos la cantidad de salones
            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            

            // Creamos el arreglo
            float[][] calif = new float[salones][];

            // Pedimos los alumnos por salon
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.Write("Dame la cantidad de alumnos para el salon {0}: ",n+1);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);

                // Instanciamos el arreglo
                calif[n] = new float[cantidad];
            }

            // Capturamos la información
            for (n=0;n<salones;n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}: ",n+1);
                for(m=0;m<calif[n].GetLength(0);m++) // Ciclo alumnos
                {
                    Console.Write("Dame la calificación: ");
                    valor=Console.ReadLine();
                    calif[n][m]=Convert.ToSingle(valor);
                }
            }

            // Desplegamos la información
            Console.WriteLine("—— Información ——");
            for (n = 0; n<salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n+1);

                for (m = 0; m<calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m+1, calif[n][m]);
                }
            }
            Console.WriteLine("/nEl promedio del  es: {0}", promedioEscuela(calif, n));
            Console.WriteLine("El menor del  es: {0}", MenorEscuela(calif, n));
            Console.WriteLine("El mayor del  es: {0}", MayorEscuela(calif, n));
        }

        public static float promedioEscuela(float[][] calif, int cant)
        {
            int cantTotal = 0;
            float promedio = 0.0f;

            for(int i = 0; i < cant; i++)
            {
                for(int j = 0; j < calif[i].GetLength(0);j++)
                {
                    promedio += calif[i][j];
                    cantTotal++;
                }
            }

            promedio /= cantTotal;

            return promedio;
        }

        public static float MenorEscuela(float[][] calif, int cant)
        {
            float menor = 10.0f;

            for (int i = 0; i < cant; i++)
            {
                for (int j = 0; j < calif[i].GetLength(0); j++)
                {
                    if (calif[i][j] < menor)
                        menor = calif[i][j];
                }
            }

            return menor;
        }

        public static float MayorEscuela(float[][] calif, int cant)
        {
            float mayor = 0.0f;

            for (int i = 0; i < cant; i++)
            {
                for (int j = 0; j < calif[i].GetLength(0); j++)
                {
                    if (calif[i][j] > mayor)
                        mayor = calif[i][j];
                }
            }

            return mayor;
        }
    }
}
