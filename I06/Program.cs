using System;

namespace I06
{
    /*
     Escribir un programa que determine si un año es bisiesto.

     Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
     salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

     Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/
    class Program
    {
        static void Main(string[] args)
        {
            string inicioStr;
            int inicio;
            string finaltStr;
            int final;
            int anio;

            Console.Write("Ingrese un año de inicio: ");
            inicioStr = Console.ReadLine();
            if (inicioStr == "salir")
            {
                Environment.Exit(0);
            }
            while (int.TryParse(inicioStr, out inicio) == false)
            {
                Console.Write("Ese no es un número. Ingrese un número: ");
                inicioStr = Console.ReadLine();
            }

            Console.Write("Ingrese un año final: ");
            finaltStr = Console.ReadLine();
            if (inicioStr == "salir")
            {
                Environment.Exit(0);
            }
            while (int.TryParse(finaltStr, out final) == false)
            {
                Console.Write("Ese no es un número. Ingrese un número: ");
                finaltStr = Console.ReadLine();
            }

            for (int i = inicio; i <= final; i++)
            {
                anio = i;
                if((anio % 4) == 0 && (anio%100) != 0)
                {
                    Console.WriteLine("El año {0} es bisiesto", anio);
                } else
                {
                    if ((anio % 4) == 0 && (anio % 100) != 0 && (anio%400) == 0)
                    {
                        Console.WriteLine("El año {0} es bisiesto", anio);
                    }
                }
            }
        }
    }
}
