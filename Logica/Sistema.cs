using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] cuentas;

        static Sistema()
        {
            cuentas = new Usuario[4];
            CargarUsuariosHarcodeados();
        }

        private static void CargarUsuariosHarcodeados()
        {
            Usuario usuario1 = new Usuario("pepe", "1234");
            Usuario usuario2 = new Usuario("lala", "3456");
            Usuario usuario3 = new Usuario("tyron", "8923");
            Usuario usuario4 = new Usuario("tai", "1008");
        }

        public static bool CheckearUsuario (string nicknameIngresado, string passwordIngresado)
        {
            if(string.IsNullOrEmpty(nicknameIngresado) || string.IsNullOrEmpty(passwordIngresado))
            {
                return false;
            }

            for(int i = 0; i < cuentas.Length; i++)
            {
                if (cuentas[i] != null)
                {
                    if (nicknameIngresado.Trim() == cuentas[i].GetNickame().Trim())
                    {
                        return cuentas[i].ComprobarPass(passwordIngresado);
                    }
                }
            }

            return false;
        }
    }
}
