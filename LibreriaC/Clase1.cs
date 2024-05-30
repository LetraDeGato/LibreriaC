using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryC_
{
    internal class Clase1
    {
        public void Main(string[] args)
        {
            // VARIABLES
            // 
            // int --> almacena numeros enteros
            // float --> almacena numeros decimales 5.2f o 8.56f
            // char --> almacena caracteres simples (a,b,c, 1,2,3)
            // string --> AlInmacena una cadena de caracteres ("hola mundo")
            // bool --> Almacena la condicion (true o false)

            int myFirstVar;
            myFirstVar = 15;

            // Escribir dentro de la consola
            Console.WriteLine(7);
            // Escribir llamando una varaible establecida
            Console.WriteLine(myFirstVar);
            // reasignar una variable
            myFirstVar = 12345;
            Console.WriteLine(myFirstVar);

            //PRACTICA DE DATATYPE

            float myFloatVar;
            myFloatVar = 1.5f; // se debe utilizar la letra f al finald e un numero decimal
            Console.WriteLine(myFloatVar);

            char myCharVar;
            myCharVar = 'j';
            Console.WriteLine(myCharVar);

            string myStringVar;
            myStringVar = "Hola geNesis";
            Console.WriteLine(myStringVar);

            bool myBoolVar;
            myBoolVar = true;
            Console.WriteLine(myBoolVar);

            //NOMBRES DE VARIABLES

            int hp = 100; //health power
            int damage = 100;
            int remainingHp = hp - damage;

            //las variables en camelCase (estructura de camello minusculas la principio y mayus al resto) 
            int enemiesInRange;
            float damageToPlayer;
            float catDamageModifier;

            //las variables no pueden empezar en numeros ni en caracteres especiales
            //las variables no tienen espacio
            // ni empezar por numeros pero si contenerlos
            int player1Health;

            //LEGIBILIDAD DE UN CODIGO

            int player2Health;//declarar la variable
            player2Health = 100; // asignacion de la variable

            int player3Health = 100; //declaracion y asignacion en una sola linea

            //OPERADORES

            int x = 15;
            // el simbolo += cumple la funcion de sumarle a la variable en los dos casos igual sucede con el resto de las operaciónes 
            x = x + 5;
            x += 5;
            // muchas veces estop ayuda a añadir vida, estadisticas o artizulos al inventario

            //para añadir solo 1 unidad se pondira x ++; o apra restar uno x --;

            x++;
            x--;

            //validar con booleanos
            string password = "abc123";
            bool isPasswordCorrect = password == "abc123"; //esto seria true
                                                           //el == significa si son iguales
                                                           // el != significa no son iguales 

            //tambein se puede negar una variable utilizando el simbolo ! para darle la cognitación negativa

            bool isHappy = true; //hasta aca es true
            isHappy = !isHappy;//aca se volvio false

            //COMBINAR STRINGS

            string Player1Name = "Arturo";
            string enemyName = "Killer";
            string output = Player1Name + " ha sido masacrado por " + enemyName;
            // lo que hace el simbolo + es poner uno al lado del otro

            // la caracteristica \n salta de linea de texto}
            // #region le da la caracteristicaq de carpeta o de bloque de codigo 

            #region como utilizar #
            string ejemplo = "esto es un ejercicio";
            Console.WriteLine(ejemplo);
            #endregion

            //INGRENSAR INFO
            Console.WriteLine("Please enter your name");
            string input = Console.ReadLine();
            Console.WriteLine("Hello " + input);
        }
    }
}
