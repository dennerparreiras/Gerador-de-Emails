using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerador_de_Email.assets;
using Gerador_de_Email.forms;
using System.Drawing.Drawing2D;

namespace Gerador_de_Email.forms
{
    public partial class ReportForm : Form
    {
        private List<User> users = null;
        private int count = 0;

        public ReportForm(ref List<User> usersList)
        {
            users = usersList;
            if (usersList.Count > 0)
            {
                InitializeComponent();
                count = users.Count - 1;
                FillFields(users.Last());

                label9.Parent = pictureBox1;
                label9.BackColor = Color.Transparent;
                labelStatus.Parent = pictureBox1;
                labelStatus.BackColor = Color.Transparent;

                groupBox1.Parent = pictureBox1;
                groupBox1.BackColor = Color.Transparent;
                groupBox2.Parent = pictureBox1;
                groupBox2.BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("Ainda não foram gerados usuários!");
            }
        }

        public void FillFields(User usuario)
        {
            tbNome.Text = (usuario.Nome != "") ? usuario.Nome : "Nome não definido.";
            tbUsuario.Text = (usuario.Usuario != "") ? usuario.Usuario : "Usuário não definido.";
            tbEmail.Text = (usuario.Email != "") ? usuario.Email : "Email não definido.";
            mtbCPF.Text = (usuario.CPF != "") ? usuario.CPF : "CPF não definido.";
            tbSenha.Text = (usuario.Senha != "") ? usuario.Senha : "Senha não definida.";
            tbLocal.Text = (usuario.Local != "") ? usuario.Local : "Local não definido.";
            tbCargo.Text = (usuario.Cargo != "") ? usuario.Cargo : "Cargo não definido.";
            tbObservacoes.Text = (usuario.Observacao != "") ? usuario.Observacao : "Não há observações.";
            if (users.Count > 0)
            {
                tbCount.Text = (count + 1).ToString();
            }
            else
                tbCount.Text = "0";
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (count + 1 <= users.Count - 1)
            {
                count++;
                FillFields(users[count]);
            }
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (count - 1 >= 0)
            {
                count--;
                FillFields(users[count]);
            }
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            if (users.Count > 0)
            {
                count = users.Count - 1;
                FillFields(users.Last());
            }
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            if (users.Count > 0)
            {
                count = 0;
                FillFields(users[0]);
            }
        }

        private void tbOnly1Name_Click(object sender, EventArgs e)
        {
            string[] firstName = tbNome.Text.Split(' ');
            Clipboard.SetText(firstName[0]);
        }

        private void tbOnly2Name_Click(object sender, EventArgs e)
        {
            string[] array = tbNome.Text.Split(' ');
            if (array.Length > 1)
                Clipboard.SetText(tbNome.Text.Substring(array[0].Length + 1));
            else
                MessageBox.Show("Não há sobrenomes registrados para este usuário.");
        }

        private void btCopyNome_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbNome.Text);
        }

        private void btCopyUsuario_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbUsuario.Text);
        }

        private void btCopyEmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbEmail.Text);
        }

        private void btCopyCPF_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mtbCPF.Text);
        }

        private void btCopySenha_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbSenha.Text);
        }

        private void btCopyLocal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbLocal.Text);
        }

        private void btCopyCargo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCargo.Text);
        }

        private void btCopyObs_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbObservacoes.Text);
        }

        private void btCopyAll_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(users[count].ToString());
        }

        private void btFirst_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Ir para o primeiro usuário";
            if (!(count - 1 >= 0))
            {
                if (users.Count > 0)
                    labelStatus.Text += "   (Este já é o primeiro usuário.)";
                else
                    labelStatus.Text += "   (Não há usuários a serem listados.)";
            }
        }

        private void btPrevious_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Ir para o usuário anterior";
            if (!(count - 1 >= 0))
            {
                if (users.Count > 0)
                    labelStatus.Text += "   (Este já é o primeiro usuário.)";
                else
                    labelStatus.Text += "   (Não há usuários a serem listados.)";
            }
        }

        private void btNext_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Ir para o proximo usuário";
            if (count == users.Count - 1)
            {
                labelStatus.Text += "   (Este já é o último usuário.)";
            }
            else if (count == users.Count && count == 0)
            {
                labelStatus.Text += "   (Não há usuários a serem listados.)";
            }

        }

        private void btLast_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Ir para o último usuário";
            if (count == users.Count - 1)
            {
                labelStatus.Text += "   (Este já é o último usuário.)";
            }
            else if (count == users.Count && count == 0)
            {
                labelStatus.Text += "   (Não há usuários a serem listados.)";
            }
        }

        private void btFirst_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btPrevious_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btNext_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btLast_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btOnly1Name_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência somente o primeiro nome.";
        }

        private void btOnly1Name_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btOnly2Name_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência somente o sobrenome.";
        }

        private void btOnly2Name_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyNome_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência o nome completo.";
        }

        private void btCopyNome_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyUsuario_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência o login do usuário.";
        }

        private void btCopyUsuario_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyEmail_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência o email do usuário.";
        }

        private void btCopyEmail_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyCPF_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência o CPF do usuário.";
        }

        private void btCopyCPF_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopySenha_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência a senha no usuário.";
        }

        private void btCopySenha_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyLocal_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência o local.";
        }

        private void btCopyLocal_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyCargo_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência o cargo do usuário.";
        }

        private void btCopyCargo_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyObs_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência as observações.";
        }

        private void btCopyObs_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btCopyAll_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Copia para a área de transferência todos os dados do usuário.";
        }

        private void btCopyAll_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            User usr = users[count];

            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o usuário " + usr.Nome + " ?", "Ecluir usuário?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool userDeleted = false;
                try
                {
                    if (users.Count > 0)
                    {
                        if (count == 1 && users.Count == 1)
                        {
                            users.RemoveAt(0);
                            userDeleted = true;
                            count = 0;
                            FillFields(new User());
                        }
                        else if (count < users.Count)
                        {
                            users.RemoveAt(count);
                            userDeleted = true;
                            if (count == 0)
                            {
                                FillFields(new User());
                                this.Dispose();
                            }
                            else
                            {
                                count--;
                                FillFields(users[count]);
                            }
                        }
                    }
                    else
                    {
                        count = 0;
                        FillFields(new User());
                        this.Dispose();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    if (userDeleted)
                        MessageBox.Show("Usuário " + usr.Usuario + " apagado com sucesso!");
                    else
                        MessageBox.Show("Não foi possível apagar o usuário " + usr.Usuario + "!");
                }
            }
        }

        private void btDelete_MouseHover(object sender, EventArgs e)
        {
            labelStatus.Text = "Apaga o usuário atual.";
        }

        private void btDelete_MouseLeave(object sender, EventArgs e)
        {
            labelStatus.Text = " ";
        }
    }
}
