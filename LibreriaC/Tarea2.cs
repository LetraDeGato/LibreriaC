using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class Tarea2
    {
        void Main(string[] args)
        {
            //tarea

            // A) Arregla el bug Bugfixing
            // Mira el siguiente codigo y revisa sus salidas. 2+3
            // generalmente no es 23.
            // Trata de mirar lo que pasa y arreglarlo

            string num1 = "2";
            string num2 = "3";
            string sum = num1 + num2; //se debe realizar la suma sin cambiar el tipo de variables num1 y num2
            int new1 = Convert.ToInt32(num1);
            int new2 = Convert.ToInt32(num2);
            string newSum = Convert.ToString(new1 + new2);
            Console.WriteLine("A) " + newSum);

            //B) Calculadora simple
            // El jugador deberia poder ingresar dos Valores que son multiplicados
            // y el resultado ser mostrado
            Console.WriteLine("Ingresa el primer número");
            int input1 = int.Parse(Console.ReadLine()); //Tarea, el jugador debe ingresar el número
            Console.WriteLine("Ingresa el segundo número");
            int input2 = int.Parse(Console.ReadLine()); //Tarea el jugador debe ingresar el número
            int result = input1 * input2;
            Console.WriteLine("B)  " + input1 + "* " + input2 + "=" + result);

            //Daño aleatorio al enemigo
            //Cambia el código, asi el jugador atacará al enemigo con un valor
            //entre 10 y 15

            Random rmd = new Random();
            int enemyHp = 100;
            int dmg = rmd.Next(10, 16);//Aleatorio de 10 - 15
            enemyHp -= dmg;
            Console.WriteLine("C) Tu ataque es de " + dmg + " al enemigo. Ahora tiene " + enemyHp + "hp");
        }
    }
}
