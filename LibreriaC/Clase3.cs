using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class Clase3
    {
        void Main(string[] args)
        {
            Console.WriteLine("Jugador? Donde quieres ir?, a) Derecha b) Izquierda ");
            // se ingresa un input para que el jugador ingrese
            string input = Console.ReadLine();

            // IF

            if (input == "a")
            {
                Console.WriteLine("haz elegido pesimo, caes en una abismo");
            };

            if (input == "b")
            {
                Console.WriteLine("haz elegido mal, te mata un ñero");
            };

            //operadores para booleanos 

            //== busca que sea igual
            //!= busca decir que no igual
            //<= menor o igual
            //>= mayor igual que

            //ELSE

            string playerClass = "Bardo";

            if (playerClass == "Bardo") //is es la condicion si...
                Console.WriteLine("puedes cantar");
            else //else es lo que pasa si no la anterior declaración
                Console.WriteLine("No puedes cantar");


            //IF ... ELSE IF

            int playerHp = 0;

            if (playerHp == 100)
                Console.WriteLine("Tienes el maximo de Hp");
            else if (playerHp == 0) //else if no termina la secuencia, permite valorar un dato y continuar
                Console.WriteLine("Tas MUERTO!");
            else if (playerHp <= 50)
                Console.WriteLine("te hirieron ");
            else //else ve cualquiera de los otros casos
                Console.WriteLine("te hirieron pero poquito");

            // el orden de esta secuencia es que primero revise el sistema si no esta muerto y luego si lanzar la linea de codigo del daño

            // Ejercicio zona sagrada
            // Para entrar necesitas mas de 5 monedas y en la zona  solo pueden haber 100 personas o tener la llave de acceso

            int coin = 5;
            bool isKeyWithMe = true;
            int zonePopulation = 30;

            if (coin >= 5) //&& zonePopulation < 100 || isKeyWithMe == false) // && sirve para decir que se suma una condicion, asi se simplificaria el codigo
            {
                if (zonePopulation < 100 || isKeyWithMe == false) // las || sirven para decir "o" tal condicion
                    Console.WriteLine("bienvenido a la zona divina");
            }
            // hay que tener muy en cuenta que las condiciones && o || son distintas 
            // && solo true desde que las dos condiciones sean true
            // || dara verdadero si cualquiera es true

            //SWITCH

            //sucede que la metodologia else if puede ser reemplazada por switch

            Console.WriteLine("Donde quieres ir?");
            Console.WriteLine("a: Castillo tenebroso");
            Console.WriteLine("b: Mansion vampirica");
            Console.WriteLine("c: Casa de los muertos");

            string input1 = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Console.WriteLine("haz sido poseido por un fantasma");
                    break;
                case "b":
                    Console.WriteLine("te chupo la sangre un vampiro");
                    break;
                case "c":
                    Console.WriteLine("un zombie te mordio");
                    break;
                default:
                    Console.WriteLine("no paso nada");
                    break;
            }
        }
       
    }
}
