using System;
using U3I01_BC;

namespace U3I01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo una nueva instancia de cuenta usando el constructor que cree
            Cuenta miCuenta = new Cuenta("Taiel", 4000);

            //Mostrar
            Console.WriteLine(miCuenta.mostrar());

            //Ingresar número negativo
            miCuenta.ingresar(-500);
            Console.WriteLine(miCuenta.mostrar());

            //Ingresar número positivo
            miCuenta.ingresar(400);
            Console.WriteLine(miCuenta.mostrar());

            //Retirar
            miCuenta.retirar(4500);
            Console.WriteLine(miCuenta.mostrar());
        }
    }
}
