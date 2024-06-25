using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryC_
{
    internal class Parametros
    {
        public void Main(string[] args)
        {
            #region TAREA


            //A) Combinando variables
            // combina las dos variables firstName y lastName y guardalas en la variable fullName.
            // Pista: No olvides el espacio en balnco entre las variables
            string firstName = "Idendi";
            string lastName = "Latam";

            string fullName = firstName + lastName;//Tarea
            Console.WriteLine("A) " + fullName);



            //B) Simplifica el código
            // Trata de simplificar el código usando los simplificadores (codesnippets)

            int x = 5;
            x += 2;

            int y = 3;
            y += 1;

            int z = 2;
            z *= 3;



            //C) Utiliza paréntesis
            int hp = 100;
            int armor = 3;
            int damage = 10;
            //El daño debe ser reducido por la armadura. Entonces en este caso el jugador sólo debe recibir 7 de daño.
            //La matemática no funcional
            //Trata de resolverlo usando paréntesis
            hp = hp - (damage - armor);//Tarea
            Console.WriteLine("D) new HP: " + hp);



            //D) Console.ReadLine()
            //El jugado debe estar autorizado para ingresar cualquier palabra y la computadora debe repetir la palabra que el jugador ingresó.

            Console.WriteLine("D) Enter any word");
            string input = Console.ReadLine();//Tarea, leer de la consola
            Console.WriteLine("You word is " + input);//TODO: imprimir la palabra ingresada en la consola



            //E) Regiones
            //Crear y separa por regiones cada ejercicio de este script.
            #endregion// PARAMETROS
            //Para ahorrarnos lineas de codigos y no repetir una y otra vez una funcion cuando el cambio 
            //es buena practica añadirle una variable a las funciones para poder establcer un cambio al codigo

            // la variable se tiene que declarar dentro de la funcion
            CountTo(2, 10);
            CountTo(3, 15);
            CountTo(5, 20);

            // en la funcion se tiene que ingresar que tipo de variable es y la variable
            // se puede utilizar mas variables separadas por una coma
            // los parametros de las variables que se quieran dejar como default van de ultimo en la funcion
            //eso es extraño pero se deben oponer u parametro opcional, luego de un parametro obligatorio
            void CountTo(int minCount, int maxCount)
            {
                Console.WriteLine("\nConteo hasta" + maxCount);
                for (int i = minCount; i <= maxCount; i++)
                {
                    Console.WriteLine(i);
                }
            }

            //Ejercicios

            //Exercise 1
            //Try to simplify the following Code by creating a Function "RollDice".
            //This Function should have a Parameter which specifies how many sides the dice has

            DiceRoll(6);
            DiceRoll(8);
            DiceRoll(10);
            DiceRoll(20);

            void DiceRoll(int diceSides)
            {
                Random rng = new Random();
                int diceRoll = rng.Next(1, diceSides + 1);
                Console.WriteLine("has tirado un " + diceRoll + " con el D " + diceSides);

            }


            //Exercise 2
            //Write a Function which can print string-arrays to the console.
            //Use it to print both arrays.
            string[] childrenList = new string[] { "Bob Jr.", "Lisa", "Minerva" };
            string[] grownUpsList = new string[] { "Bob", "Annie", "Mary" };

            void PrintArray(string[] stringArray)
            {
                for (int i = 0; i < stringArray.Length; i++)
                {
                    Console.WriteLine(stringArray[i]);
                }
            }

            Console.WriteLine("\nLos niños: ");
            PrintArray(childrenList);
            Console.WriteLine("\nLos adultos: ");
            PrintArray(grownUpsList);

            //Exercise 3
            //Write a Greet-Function with two parameters: name, age
            //The Function should greet the user in different ways based on their age:
            //
            //if age < 18: "Hey Timmy, how are you?"
            //if age >= 18: "Hello Robert, how are you?"
            //
            //Bonus: Add an optional parameter for the Title.
            //i.e.: Hello Dr. Robert, how are you?

            void Saludo(string name, int age, string title = "")
            {
                if (age < 18)
                    Console.WriteLine("Hola" + title + " " + name + ", que tal tu dia?");
                else
                    Console.WriteLine("Hola" + title + " " + name + ", como estas?");
            }

            Saludo("Bob Jr", 12);
            Saludo("Annie", 18);
            Saludo("Bob", 60, "Dr");


            //Ejercicios personales


            Console.Write("Por favor, ingresa un número entero: ");
            int number = int.Parse(Console.ReadLine());

            IsEvenOrOdd(number);

            void IsEvenOrOdd(int number)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("El número " + number + " es Par.");

                }
                else
                {
                    Console.WriteLine("El número " + number + " es Impar.");

                }
            }

            // 

            Console.Write("Por favor, ingresa el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Por favor, ingresa el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Por favor, ingresa el tercer número entero: ");
            int num3 = int.Parse(Console.ReadLine());


            MaxOfThree(num1, num2, num3);

            void MaxOfThree(int a, int b, int c)
            {
                int max = a;

                if (b > max)
                {
                    max = b;
                }

                if (c > max)
                {
                    max = c;
                }

                Console.WriteLine("El número máximo entre " + a + ", " + b + " y " + c + " es " + max + ".");

            }
        }

    }
}
