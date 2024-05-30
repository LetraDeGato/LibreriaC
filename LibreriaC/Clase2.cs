using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryC_
{
    internal class Clase2
    {
        public void Main(string[] args)
        {
            //se pueden trasnformar el tipo de datos, como por ejemplo un string en un int
            Console.WriteLine("please enter your age: ");
            string age = Console.ReadLine();
            int newAge = Convert.ToInt32(age) + 1;
            Console.WriteLine("You will be " + newAge);

            // Convert.To() sera utilizado para convertir


            //Casting

            int x = (int)1.956f; //convierte una variable o contenidon en lo que este en parentecis puede ser una variable 
            Console.WriteLine(x); //de esta manera noaproxima, si elimina los carateres

            //creacion de numeros aleatorios

            Random rgn = new Random();
            int n1 = rgn.Next(3); // el nnumero que se ponga es el numero limite para generar
            Console.WriteLine(n1); //este solo imprime numeros de 0,1,2 y ya 
            int n2 = rgn.Next(10, 16); // el primer caracter si es el numero inicial 
            Console.WriteLine(n2); //este solo imprime numeros de 10 al 15 y ya 

            // Guardar una variable para realizar calculos sobre esta sin que se altere

            int x1 = 5;
            int y1 = 3;

            int tmp = x1;// se emplea una tercera variable para poder guardar la variable
            x1 = y1;
            y1 = tmp;
            Console.WriteLine(x1);
            Console.WriteLine(y1);
        }
    }
}
