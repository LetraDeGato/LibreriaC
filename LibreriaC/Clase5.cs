using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class Clase5
    {
        void Main(string[] args)
        {
            // declarar un array con un maximo de valores, en este caso 4
            int[] arrayName = new int[4];

            //poner valores a los elementos
            arrayName[0] = 17;
            arrayName[1] = 19;
            arrayName[2] = 150;
            arrayName[3] = 1300;

            Console.WriteLine(arrayName);

            // resumir codigo
            // no especificar cuantos elemetos hay ene l array y luego los elemento entre {}
            int[] enemyHp = new int[] { 10, 11, 13, 16 };

            //Tambien se puede llenar con un ciclo
            int[] hpEnemysList = new int[5];
            // se realiza un ciclo for para poder llenar segun la longitud de la array en 
            //este caso de 5 mediante enemyHp.Length
            for (int i = 0; i < enemyHp.Length; i++)
            {
                hpEnemysList[i] = 100;
            }

            //Son mejores las lista
            //funciona como un array salvo que permite tener un tamaño dinamico
            // se puede ordenar
            // se puede insetar 
            // pero son ligeramente mas lentos

            // por lo que una array va mejor apra algo que se tenga que renderizar mas
            // rapido


            //CREANDO UNA LISTA
            // primero especifico entre<> el tipo de dato que recibirla
            //no nsecesita que le den un tamaño
            List<string> list = new List<string>();

            //luego se agregan valores con "nombre de la variable".add

            list.Add("primera entrada");
            list.Add("tercera entrada");
            list.Add("segunda entrada");

            // .Insert  es para ingresar un elemento a la lista
            // en caso de querrer remplazar un elemento primero se indica 
            // en que posicion quiere que vaya el elemento (recordando que los espacios
            // son 0,1,2, etc)
            list.Insert(1, "segunda entrada");

            // .Sort organizaria por orden del el tipo de dato que sea
            // en este caso organizaria en orden alfabetico
            list.Sort();

            // .Remove remueve el elemento especificado

            list.Remove("cuarta entrada");

            // .RemoveAt remueve una elemento por medio de su ubicacion 

            list.RemoveAt(2);

            //CALSE PERSONALIZADA DE FOR

            //for es una estructura de control permite repetir codigo determinada cantidad
            //de veces su estructura es 
            //for (incializacion,condicion, iteracion
            //incializacion: por lo general es i=0 para que la variable inicie en 0
            //condicion: si la condicion es verdadera el buble continua
            //iteracion: es la expresionq ue se ejecutara al finalizar el bucle

            // este bucle se repetire hasta que i tenga el valor de 10
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }

}

