using Gerador_de_Email.assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Email.assets
{
    /// <summary>
    /// Classe/Objeto que representa um usuário do sistema e seus dados.
    /// </summary>
    [Serializable]
    public class User
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
        public PassConfig _configSenha;

        public string Cargo { get { return _cargo; } set { _cargo = value; } }
        public string Local { get { return _local; } set { _local = value; } }
        public string Usuario { get { return _usuario; } set { _usuario = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string DominioEmail { get { return _dominioEmail; } set { _dominioEmail = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Senha { get { return _senha; } set { _senha = value; } }
        public string CPF { get { return _cpf; } set { _cpf = value; } }
        public string Observacao { get { return _observacao; } set { _observacao = value; } }
        public PassConfig ConfigSenha { get { return _configSenha; } set { _configSenha = value; } }

        /// <summary>
        /// Construtor do objeto User (Usuário).
        /// </summary>
        /// <param name="nome"> Nome completo do usuário.</param>
        /// <param name="cpf"> String com o CPF do usuário.</param>
        /// <param name="local"> Local onde se encontra o usuário. Ex.: "Escritório Central"</param>
        /// <param name="cargo"> Cargo do usuário. Ex.: "Auxiliar Administrativo"</param>
        /// <param name="usuario"> Representação do usuário no Login. Ex.: "fulano.silva"</param>
        /// <param name="dominio"> Domínio que será utilizado no email do usuário. Ex.: "@aterpa.com.br"</param>
        /// <param name="senha"> Senha do usuário para acesso à rede e email.</param>
        /// <param name="observacao"> Observações relacionadas ao usuário.</param>

        public User(string nome, string cpf, string local, string cargo, string usuario, string dominio, string senha, string observacao, PassConfig senhaConfig)
        {
            this._nome = nome;
            this._dominioEmail = dominio;
            this._local = local;
            this._cargo = cargo;
            this._senha = CreatePassword();

            if (senha == "")
                CreatePassword();
            else
            {
                this._senha = senha;
            }

            if (usuario == "")
                this._usuario = GeraUsuario(this._nome);
            else
            {
                this._usuario = usuario;
            }
            this._email = this._usuario + this._dominioEmail;
            this._cpf = cpf;
            this._observacao = observacao;
        }

        /// <summary>
        /// Construtor do objeto User (Usuário) que não recebe parâmetros para criação.
        /// </summary>
        public User()
        {
            this._nome = " ";
            this._dominioEmail = " ";
            this._local = " ";
            this._cargo = " ";
            this._senha = " ";
            this._usuario = " ";
            this._email = " ";
            this._cpf = " ";
            this._observacao = " ";
            this.ConfigSenha = new PassConfig();
        }

        private string CreatePassword()
        {
            int str = (int)ConfigSenha.letters, num = (int)ConfigSenha.numbers;
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

            if (_cargo != "")
                sb.Append("Cargo: " + this._cargo + "\r\n");
            if (_cpf != "   ,   ,   -")
                sb.Append("CPF: " + this._cpf + "\r\n");
            if (_observacao != "")
                sb.Append("Observação: " + this._observacao + "\r\n");
            sb.Append("\r\n");
            return sb.ToString();
        }

        private string GeraUsuario(string nome)
        {
            string user = "";
            string[] nameSplited = nome.Split(' ');
            if (nameSplited.Length > 1)
                user = (nameSplited[0] + "." + nameSplited[nameSplited.Length - 1]).ToLower();
            else
            {
                user = nameSplited[0].ToLower();
                System.Windows.Forms.MessageBox.Show("Usuário definido como apenas nome (sem sobrenome).");
            }
            return GetStringNoAccentsOrSpace(user);
        }

        private string GetStringNoAccentsOrSpace(string str)
        {
            /** Troca os caracteres acentuados por não acentuados **/
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };

            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }

            /** Troca os caracteres especiais da string por "" **/
            //Representação de ponto => "\\."
            string[] caracteresEspeciais = { " ", ",", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°" };

            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }

            /** Troca os espaços no início por "" **/
            str = str.Replace("^\\s+", "");

            /** Troca os espaços no início por "" **/
            str = str.Replace("\\s+$", "");

            /** Troca os espaços duplicados, tabulações e etc por "" **/
            str = str.Replace("\\s+", "");
            return str;
        }
    }
}
