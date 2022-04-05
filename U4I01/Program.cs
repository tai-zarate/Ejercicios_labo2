using System;
using Entidades_U4I01;

namespace U4I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(1);
            Sumador s2 = new Sumador();

            Console.WriteLine(s1.Sumar(2, 2));
            Console.WriteLine(s2.Sumar("4", "4"));

            Console.WriteLine((int)s1);
            Console.WriteLine((int)s2);
            Console.WriteLine(s1+ s2);
            Console.WriteLine(s1|s2);
        }
    }
}
