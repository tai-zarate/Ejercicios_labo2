using System;

namespace Logica
{
    public class Usuario
    {
        string nickname;
        string password;

        public Usuario (string nickname, string password)
        {
            this.nickname = nickname;
            this.password = password;
        }

        public bool Confirmacion (string nicknameIngresado, string passwordIngresado)
        {
            return nicknameIngresado == this.GetNickame() && passwordIngresado == this.GetPassword();
        }

        public string GetNickame ()
        {
            return this.nickname;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public bool ComprobarPass(string pass)
        {
            return this.GetPassword() == pass;
        }
    }
}
