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
    public partial class Clase_06_MenuPrincipal : Form
    {
        Alumno[] alumnos;

        private string usuario;
        private Clase_06_MenuPrincipal()
        {
            InitializeComponent();
            alumnos = new Alumno[10];
        }

        private void Carga()
        {
            alumnos[0] = new Alumno("pepe", "martinez",123);
            alumnos[1] = new Alumno("juana", "rufesa",432);
            alumnos[2] = new Alumno("nico", "juju",3453);
            alumnos[3] = new Alumno("mica", "mojo",643);
            alumnos[4] = new Alumno("axel", "jojo",234);
        }

        public Clase_06_MenuPrincipal(string nombreUSuario):this()
        {
            this.usuario = nombreUSuario;
        }

        private void Clase_06_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + " " + usuario;

            for (int i = 0; i < alumnos.Length; i++)
            {
                this.rtb_informacion.Text += alumnos[i].MostrarInfo() + "\n";
            }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAlumno frmAltaAlumno = new AltaAlumno();

            if(frmAltaAlumno.ShowDialog()== DialogResult.OK)
            {
                int postLibre = ProximaPos();
                if(postLibre !=-1)
                {
                    alumnos[postLibre] = frmAltaAlumno.GetAlumno();
                    this.rtb_informacion.Text += alumnos[postLibre].MostrarInfo() + "\n";
                }
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }
        }

        private int ProximaPos()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] == null)
                    return i;
            }
            return -1;
        }
    }
}
