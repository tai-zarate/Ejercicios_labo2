using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3I01_BC
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular()
        {
            return this.titular;
        }

        public int Cantidad()
        {
            return this.cantidad;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El titular de esta cuenta es: {this.Titular().ToUpper()}");
            sb.AppendLine($"La cantidad es de {this.Cantidad()}");

            return sb.ToString();
        }

        public void ingresar(int monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void retirar(int monto)
        {
            this.cantidad -= monto;
        }
    }
}
