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

        public searchForm(ref List<User> usersList)
        {
            users = usersList;
            InitializeComponent();

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
            tabela_DGV.Parent = pictureBox1;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            tabela_DGV.Rows.Clear();
            string cpf = (mtbCPF.Text == "   ,   ,   -") ? "" : mtbCPF.Text;
            List<User> lista = users.FindAll(
                x => x.Nome.Contains(tbNome.Text) &&
                x.CPF.Contains(cpf) &&
                x.Usuario.Contains(tbUsuario.Text) &&
                x.Local.Contains(tbLocal.Text) &&
                x.Cargo.Contains(tbCargo.Text) &&
                x.Observacao.Contains(tbObservacoes.Text)
                );

            foreach (User u in lista)
            {
                tabela_DGV.Rows.Add(u.Nome, u.CPF, u.Usuario, u.Senha, u.Local, u.Cargo, u.Observacao);
            }
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
    }
}
