using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpn1 {
    class Program {
        static void Main(string[] args) {

            //1- Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 5
            Console.WriteLine("Punto 1 con bucle for");
            for (int i = 1; i <= 100; i++) {
                if (i % 2 == 0 || i % 5 == 0) {
                Console.WriteLine(i);
                }
            }

            Console.WriteLine("Punto 1 con bucle while");
            int iterator = 1;
            while (iterator <= 100) {
                if (iterator % 2 == 0 || iterator % 5 == 0) {
                    Console.WriteLine(iterator);
                }
                iterator++;
            }

            Console.WriteLine("Punto 1 con bucle do while");
            iterator = 1;
            do {
                if (iterator % 2 == 0 || iterator % 5 == 0) {
                    Console.WriteLine(iterator);
                }
                iterator++;
            } while (iterator <= 100);

            /*
            Codifique un programa de consola en C# que permita realizar las siguientes acciones:

             Generar un número aleatorio entre 0 y 100, para ello use la función random de C#
             Una vez generado el número codifique la lógica necesaria para encontrar el número
             aleatorio ayudando al usuario informando al mismo si el número ingresado es mayor o
             menor al número aleatorio buscado. Una vez encontrado el número muestre la cantidad
             de intentos necesarios para lograrlo.
             */
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, 101);
            int numeroRecibido;
            while (false) {
                Console.WriteLine("Suponga un numero secreto");
                numeroRecibido = int.Parse(Console.ReadLine());
                Console.WriteLine("El numero ingresado es: " + numeroRecibido);
                if (numeroRecibido > numeroAleatorio) {
                    Console.WriteLine("El numero secreto es menor al ingreado");
                } else if (numeroRecibido < numeroAleatorio) {
                    Console.WriteLine("El numero secreto es mayor al ingreado");
                } else {
                    Console.WriteLine("Felicidades descubriste el numero");
                    break;
                }
            }

            /*
            Codifique un método denominado esPar que reciba como parámetro un valor
            numérico entero y retorne true en caso de que el numero sea par, caso contrario
            retorne false. Compruebe el funcionamiento del método solicitando al usuario del
            programa que ingrese números aleatorios.
             */
            Console.WriteLine("Ingrese un numero para determinar si es par o no");
            numeroRecibido = int.Parse(Console.ReadLine());
            if (esPar(ref numeroRecibido)) {
                Console.WriteLine("El numero ES par");
            } else {
                Console.WriteLine("El numero NO es par");
            }


            /*
            Codifique 5 funciones C# que resuelvan las operaciones matemáticas:
            Suma +
            Resta –
            Multiplicación *
            División /
            Modulo %
            Aplicadas sobre 2 números decimales.
            Posteriormente codifique un programa que solicite el ingreso por parte del usuario de
            2 números decimales y una vez ingresados le pregunte qué operación quiere realizar:
            En caso de que no ingrese ninguna de las opciones permitidas emita el mensaje “La
            opción ingresada no es válida” y vuelva nuevamente a preguntarle qué operación
            matemática quiere ejecutar.
            Si la opción es válida envié los números decimales ingresados por el usuario a la
            función que corresponda y retorne el resultado de la operación.
            Finalmente muestre un mensaje indicando el resultado de la operación realizada.
             */
            float numeroA;
            float numeroB;

            do {
                Console.WriteLine("ingrese un primer numero flotante valido:");
            } while (!float.TryParse(Console.ReadLine(), out numeroA));

            do {
                Console.WriteLine("ingrese un segundo numero flotante valido:");
            } while (!float.TryParse(Console.ReadLine(), out numeroB));

            Console.WriteLine("que operacion desea realizar???");
            Console.WriteLine("a - Suma");
            Console.WriteLine("b - Resta");
            Console.WriteLine("c - multiplicacion");
            Console.WriteLine("d - division");
            Console.WriteLine("e - modulo");
            String operacion;
            do {
                operacion = Console.ReadLine();
                if(operacion == "a" || operacion == "b" || operacion == "c" || operacion == "d" || operacion == "e") {
                    break;
                } else {
                    Console.WriteLine("Ingrese una operacion valida");
                }
            } while (true);

            float resultado = 0;
            bool operacionOk = false;

            do {
            switch (operacion) {
                case "a": resultado = sumar(ref numeroA, ref numeroB); operacionOk = true; break;
                case "b": resultado = restar(ref numeroA, ref numeroB); operacionOk = true; break;
                case "c": resultado = multiplicar(ref numeroA, ref numeroB); operacionOk = true; break;
                case "d": resultado = dividir(ref numeroA, ref numeroB); operacionOk = true; break;
                case "e": resultado = modulo(ref numeroA, ref numeroB); operacionOk = true; break;
                default: Console.WriteLine("Ingrese una operacion valida"); operacionOk = false; break;
            }
            } while (!operacionOk);
            Console.WriteLine($"El resultado de la operacion es: {resultado}");

        }

        private static bool esPar(ref int numero) {
            if (numero % 2 == 0) {
                return true;
            } else {
                return false;
            }
        }

        private static float sumar(ref float numeroA, ref float numeroB) {
            return numeroA + numeroB;
        }
        private static float restar(ref float numeroA, ref float numeroB) {
            return numeroA - numeroB;
        }

        private static float multiplicar(ref float numeroA, ref float numeroB) {
            return numeroA * numeroB;
        }

        private static float dividir(ref float numeroA, ref float numeroB) {
            return numeroA / numeroB;
        }
        private static float modulo(ref float numeroA, ref float numeroB) {
            return numeroA % numeroB;
        }

    }
}
