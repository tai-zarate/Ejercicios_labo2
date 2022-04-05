using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_U4C02
{
    public class Producto
    {

        //Todos sus atributos son privados.
        
        private string codigoDeBarra;
        private string marca;
        private float precio;

        //Posee sólo un constructor de instancia.
        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        //El método GetMarca, retornará el valor correspondiente al atributo marca.
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        //El método de clase (estático) MostrarProducto es público y retornará una cadena detallando los atributos de la clase.
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {p.GetMarca()}");
            sb.AppendLine($"Precio: {p.GetPrecio()}");
            sb.AppendLine($"Código de barra: {(string)p}");

            return sb.ToString();
        }
        //Posee las siguientes sobrecargas de operadores:
        //== (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool respuesta = false;
            if (!(p1 is null || p2 is null))
            {
                respuesta = (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return respuesta;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        //== (Producto, string): Retornará true si la marca del producto coincide
        //con la cadena pasada como argumento, false caso contrario.
        public static bool operator ==(Producto p1, string marca)
        {
            return p1.GetMarca() == marca;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.GetMarca() == marca);
        }

        //También poseerá el atributo codigoDeBarras, el cual se publicará sólo a través
        //de la conversión explícita nombrada más adelante.
        //explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
    }
}
