using System;

namespace Entidades_U4I01
{
    public class Sumador
    {
        //Crear dos constructores:

        //Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
        //Sumador() inicializa cantidadSumas en cero.Reutilizará al primer constructor.
        //El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

        //En el caso de Sumar(long, long) sumará los valores numéricos
        //En el de Sumar(string, string) concatenará las cadenas de texto.
        //Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador():this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        //Seguido:

        //Generar una conversión explícita que retorne cantidadSumas.

        //Sobrecargar el operador + (suma) con dos operadores de tipo Sumador.El resultado será un long
        //correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

        //Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador.Deberá retornar true si ambos
        //sumadores tienen igual valor en el atributo cantidadSumas.

        //Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (long)((int)s1 + (int)s2);
        }

        public static bool operator|(Sumador s1,Sumador s2)
        {
            return (int)s1 == (int)s2;
        }
    }
}
