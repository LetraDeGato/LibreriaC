using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class TareaWhile
    {
        void Main(string[] args)
        {
            // Ejercicios

            //Ejercicio 1
            //Imprimir los números del 1 al 15 utilizando primero el ciclo while y después el ciclo for

            int x = 0;
            while (x < 15)
            {
                x++;
                Console.WriteLine("tu ciclo while va en " + x);
            }
            Console.WriteLine("que bien llegaste a 15, ciclo finalizado!");

            for (int y = 0; y < 15; y++)
            {
                Console.WriteLine("tu ciclo for va en " + y);
            }
            Console.WriteLine("tu ciclo for llego a 15 ciclo finalizado!");

            //Ejercicio 2
            //Cambia el código para que ahora cuente de 15 a 1 en cuenta regresiva

            for (int y = 15; y > 0; y--)
            {
                Console.WriteLine("tu ciclo alreves va en " + y);
            }
            Console.WriteLine("tu ciclo alreves llego a 1 ciclo finalizado!");

            //Ejercicío 3
            //Crea un ciclo sin fin, en el cual el usuario ingrese un comando. Cuando el usuario ingrese "Salir" el programa
            // se rompe (break) y termina. Si ingresa cualquier otro comando debe aparecer un mensaje "Comando desconocido" y volver a pedir
            // que ingrese un comando.

            Console.WriteLine("A dónde quieres ir?");
            Console.WriteLine("a) izquierda");
            Console.WriteLine("b) derecha");
            Console.WriteLine("si quieres dejar la sala solo escribe Salir");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "a")
                {
                    Console.WriteLine("Fuiste a la izquiera hacia el bosque");
                    break; //Rompe y sale del loop
                }
                else if (input == "b")
                {
                    Console.WriteLine("Fuiste a la derecha hacia las ruinas");
                    break; //Rompe y sale del loop
                }
                else if (input == "salir" || input == "Salir")
                {
                    Console.WriteLine("Fuiste a la derecha hacia las ruinas");
                    break; //Rompe y sale del loop
                }
                else
                {
                    //Si el jugador ingresa cualquier otra opción que será incorrecta
                    Console.WriteLine("Comando desconocido");
                    Console.WriteLine("A dónde quieres ir?");
                    Console.WriteLine("a) izquierda");
                    Console.WriteLine("b) derecha");
                    Console.WriteLine("si quieres dejar la sala solo escribe Salir");

                }
            }
            Console.WriteLine("Saliste del ciclo, encuentras algo particular...");

            //Ejercicio 4
            //Crear una variable de hp que sea igual a 100. Ahora crear un ciclo sin fin.
            //Durante este ciclo el usuario será capaz de ingresar números (daño). La variable hp se debe reducir en este número daño.
            //Cuando la variable hp sea cero debe salir un mensaje que di "El jugador ha muerto" y salir del loop.

            int hp = 100;
            Console.WriteLine(@"el caballerito esta listo para recibir tus golpes, Vamos mequetrefe GOLPEA!!!

ingresa un numero para hacer daño al caballerito");

            while (true)
            {
                int damage = Convert.ToInt32(Console.ReadLine());
                hp -= damage;
                Console.WriteLine("la vida actual de el caballerito es " + hp);
                if (hp == 0)
                {
                    break;
                }
                else if (hp != 0)
                {
                    Console.WriteLine("Vamos mequetrefe un poco mas");
                }

            }
            Console.WriteLine("El caballerito ha muerto :C");
        }
    }
}
