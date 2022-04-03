using System;

namespace I09
{
    /*
     Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
       ***
      *****
     *******
    *********
    El usuario indicará cuál será la altura del triángulo ingresando un número entero
    positivo. Para el ejemplo anterior, la altura ingresada fue de 5.*/
    class Program
    {
        static void Main(string[] args)
        {
            int numero = pedirEntero("Ingrese la altura del triangulo: ");
            int contadorEspacios = numero-1;
            int bolitaDeMas = 1;

            for (int i = 1; i <= numero; i++)
            {
                for(int k = 0; k<contadorEspacios; k++)
                {
                    Console.Write(" ");
                }
                if (i == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    for (int j = 1; j <= i + bolitaDeMas; j++)
                    {
                        Console.Write("*");
                        if (j == i + bolitaDeMas)
                        {
                            Console.WriteLine();
                        }
                    }
                    bolitaDeMas++;
                }
                contadorEspacios--;
            }
        }

        static int pedirEntero(string mensaje)
        {
            int numero;
            string numeroStr;
            Console.Write(mensaje);
            numeroStr = Console.ReadLine();
            if (numeroStr == "salir")
            {
                Environment.Exit(0);
            }
            while (int.TryParse(numeroStr, out numero) == false)
            {
                Console.Write("ERROR " + mensaje);
                numeroStr = Console.ReadLine();
            }

            return numero;
        }
    }
}
