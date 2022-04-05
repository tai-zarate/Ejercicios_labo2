using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_U4C02
{
    public class Estante
    {
        //Posee dos atributos privados.Uno será un entero que indicará la ubicación del estante y el
        //otro es un array de tipo Producto.
        //El constructor de instancia privado será el único que
        //incializará el array. La sobrecarga pública del constructor inicializará la
        //ubicación del estante, recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
        //El método público GetProductos, retornará el array de productos.
        
        //Posee las siguientes sobrecargas de operadores:
        //==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
        //+: Retornará true y agregará el producto si el estante posee capacidad de almacenar al
        //menos un producto más y dicho producto no se encuentra en el estante, false caso contrario. Reutilizar código.
        //-: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.

        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante) : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        //El método público de clase (estático) MostrarEstante, retornará una cadena con
        //toda la información del estante incluyendo el detalle de cada uno de sus productos. Reutilizar código.
        public static string MostrarEstante (Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"La unciación del estante es: {e.ubicacionEstante}");
            for(int i=0; i<e.GetProductos().Length; i++)
            {
                if(!(e.GetProductos()[i] is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e.GetProductos()[i]));
                    sb.AppendLine("---------------------------------------");
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool respuesta = false;

            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                if (e.GetProductos()[i] == p)
                {
                    respuesta = true;
                    break;
                }
            }

            return respuesta;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool respuesta = false;
            if(e != p)
            {
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if (e.GetProductos()[i] is null)
                    {
                        e.GetProductos()[i] = p;
                        respuesta = true;
                        break;
                    }
                }
            }

            return respuesta;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }
    }
}
