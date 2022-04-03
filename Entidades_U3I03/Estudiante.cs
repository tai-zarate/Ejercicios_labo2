using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_U3I03
{
    public class Estudiante
    {
        /*
         La clase Estudiante:

        Tendrá un constructor estático que inicializará el atributo estático random.
        Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        El método privado CalcularPromedio retornará el promedio de las dos notas.
        El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio
        entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores
        o iguales a 4, caso contrario la inicializará con el valor -1.
        El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        Nombre, apellido y legajo.
        Nota del primer y segundo parcial.
        Promedio.
        Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".*/
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante ()
        {
            random = new Random(); 
        }

        public Estudiante (string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        //El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        //El método privado CalcularPromedio retornará el promedio de las dos notas.
        private float CalcularPromedio ()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        /*El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio
        entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores
        o iguales a 4, caso contrario la inicializará con el valor -1.*/
        public double CalcularNotaFinal ()
        {
            double notafinal;
            
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notafinal = random.Next(6, 10);
            }
            else
            {
                notafinal = -1;
            }

            return notafinal;
        }

        /*El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        Nombre, apellido y legajo.
        Nota del primer y segundo parcial.
        Promedio.
        Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".*/
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:  {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            if(this.CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota final: {this.CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }

    }
}
