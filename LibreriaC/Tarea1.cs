using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryC_
{
    internal class Tarea1
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
            #endregion
        }

    }
}
