using System;

namespace I03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

            Validar que el dato ingresado por el usuario sea un número. X

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa,
            iterar. De lo contrario, cerrar la consola.*/

            string numeroStr;
            int numero;
            int contadorDivisores;
            string continuar;

            do
            {
                Console.Write("Ingrese un número: ");
                numeroStr = Console.ReadLine();
                if (numeroStr == "salir")
                {
                    Environment.Exit(0);
                }
                while (int.TryParse(numeroStr, out numero) == false)
                {
                    Console.Write("Ese no es un número. Ingrese un número: ");
                    numeroStr = Console.ReadLine();
                }

                for (int i = 1; i <= numero; i++)
                {
                    contadorDivisores = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            contadorDivisores++;
                        }
                    }
                    if (contadorDivisores == 2)
                    {
                        Console.WriteLine("El número {0} es primo", i);
                    }
                }
                Console.WriteLine("Desea continuar??:");
                continuar = Console.ReadLine();
            } while (continuar == "si");
        }
    }
}
