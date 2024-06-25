using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC
{
    internal class TareaArray2
    {
        void Main(string[] args)
        {
            // Arrays multidimensionales 2D o 3D 

            // los arrays tambien pueden tener dimensiones
            //primero vamos con las columnas y filas

            // los array 2D tinen 2 datos se dividen como uuna cajonmera
            // [ eje Y, eje X]
            // aca estamos declarando un arreglo 2D por medio de "[,]" y luego establecemos que tamaño va a tener

            int[,] arrayDosDimensiones = new int[3, 3];

            arrayDosDimensiones[0, 0] = 17;
            arrayDosDimensiones[1, 0] = (18);
            arrayDosDimensiones[2, 0] = (19);

            // en los videojuegos se utiliza las array para poder definir que objeto hay en que casilla
            // ejem; starvey valle, terraria, esa info esta dada en cada uno de los arreglos 2D

            // 3D se puden guardar 3 datos se le indica mediante [,,]

            int[,,] arrayTresDimensiones = new int[3, 3, 3];

            // como llenar los array de forma automatica

            int[,] newDosD = new int[3, 3];

            //mediante ciclo for se incializa en 0 (y=0), su condicion es que la variable sea menor a 3 (y < 3), luego cuando finalice el recorido va a incrementar en una unidad y (y++) 
            // lo que va hacer la inciializacion es que todos los valores de y, seran 0 ... lo que hara la condicion es verificar si el valor es mayor que 2, si nno el continuara agregando un numero a y
            // asi es primero llena los campos en vertical y luego los horizontales	
            //vamos a hacer lo mismo en x

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine(newDosD[x, y]);

                }
            }

            //DICCIONARIOS
            //los diccionarios utilizan "key" y "value"
            //key equivale a el dato que tienes y value al resultado de ese dato

            //los diccionarios permiten buscar mediante tipos de elementos
            //una key puede ser un string y su value ejemplo un int

            //Un ejemplo de los diccionarios en los videojuegos es cuando se guarda partida
            // guardara los valores de alguna variable. eso es util para la Hp, el DMG, la Xp, etc...

            // asi se declara
            //se identifica que se debe notificar el tipo de elemento que sera la key y el value (<string, int>)

            Dictionary<string, int> playerStats = new Dictionary<string, int>();

            //luego se llena (es como si se creara una tabla)

            playerStats.Add("P1Hp", 100);
            playerStats.Add("P1Dmg", 20);
            playerStats.Add("P1Armor", 5);

            playerStats.Add("P2Hp", 85);
            playerStats.Add("P2Dmg", 5);
            playerStats.Add("P2Armor", 10);

            //luego de eso se lee

            Console.WriteLine("El jugador 2 tiene " + playerStats["P2Armor"] + " de armadura");
            Console.WriteLine("El jugador 1 tiene " + playerStats["P1Hp"] + " de vida");


            //:D me di cuenta de el ejercicio tarde , corregi un par de errores al tomar apuntes pero esta es la forma en que guardo mi progreso, todo perfectamente entendido porfe, gracias mil 
        }
    }
}
