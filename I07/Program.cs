using System;

namespace I07
{
    /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y
     * la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar
    el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
    multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
    bruto y el total a cobrar neto de todos los empleados ingresados.*/
    class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombre;
            int antiguedad;
            int horasMes;
            string respuesta;
            //Pedir los datos de un empleado
            do
            {
                valorHora = pedirEntero("Ingrese su valor hora: ");
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                antiguedad = pedirEntero("Ingrese su antigüedad: ");
                horasMes = pedirEntero("Ingrese la cantidad de horas trabajadas en el mes: ");

                Recibo(valorHora, nombre, antiguedad, horasMes);

                Console.WriteLine("Quiere ingresar otro empleado?:");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");
        }

        static int pedirEntero(string mensaje)
        {
            int numero;
            string numeroStr;
            Console.Write(mensaje);
            numeroStr = Console.ReadLine();
            if (numeroStr == "salir")
            {
                Environment.Exit(0);
            }
            while (int.TryParse(numeroStr, out numero) == false)
            {
                Console.Write("ERROR " + mensaje);
                numeroStr = Console.ReadLine();
            }

            return numero;
        }

        static void Recibo(int valorHora, string nombre, int antiguedad, int horasMes)
        {
            int cobroBruto = valorHora * horasMes + antiguedad * 150;
            int cobroNeto = cobroBruto - cobroBruto * 13 / 100;

            Console.WriteLine("El cobro bruto de {0} es de {1}", nombre, cobroBruto);
            Console.WriteLine("El cobro neto de {0} es de {1}", nombre, cobroNeto);
        }
    }
}
