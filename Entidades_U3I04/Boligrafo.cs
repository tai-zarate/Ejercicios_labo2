using System;

namespace Entidades_U3I04
{
    public class Boligrafo
    {
        static short cantidadTintaMaxima;
        ConsoleColor color;
        short tinta;

        

        /*
         * La cantidad máxima de tinta para todos los bolígrafos será de 100.
         * Generar una constante cantidadTintaMaxima en Boligrafo donde se guardará dicho valor.
         */

        static Boligrafo ()
        {
            cantidadTintaMaxima = 100;
        }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.SetTinta(tinta);
            this.color = color;
        }

        /*Generar los métodos getter GetColor y GetTinta para los correspondientes
        atributos (sólo retornarán el valor de los mismos).*/
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        //Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido,
        //modifique el valor del atributo tinta.
        //El argumento tinta contedrá la cantidad de tinta a agregar o quitar.Podrá ser positivo (cargar tinta)
        //o negativo (gastar tinta).
        //Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima.
        //Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.

        private void SetTinta(short tinta)
        {
            if(tinta >= 0 && tinta<= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }

        //El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
        public void Recargar()
        {
            this.SetTinta((short)cantidadTintaMaxima); 
        }

        /*
        
        El método Pintar restará la tinta gastada (reutilizar código). El parámetro gasto representará la
        cantidad de unidades de tinta a utilizar y utilizará tanta tinta como tenga disponible sin quedar
        en negativo. Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de
        tinta haya gastado, por ejemplo:
        Si no había nada de tinta retornará una cadena de texto vacía.
        Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
        Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
        */

        public bool Pintar(short gasto, out string dibujo)
        {
            bool valor = false;
            string respuesta = "";
            if(gasto <= this.GetTinta())
            {
                for (int i = 0; i < gasto; i++)
                {
                    respuesta += "*";
                }

                this.SetTinta((short)(this.GetTinta() - gasto));
                valor = true;
            }
            else
            {
                for (int i = 0; i < this.GetTinta(); i++)
                {
                    respuesta += "*";
                }

                this.SetTinta((short)(this.GetTinta() - this.GetTinta()));
                valor = true;
            }
            dibujo = respuesta;

            return valor;
        }
    }
}
