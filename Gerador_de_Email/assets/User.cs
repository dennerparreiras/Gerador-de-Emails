using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Email.assets
{
    class User
    {
        private string _nome;
        private string _usuario;
        private string _email;
        private string _dominioEmail;
        private string _local;
        private string _cargo;
        private string _senha;
        private string _cpf;
        private string _observacao;

        public string Cargo { get { return _cargo; } set { _cargo = value; } }
        public string Local { get { return _local; } set { _local = value; } }
        public string Usuario { get { return _usuario; } set { _usuario = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string DominioEmail { get { return _dominioEmail; } set { _dominioEmail = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Senha { get { return _senha; } set { _senha = value; } }
        public string CPF { get { return _cpf; } set { _cpf = value; } }
        public string Observacao { get { return _observacao; } set { _observacao = value; } }

        public User(string nome, string usuario, string dominio, string local, string cargo, string cpf, string observacao)
        {
            this._nome = nome;
            this._dominioEmail = dominio;
            this._local = local;
            this._cargo = cargo;
            this._senha = CreatePassword();

            if (usuario == "")
                GeraUsuario();
            else{
                this._usuario = usuario;
            }
            this._email = this._usuario + this._dominioEmail;
            this._cpf = cpf;
            this._observacao = observacao;
        }

        public string CreatePassword()
        {
            int str = 2, num = 4;
            const string validTXT = "abcdefghijklmnopqrstuvwxyz";
            const string validNUM = "1234567890";

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < str--)
            {
                res.Append(validTXT[rnd.Next(validTXT.Length)]);
            }
            while (0 < num--)
            {
                res.Append(validNUM[rnd.Next(validNUM.Length)]);
            }
            return res.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (_local != "")
                sb.Append("Local: " + this._local + "\r\n");

            sb.Append("Nome: " + this._nome + "\r\n");
            sb.Append("Usuário: " + this._usuario + "\r\n");
            sb.Append("Email: " + this._email + "\r\n");
            sb.Append("Senha: " + this._senha + "\r\n");

            if(_cargo != "")
                sb.Append("Cargo: " + this._cargo + "\r\n");
            if (_cpf != "   ,   ,   -")
                sb.Append("CPF: " + this._cpf + "\r\n");
            if (_observacao != "")
                sb.Append("Observação: " + this._observacao + "\r\n");
            sb.Append("\r\n");
            return sb.ToString();
        }

        public void GeraUsuario()
        {
            string[] words = this._nome.Split(' ');
            if (words.Length > 1)
                this._usuario = (words[0] + "." + words[words.Length - 1]).ToLower();
            else
            {
                this._usuario = words[0].ToLower();
                System.Windows.Forms.MessageBox.Show("Usuário definido como apenas nome (sem sobrenome).");
            }
        }
    }
}
