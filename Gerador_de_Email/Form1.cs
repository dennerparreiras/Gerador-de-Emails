using System;
using System.IO;
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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Gerador_de_Email
{
    public partial class MainForm : Form
    {
        static bool adminStatus = false;

        static List<User> usuarios = new List<User>();

        static string[] dataSourceDom;
        static string[] dataSourceLoc;

        static bool checkE = false;
        static bool checkC = false;
        static bool checkO = false;
        static bool checkS = false;

        const string log = @"data/log.denner";
        const string dom = @"data/dominios.denner";
        const string loc = @"data/local.denner";
        const string lXML = @"data/lista.xml";
        const string ico = @"data/app.ico";

        /// <summary>
        /// Construtor do formulário principal.
        /// </summary>
        public MainForm(bool admin)
        {
            adminStatus = admin;
            if (adminStatus)
            {
                MessageBox.Show("Logado como administrador.");
            }
            
            InitializeComponent();

            if (!adminStatus)
            {
                administrador_TSMI.Enabled = false;
                administrador_TSMI.Visible = false;
            }

            dataSourceDom = FileManager.Read(dom);
            dataSourceLoc = FileManager.Read(loc);

            // Sort the array
            FileManager.Quicksort(dataSourceDom, 0, dataSourceDom.Length - 1);
            FileManager.Quicksort(dataSourceLoc, 0, dataSourceLoc.Length - 1);

            cbEmail.DataSource = dataSourceDom;
            cbLocal.DataSource = dataSourceLoc;

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
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;

            if (File.Exists(ico))
            {
                // You should replace the bold icon in the sample below
                // with an icon of your own choosing.
                // Note the escape character used (@) when specifying the path.
                notifyIcon1.Icon =
                   new System.Drawing.Icon(ico);
                notifyIcon1.Visible = true;
                notifyIcon1.Text = this.Text;

                notifyIcon1.BalloonTipTitle = this.Text;
                notifyIcon1.BalloonTipText = "O programa está em execução...";
                notifyIcon1.ShowBalloonTip(500);
            }
        }

        /// <summary>
        /// Retorna uma string com os dados do usuário recebido por parâmetro.
        /// </summary>
        public string PrintUserData(User usuario)
        {
            FileManager.Write(usuario.ToString(), log, true);
            return usuario.ToString();
        }

        public bool VerifyFields()
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("Favor preencher o nome do usuário.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ClearFields()
        {
            tbNome.Text = "";
            tbEmail.Text = "";
            tbCargo.Text = "";
            mtbCPF.Text = "";
            tbObservacoes.Text = "";
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbReturn.Text);
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (VerifyFields())
            {
                User auxUser = new User(FileManager.CapitalizarNome(tbNome.Text), mtbCPF.Text, cbLocal.Text, tbCargo.Text, tbEmail.Text, cbEmail.Text, tbSenha.Text, tbObservacoes.Text);
                usuarios.Add(auxUser);
                tbReturn.Text += PrintUserData(auxUser);
            }
            notifyIcon1.BalloonTipText = "Usuário criado!";
            notifyIcon1.ShowBalloonTip(250);
            ClearFields();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            checkE = checkEmail.Checked;
            tbEmail.Enabled = ((checkE) ? true : false);

        }

        private void checkCPF_CheckedChanged(object sender, EventArgs e)
        {
            checkC = checkCPF.Checked;
            mtbCPF.Enabled = ((checkC) ? true : false);

        }

        private void checkObservacao_CheckedChanged(object sender, EventArgs e)
        {
            checkO = checkObservacao.Checked;
            tbObservacoes.Enabled = ((checkO) ? true : false);

        }

        private void checkSENHA_CheckedChanged(object sender, EventArgs e)
        {
            checkS = checkSENHA.Checked;
            tbSenha.Enabled = ((checkS) ? true : false);

        }

        private void usuáriosCriadosTSMI_Click(object sender, EventArgs e)
        {
            if (usuarios.Count > 0)
            {
                new ReportForm(ref usuarios).ShowDialog();
            }
            else
                MessageBox.Show("Não foi possível gerar o relatório pois não há usuários registrados.");
        }

        private void salvarTSMI_Click(object sender, EventArgs e)
        {
            FileManager.WriteXML(lXML, ref usuarios, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(lXML))
            {
                FileManager.ReadXML(lXML, ref usuarios);
            }
        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(lXML))
            {
                FileManager.ReadXML(lXML, ref usuarios);
            }
        }

        private void consultarLOG_TSMI_Click(object sender, EventArgs e)
        {
            new logForm().ShowDialog();
        }

        private void buscar_TSMI_Click(object sender, EventArgs e)
        {
            new searchForm(ref usuarios).ShowDialog();
        }

        private void About_TSMI_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuarios.Count > 0)
            {
                string msg1, msg2, msg3;
                msg1 = "As alterações não salvas serão perdidas!";
                msg2 = "\r\nDeseja salvar as alterações realizadas?";
                msg3 = "Salvar alterações...";

                DialogResult dialogResult = MessageBox.Show(msg1 + msg2, msg3, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string msg = "";
                    try
                    {
                        FileManager.WriteXML(lXML, ref usuarios, true);
                        msg = "Dados salvos com sucesso!";
                    }
                    catch (Exception erro)
                    {
                        msg = "Não foi possível salvar os dados!\r\n\r\n" + erro.Message;
                    }
                    finally
                    {
                        MessageBox.Show(msg);
                    }
                }
            }

        }

        private void administrador_TSMI_Click(object sender, EventArgs e)
        {

        }
    }
}
