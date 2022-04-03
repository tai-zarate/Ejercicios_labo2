using System;
using Logica;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string nicknameIngresado;
            string passwordIngresado;
            

            

            Console.WriteLine("Ingrese su usuario: ");
            nicknameIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
            passwordIngresado = Console.ReadLine();

            if(Sistema.CheckearUsuario("pepe", "1234"))
        }
    }
}
