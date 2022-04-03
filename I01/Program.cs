using System;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = int.MaxValue;
            int maximo = int .MinValue;

            
            for(int i=0; i <5; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }
            }

            Console.WriteLine("El número minimo es: {0}", minimo);
            Console.WriteLine("El número maximo es: {0}", maximo);
        }
    }
}
