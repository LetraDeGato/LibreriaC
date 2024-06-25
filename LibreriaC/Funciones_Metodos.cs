using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class Funciones_Metodos
    {
        void Main(string[] args)
        {
            //FUNCIONES Y METODOS
            // la funcion agreupa lineas de codigo en otras lineas de codigo
            // asi agrupara que se pueda utilizar  nuevamente

            //Para crear una funcion se utilioza "void"
            // el funcion header se le llama hac er un function header

            void DeathMesssage()
            {
                Console.WriteLine("moriste");
                Console.WriteLine("eres nuevo, verdad?");
                Console.WriteLine("GAME OVER");

            }

            // por lo general o por lo menos en c# las fundiones se expresan con mayusculas
            // quiere decir que una funcion "void", se llama GoodGaming y una variable goodGaming

            //c# se encargara de buscar la funcion independientemente de en que aprte de el codigo se encuentre


            ////---------------------------------Ejercicio 1--------------------------------------

            //Mueve estas líneas de código a una función llamada "GreetPlayer" y llámala

            //Mueve esta parte a una función llamada "CheckInput" y llámala

            /// PRIMERA PARTE DE LA AVENTURA
            GreetPlayer();
            CheckInput();
            Console.WriteLine(@"
Tienes ganas de un cafe...
Realmente quieres??");
            CafeInteraction();
            ContinueQuest();
            /// FIN PRIMERA PARTE
            void GreetPlayer()
            {
                Console.WriteLine("Hola usuario");
                Console.WriteLine("Estoy feliz de que estes aquí, qué puedo hacer por ti?");
                Console.WriteLine("Mmmmhhh... necesitas un abrazo?");
            }

            void CheckInput()
            {
                string input = Console.ReadLine();
                if (input == "si")
                {
                    Console.WriteLine("Tontito... soy una computadora, yo no puedo abrazar");
                }
                else if (input == "no")
                {
                    Console.WriteLine("Ok, tu te lo pierdes");
                }
                else
                {
                    Console.WriteLine("Comando no reconocido");
                }
            }


            void CafeInteraction()
            {
                string input = Console.ReadLine();
                if (input == "si")
                {
                    Console.WriteLine("Riegas el cafe en tu camisa");
                }
                else if (input == "no")
                {
                    Console.WriteLine("sabias que tomar cafe no seria una buena desición");
                }
                else
                {
                    Console.WriteLine("Comando no reconocido");
                }
            }

            //----------------------------Exercise 2--------------------------------------------
            //Implementa una función que imprima de forma aleatoria un reporte del clima
            //llamada RandomWeatherReport. La función debe imprimir de forma aleatoria

            // INICIO SEGUNDA PARTE DE LA AVENTURA

            Console.WriteLine("*escuchas una voz de fondo en el tv de tu sala*");
            Console.WriteLine("Y el incambiable reporte del clima, para el dia de hoy es");
            RandomWeatherReport();
            ContinueQuest();

            // FIN DE LA SEGUNDA PARTE
            void RandomWeatherReport()
            {
                Random rng = new Random();
                int rndNum = rng.Next(1, 4);

                if (rndNum == 1)
                    Console.WriteLine("que sera un maravilloso dia soleado");
                else if (rndNum == 2)
                    Console.WriteLine("que se avesina la lluvia, saquen sus sombrillsa");
                else if (rndNum == 3)
                    Console.WriteLine("que habra tormeta el dia de hoy");
            }


            //---------------- implemetancion de FUNCIOENS-----------
            void ContinueQuest()
            {
                Console.Write("\n¿Deseas continuar? (si/no): ");
                string response = Console.ReadLine();

                if (response == "si")
                {
                    Console.Clear();
                }
                else if (response == "no")
                {
                    Console.WriteLine("¡Adiós!");
                }
                else
                {
                    Console.WriteLine("Opción no válida. ");

                }
                Console.Clear();
            }
            void PlayGame()
            {
                Console.WriteLine("okay ahi te va.");
                Console.Write("Adivina un número entre 1 y 10: ");
                Random rng = new Random();
                int correctNumber = rng.Next(1, 11);
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == correctNumber)
                    Console.WriteLine("¡Correcto! Adivinaste el número.");
                else
                    Console.WriteLine($"Incorrecto. El número correcto era {correctNumber} BYEEE.");
            }
            void CheckInputTwo()
            {
                string input = Console.ReadLine();
                if (input == "si")
                {
                    Console.WriteLine("Tu!!! jajaja tu eres el chiste... que tonto sigues cayendo en eso");
                }
                else if (input == "no")
                {
                    Console.WriteLine("Ok, el dia que mee preguntes porque no me agradas ya lo sabras.");
                }
                else
                {
                    Console.WriteLine("Comando no reconocido");
                }
            }

            // TERCERA PARTE DE LA AVENTURA

            Console.WriteLine(" quieres que te cuente un chiste? responde, si o no?");
            CheckInputTwo();
            ContinueQuest();

            Console.WriteLine("jajaja ya que divertido eres, pero enserio, quiero jugar algo...");
            Console.WriteLine(" que tal si adivinas el numero que voy a generar aleatoriamente, si lo adivinas es que estas de suerte hoy");
            PlayGame();

        }
    }
}
