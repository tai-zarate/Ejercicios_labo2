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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_unirse_Click(object sender, EventArgs e)
        {
            //Pepe
            //RuFoSo
            if(this.txb_usuario.Text.ToLower() == "Pepe".ToLower() && this.txt_password.Text == "RuFoSo")
            {
                BackColor = Color.Green;
                Clase_06_MenuPrincipal frmMenuPrin = new Clase_06_MenuPrincipal(this.txb_usuario.Text.ToLower());
                frmMenuPrin.Show();
                this.Hide();
            }
            else
            {
                BackColor = Color.Red;
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
