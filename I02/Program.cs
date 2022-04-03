using System;

namespace I02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
             */
            int numero;
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            while(numero<0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El cuadrado de ese número es {0}", numero * numero);
            Console.WriteLine("El cubo de ese número es {0}", numero * numero*numero);
            Console.ReadLine();
        }
    }
}
