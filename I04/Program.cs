using System;

namespace I04
{
    /*
     Un número perfecto es un entero positivo, que es igual a la suma de todos
    los enteros positivos (excluido el mismo) que son divisores del número.

    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

    Escribir una aplicación que encuentre los 4 primeros números perfectos.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contNumerosPerfectos = 0;
            int acumuladorDivisores = 0;

            do
            {
                //Console.WriteLine("Calculando");
                //Aumentar el número
                numero++;
                acumuladorDivisores = 0;
                //Ver los divisores que tiene
                for (int i = 1; i < numero; i++)
                {
                    //Console.WriteLine("Entra al for");
                    if ((numero % i) == 0)
                    {
                        //Divisor que encuentre, divisor que acumulo
                        acumuladorDivisores += i;
                    }
                }
                //Verificar si la suma de los divisores es igual al numero
                if(acumuladorDivisores == numero)
                {
                    //Si lo es, aumento el contador de números perfectos
                    contNumerosPerfectos++;
                    Console.WriteLine("{0} es un número perfecto", numero);
                }

            } while (contNumerosPerfectos != 4);
            Console.ReadLine();
        }
    }
}
