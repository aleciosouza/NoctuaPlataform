using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoctuaCore
{
    public class User
    {
        private int idUser;
        private string nome;
        private string sobrenome;
        private DateTime dtNasc;
        private string email;
        private string password;

        public int IdUser { get => idUser; set => idUser = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public DateTime DtNasc { get => dtNasc; set => dtNasc = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public User() { }

        public User(string nome, string sobrenome, DateTime dtNasc, string email, string password)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.dtNasc = dtNasc;
            this.email = email;
            this.password = password;
        }

        public string getFullName() {
            return nome + " " + sobrenome;
        }
    }
}
