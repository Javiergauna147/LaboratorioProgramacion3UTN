using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpn1 {
    class Program {
        static void Main(string[] args) {

            //1- Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 5
            Console.WriteLine("Punto 1");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                Console.WriteLine(i);
                }
            }

            /*
            Codifique un programa de consola en C# que permita realizar las siguientes acciones:

             Generar un número aleatorio entre 0 y 100, para ello use la función random de C#
             Una vez generado el número codifique la lógica necesaria para encontrar el número
             aleatorio ayudando al usuario informando al mismo si el número ingresado es mayor o
             menor al número aleatorio buscado. Una vez encontrado el número muestre la cantidad
             de intentos necesarios para lograrlo.
             */

        }
    }
}
