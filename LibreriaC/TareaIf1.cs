using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class TareaIf1
    {
        void Main(string[] args)
        {
            //Ejercicio If-Statements

            Console.WriteLine("-----------------1) Escoge tu camino -----------------");

            Console.WriteLine("A donde quieres ir?");
            Console.WriteLine("a: Izquierda el castillo encantado");
            Console.WriteLine("b: Al frente al bosque encantado");
            Console.WriteLine("c: Derecha al arcoiris encantado");
            string input1 = Console.ReadLine();
            //a) Reaccionar a la entrada del jugador
            //Crear if-Statements que reaccione a la entrada del jugador,
            //por ejemplo que al seleccionar "a" envie un mensaje diciendo que ha sido asustado por un fantasma


            if (input1 == "a")
                Console.WriteLine("Te han dado poderes misticos");
            else if (input1 == "b")
                Console.WriteLine("te dieron una flauta muy gorda");
            else if (input1 == "c")
                Console.WriteLine("te encontraste una olla de oro");
            else
                Console.WriteLine("pa donde vas? esta opcion no va");


            //b) qué pasa cuando hay una entrada inválida?, cuando el jugador ingresa 
            //algo diferente a "a", "b" o "c"?? debería haber un mensaje que diga "Entrada inválida"



            Console.WriteLine("-----------------2) Encuentra el bug (error)-----------------");
            //Aquí tenemos una calculadora de daño, donde el jugador puede ser invulnerable
            //si el jugador es invulnerable no debería recibir daño,
            //actualemnte el jugado recibe daño incluso si es invulnerable,
            //encuentra el error y corrígelo

            int playerHp = 100;
            int damage = 10;

            bool isPlayerInvulnerable = true;
            bool playerHasArmor = false;

            Console.WriteLine("Player HP before attack: " + playerHp);
            if (isPlayerInvulnerable == true)
                Console.WriteLine("No damage received!");

            else if (playerHasArmor == true)
            {
                playerHp -= damage / 2;
            }
            else
            {
                playerHp -= damage;
            }
            Console.WriteLine("Player HP after attack: " + playerHp);



            Console.WriteLine("-----------------3) Puzzle Game-----------------");

            Console.WriteLine("En cual posición quieres poner la clavija izquierda [arriba o abajo]");
            string leftLeverState = Console.ReadLine();
            Console.WriteLine("En cual posición quieres poner la clavija central [arriba o abajo]");
            string centerLeverState = Console.ReadLine();
            Console.WriteLine("En cual posición quieres poner la clavija derecha [arriba o abajo]");
            string rightLeverState = Console.ReadLine();

            if (rightLeverState == "arriba" && centerLeverState == "abajo" && leftLeverState == "arriba")
                Console.WriteLine("La puerta que bloquea tu camino se ha abierto, eres libre de continuar tu aventura");
            else if (rightLeverState == "arriba" && centerLeverState == "abajo" && leftLeverState == "abajo")
                Console.WriteLine("Oh no! Una trampa se ha activado y has caido en ella provocando tu muerte");
            else if (rightLeverState == "abajo" && centerLeverState == "abajo" && leftLeverState == "arriba")
                Console.WriteLine("Oh no! Una trampa se ha activado y has caido en ella provocando tu muerte");
            else Console.WriteLine("Inténtalo de nuevo");
            //a) Sólo hay una solución al acertijo:
            //Clavija izquierda: arriba
            //Clavija central: abajo
            //Clavija Derecha: arriba

            //si el jugador las pone en este orden debe aparecer un mensaje como el siguiene:
            //"La puerta que bloquea tu camino se ha abierto, eres libre de continuar tu aventura"


            //b) situaciones peligrosas
            //Clavija izquierda: arriba
            //Clavija central: abajo
            //Clavija Derecha: abajo

            //Clavija izquierda: abajo
            //Clavija central: abajo
            //Clavija Derecha: arriba

            //si el jugador pone las clavijas en estas posiciones debe aparecer un mensaje:
            //"Oh no! Una trampa se ha activado y has caido en ella provocando tu muerte"



            //c) Otras situaciones
            //Si el jugador pone las clavijas en otras posiciones aparece un mensaje como este
            //"Inténtalo de nuevo"
        }
    }
}
