using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class Anidados
    {
           void Main (string[] args)
        {
            ////Ciclos Anidados -- Se usan frecuentemente, mucho cuando se quiere movimiento
            ////en dos dimensiones por ejemplo

            //for (int y=0;y<10;y++)
            //{
            //    for (int x=0;x<10;x++)
            //    {
            //        Console.Write("_");
            //    }
            //    Console.WriteLine("*");
            //}



            //// Ahora utilicemos un ciclo anidado para mover nuestro jugador

            //int playerXPos = 5; //Posición inicial de nuestro jugador en X
            //int playerYPos = 5; //Posición inicial de nuestro jugador en Y


            ////////while(true)
            ////////{
            //    ////////Console.Clear();
            //    for (int y = 0; y < 10; y++)
            //    {
            //        for (int x = 0; x < 10; x++)
            //        {
            //            if (x == playerXPos && y == playerYPos)
            //                Console.Write("O");
            //            else
            //                Console.Write("_");
            //        }
            //        Console.WriteLine();
            //    }

            //    //char input = Console.ReadKey().KeyChar;

            //    //switch (input)
            //    //{
            //    //    case 'a':
            //    //        playerXPos--;
            //    //        break;
            //    //    case 'd':
            //    //        playerXPos++;
            //    //        break;
            //    //    case 'w':
            //    //        playerYPos--;
            //    //        break;
            //    //    case 's':
            //    //        playerYPos++;
            //    //        break;
            //    //}

            ////////}



            ////Do While Loop. La diferencia con un lopp while es que se ejecuta al menos
            ////una vez. incluso si la condicion es falsa se ejecuta una vez



            ////El siguiente ciclo nunca se va a ejecutar puesto que x=1 y no 5
            //Console.WriteLine("Inicio del While");
            //int x = 1;
            //while(x==5)
            //{
            //    Console.WriteLine("Ciclo: " + x);
            //}


            ////El ciclo se va a ejecutar la primera vez y se seguirá ejecutando mientras se cumpla la condición
            //Console.WriteLine("Inicio del ciclo Do-While");
            //int y = 1;
            //do
            //{
            //    Console.WriteLine("Ciclo: " + y);
            //}
            //while(y==5); // Esta sería la condición a cumplir
        }
    }
}
