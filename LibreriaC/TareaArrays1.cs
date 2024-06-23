using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class TareasArrys1
    {
        void Main(string[] args)
        {
            //Ejercicio 1:
            //Declarar un array de enteros el cual contenga 20 valores, luego usar un ciclo
            //For para poner los valores en un número random entre 1 y 100..

            int[] enteros = new int[20];
            Random random = new Random();

            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = random.Next(1, 101);
            }

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine("Numero Array " + enteros[i]);
            }
            //Hacer lo mismo del ejercicio anterior usando una List de enteros.

            List<int> listNumber = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int newNumber = random.Next(1, 101);
                listNumber.Add(newNumber);
            }

            for (int i = 0; i < listNumber.Count; i++)
            {
                Console.WriteLine("Numero List " + listNumber[i]);
            }


            //Ejercicio 2
            //Declare una Lista tipo string que lea texto de la consola en un ciclo sin fin.
            //Cuando el jugador ingrese algo lo añada a la lista.
            //Cuando el jugador entre el string “stop” imprimir cada item en la lista en orden inverso.
            //Por ejemplo si el jugador ingresa:

            //Bob
            //Cat
            //Monkey
            //Stop

            //El juego debe imprimir:

            //Monkey

            //Cat

            //Bob

            //c) En adición, el programa debe ordenar la Lista y la salida debe estar ordenada.

            List<string> sentences = new List<string>();
            while (true)
            {

                Console.WriteLine("Ingrese un elemento a su lista (o escriba 'stop' para detener): ");
                string lista = Console.ReadLine();
                sentences.Add(lista);
                if (lista.Equals("stop"))
                    break;

            }

            Console.WriteLine(@" 

                su lista:");


            for (int i = sentences.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(@"
                " + sentences[i]);
            }


            //Sube un documento con las respuetas
        }
    }
}
