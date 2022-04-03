using System;

namespace I05
{
    /*Un centro numérico es un número que separa una lista de números enteros
     * (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

       El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
    cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

    Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese
    por consola.*/
    class Program
    {
        static void Main(string[] args)
        {
            string numeroStr;
            int numeroIngresado;
            int centro;
            int acumuladorMenores;
            int acumuladorMayores;
            int numero=0;

            //Pido el número
            Console.Write("Ingrese un número: ");
            numeroStr = Console.ReadLine();
            if (numeroStr == "salir")
            {
                Environment.Exit(0);
            }
            while (int.TryParse(numeroStr, out numeroIngresado) == false)
            {
                Console.Write("Ese no es un número. Ingrese un número: ");
                numeroStr = Console.ReadLine();
            }

            //Busca los centros que hay hasta el número ingresado
            for (int i = 0; i<= numeroIngresado; i++)
            {
                numero++;
                //Busca el centro del número que toca
                for(int j = 0; j<numero; j++)
                {
                    acumuladorMenores = 0;
                    acumuladorMayores = 0;
                    centro = j;
                    //Los que son menores al centro
                    for (int k = 1; k < centro; k++)
                    {
                        acumuladorMenores += k;
                    }
                    //Los que son mayores al centro
                    for (int z = centro + 1; z <= numero; z++)
                    {
                        acumuladorMayores += z;
                    }
                    //Muestro si es un centro si coinciden las sumas
                    if(acumuladorMenores == acumuladorMayores)
                    {
                        Console.WriteLine("El número {0} es el centro entre (1-{1})", centro, numero);
                    }
                }
            }
        }
    }
}
