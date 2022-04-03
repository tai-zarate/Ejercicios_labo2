using System;
using Entidades_U3I04;

namespace U3I04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(4, ConsoleColor.Red);
            string prueba1;
            string prueba2;

            Console.WriteLine("El color del boligrafo1 es {0}", boligrafo1.GetColor());
            Console.WriteLine("El color del boligrafo2 es {0}", boligrafo2.GetColor());

            Console.WriteLine("La cantidad de tinta actual del boligrafo1 es de {0}", boligrafo1.GetTinta());
            Console.WriteLine("La cantidad de tinta actual del boligrafo2 es de {0}", boligrafo2.GetTinta());

            Console.ForegroundColor = boligrafo1.GetColor();
            boligrafo1.Pintar(30, out prueba1);
            Console.WriteLine(prueba1);
            Console.WriteLine("La cantidad de tinta actual del boligrafo1 es de {0}", boligrafo1.GetTinta());

            Console.ForegroundColor = boligrafo2.GetColor();
            boligrafo2.Pintar(5, out prueba2);
            Console.WriteLine(prueba2);
            Console.WriteLine("La cantidad de tinta actual del boligrafo2 es de {0}", boligrafo2.GetTinta());

            boligrafo2.Recargar();
            Console.WriteLine("La cantidad de tinta actual del boligrafo2 es de {0}", boligrafo2.GetTinta());
        }
    }
}
