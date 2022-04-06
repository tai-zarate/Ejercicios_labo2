using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWindowsForm
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int telefono;
        private string direccion;

        public Alumno(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public Alumno(string nombre, string apellido, int dni, int telefono, string direccion):this(nombre,apellido,dni)       
        {
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Telefono: {this.telefono}");
            sb.AppendLine($"Direccion: {this.direccion}");

            return sb.ToString();
        }
    }
}
