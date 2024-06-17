using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class Clase4
    {
        void Main(string[] args)
        {
            //// UTILIZACION DE WHILE, BREACK, CONTINUE AND FOR
            Random rng = new Random();
            int score = 0;
            int dice1 = 0;

            while (dice1 != 1)
            {
                dice1 = rng.Next(1, 7);
                if (dice1 != 1)
                {
                    score += dice1;
                    Console.WriteLine("haz lanzado un " + dice1 + " tu puntaje actual es " + score);
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Que bien, sacaste 1 asi que tu puntaje final es " + score + " Ganaste?");

            //Avece se tiene que salir del ciclo

            //para eso se utiiza el Break y los Continues

            int i = 0;
            while (i < 10) //condicion de while
            {
                i++;
                Console.WriteLine(i);
                //if (i == 5)
                //{
                //    break; // breack interrumpe el ciclo y se sale de el 
                //}
            }
            Console.WriteLine("ciclo finalizado");

            //CONTINUE

            int x = 0;
            while (x < 10)
            {
                x++;
                Console.WriteLine(i);
                //if (i == 5)
                //{
                //    continue; // continue se salta el ciclo, es decir va imprimir 1,2,3,4,6,7...
                //}
            }
            Console.WriteLine("ciclo finalizado");

            //CICLOS SIN FINAL
            // esto tambien se puede hacer dandole una condicion de (y < 350)
            int y = 0;
            while (true)
            {
                y++;
                Console.WriteLine(y);
                if (y == 10)
                {
                    break;
                }
            }
            Console.WriteLine("genial llegaste a 350");

            ////Ahora si un verdadero ejemplo de un Ciclo sin final

            //Console.WriteLine("A dónde quieres ir?");
            //Console.WriteLine("a) izquierda");
            //Console.WriteLine("b) derecha");

            //while (true)
            //{
            //    string input =Console.ReadLine();

            //    if (input == "a")
            //    {
            //        Console.WriteLine("Fuiste a la izquiera hacia el bosque");
            //        break; //Rompe y sale del loop
            //    }
            //    else if (input == "b") 
            //    { 
            //    Console.WriteLine("Fuiste a la derecha hacia las ruinas"); 
            //        break; //Rompe y sale del loop
            //    }
            //    else
            //    {
            //        //Si el jugador ingresa cualquier otra opción que será incorrecta
            //        Console.WriteLine("Entrada inválida!");
            //        Console.WriteLine("A dónde quieres ir?");
            //        Console.WriteLine("a) izquierda");
            //        Console.WriteLine("b) derecha");

            //    }
            //}

            //Console.WriteLine("Juego Finalizado");

            //usando for 3 líneas de código.. en los grande estudios esto es importante, si es para repetir sólo se usa for
            for (int u = 0; u < 5; u++) // inicializar la variable ; condición que se debe cumplir para que el ciclo se de ; x++ se ejecuta el final del ciclo
            {
                Console.WriteLine("número " + x);
            }
        }
        }
       
    }

