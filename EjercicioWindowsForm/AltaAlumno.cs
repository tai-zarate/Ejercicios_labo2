using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWindowsForm
{
    public partial class AltaAlumno : Form
    {
        Alumno aux;

        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            string nombre = this.tb_nombre.Text;
            string apellido = this.tb_apellido.Text;
            int.TryParse(this.tb_dni.Text, out int numDoc);
            int.TryParse(this.tb_dni.Text, out int tel);
            string direccion = this.tb_direccion.Text;

            aux = new Alumno(nombre, apellido, numDoc, tel, direccion);

            this.DialogResult = DialogResult.OK;
        }

        public Alumno GetAlumno()
        {
            return aux;
        }
    }
}
