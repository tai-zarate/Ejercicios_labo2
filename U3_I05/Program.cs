using System;
using Entidades_U3I05;

namespace U3_I05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un proyecto de consola.
            En la clase Program, desarrollar un método de clase (estático) que muestre todos
            los datos de una instancia de Rectangulo que reciba como parámetro.
            En el método Main probar las funcionalidades de las clases Punto y Rectángulo.
            Instanciar un nuevo Rectangulo.
            Imprimir por pantalla los valores de área y perímetro.*/
            Punto vertice1 = new Punto(0, 0);
            Punto vertice3 = new Punto(5, 4);
            Rectangulo rectangulo = new Rectangulo(vertice1, vertice3);

            Console.WriteLine("El vertice 1 es ({0};{1})", vertice1.GetX(), vertice1.GetY());
            Console.WriteLine("El vertice 3 es ({0};{1})", vertice3.GetX(), vertice3.GetY());
            Mostrar(rectangulo);
        }
        //Funcion
        static void Mostrar(Rectangulo rectangulo)
        {
            Console.WriteLine("El area es {0}", rectangulo.Area());
            Console.WriteLine("El perimetro es {0}", rectangulo.Perimetro());
        }
    }
}
