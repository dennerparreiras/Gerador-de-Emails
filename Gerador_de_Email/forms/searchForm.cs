using Gerador_de_Email.assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Email.forms
{
    public partial class searchForm : Form
    {
        private static List<User> users = null;
        private static DataGridViewColumn[] DGVC_comSenha = new DataGridViewColumn[7];
        private static DataGridViewColumn[] DGVC_semSenha = new DataGridViewColumn[6];
        private bool firstUse = true;

        public searchForm(ref List<User> usersList)
        {
            users = usersList;
            InitializeComponent();
            this.Size = new Size(828, 212);
            tabela_DGV.Visible = false;

            tabela_DGV.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            checkExibirSenha.Parent = pictureBox1;
            checkExibirSenha.BackColor = Color.Transparent;

            status.Text = "";
            progress.Value = 0;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            status.Text = "";
            progress.Value = 0;
            if (firstUse)
            {
                firstUse = false;
                this.Size = new Size(this.Size.Width, this.Size.Height + 173);
                tabela_DGV.Visible = true;
            }
            progress.Value = 20;
            tabela_DGV.Rows.Clear();
            string cpf = (mtbCPF.Text == "   ,   ,   -") ? "" : mtbCPF.Text;
            DateTime start = DateTime.Now;
            List<User> lista = users.FindAll(
                x => x.Nome.Contains(tbNome.Text) &&
                x.CPF.Contains(cpf) &&
                x.Usuario.Contains(tbUsuario.Text) &&
                x.Local.Contains(tbLocal.Text) &&
                x.Cargo.Contains(tbCargo.Text) &&
                x.Observacao.Contains(tbObservacoes.Text)
                );
            progress.Value = 40;
            TimeSpan timeSpent = DateTime.Now.Subtract(start);
            status.Text = "Busca realizada em: " + timeSpent.ToString();

            tabela_DGV.Columns.Clear();
            if (checkExibirSenha.Checked)
            {
                tabela_DGV.Columns.AddRange(DGVC_comSenha);
                foreach (User u in lista)
                {
                    tabela_DGV.Rows.Add(u.Nome, u.CPF, u.Usuario, u.Senha, u.Local, u.Cargo, u.Observacao);
                }
            }
            else
            {
                tabela_DGV.Columns.AddRange(DGVC_semSenha);
                foreach (User u in lista)
                {
                    tabela_DGV.Rows.Add(u.Nome, u.CPF, u.Usuario, u.Local, u.Cargo, u.Observacao);
                }
            }
            progress.Value = 100;
        }

        private void Check_All(object sender, EventArgs e)
        {
            tbNome.ReadOnly = (checkNome.Checked) ? false : true;
            mtbCPF.ReadOnly = (checkCPF.Checked) ? false : true;
            tbUsuario.ReadOnly = (checkUsuario.Checked) ? false : true;
            tbLocal.ReadOnly = (checkLocal.Checked) ? false : true;
            tbCargo.ReadOnly = (checkCargo.Checked) ? false : true;
            tbObservacoes.ReadOnly = (checkObservacoes.Checked) ? false : true;

            if (!checkNome.Checked)
                tbNome.Clear();
            if (!checkCPF.Checked)
                mtbCPF.Clear();
            if (!checkUsuario.Checked)
                tbUsuario.Clear();
            if (!checkLocal.Checked)
                tbLocal.Clear();
            if (!checkCargo.Checked)
                tbCargo.Clear();
            if (!checkObservacoes.Checked)
                tbObservacoes.Clear();
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            string[] headerComSenha = { "Nome", "CPF", "Usuario", "Senha", "Local", "Cargo", "Observacoes" };
            string[] descricaoComSenha = { "Nome", "CPF", "Usuário", "Senha", "Local", "Cargo", "Observações" };
            string[] headerSemSenha = { "Nome", "CPF", "Usuario", "Local", "Cargo", "Observacoes" }; ;
            string[] descricaoSemSenha = { "Nome", "CPF", "Usuário", "Local", "Cargo", "Observações" };

            for (int x = 0; x < headerComSenha.Length; x++)
            {
                DataGridViewColumn aux = new DataGridViewTextBoxColumn();
                aux.Name = headerComSenha[x];
                aux.HeaderText = descricaoComSenha[x];
                DGVC_comSenha[x] = aux;
            }

            for (int y = 0; y < headerSemSenha.Length; y++)
            {
                DataGridViewColumn aux = new DataGridViewTextBoxColumn();
                aux.Name = headerSemSenha[y];
                aux.HeaderText = descricaoSemSenha[y];
                DGVC_semSenha[y] = aux;
            }
        }
    }
}
