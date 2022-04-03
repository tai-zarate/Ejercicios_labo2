using System;
using Entidades_U3I03;

namespace U3I03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            Mostrar los datos de todos los alumnos.*/
            Estudiante primerEstudiante = new Estudiante("Enzo", "Zarate", "1234");
            Estudiante segundoEstudiante = new Estudiante("Taiel", "Zarate", "5678");
            Estudiante tercerEstudiante = new Estudiante("Nilo", "Almirante", "9123");

            primerEstudiante.SetNotaPrimerParcial(9);
            primerEstudiante.SetNotaSegundoParcial(8);
            segundoEstudiante.SetNotaPrimerParcial(9);
            segundoEstudiante.SetNotaSegundoParcial(6);
            tercerEstudiante.SetNotaPrimerParcial(7);
            tercerEstudiante.SetNotaSegundoParcial(2);

            Console.WriteLine(primerEstudiante.Mostrar());
            Console.WriteLine(segundoEstudiante.Mostrar());
            Console.WriteLine(tercerEstudiante.Mostrar());
            Console.ReadLine();
        }
    }
}
