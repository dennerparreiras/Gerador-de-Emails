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
        static Parameters config = new Parameters();

        static string[] dataSourceDom;
        static string[] dataSourceLoc;

        static bool checkE = false;
        static bool checkC = false;
        static bool checkO = false;
        static bool checkS = false;
        static bool checkG = false;

        const string normalModeText = "FLUXUS - Gerador de Usuários";
        const string adminModeText = "FLUXUS - Gerador de Usuários (Modo Administrador)";

        /// <summary>
        /// Construtor do formulário principal.
        /// </summary>
        public MainForm(bool admin)
        {
            if (File.Exists(@"data/config.data"))
            {
                config = new CustomBinarySerializer<Parameters>().DeserializeFromBinaryFile(@"data/config.data");
            }
            else
            {
                new CustomBinarySerializer<Parameters>().SerializeToBinaryFile(config, @"data/config.data");
            }

            /////////////////////////////////////////
            if (!admin)
                admin = config.startAdmMode;
            adminStatus = admin;
            InitializeComponent();
            ChangeFormDesign(adminStatus);
            /////////////////////////////////////////

            dataSourceDom = FileManager.Read(config.listDomain);
            dataSourceLoc = FileManager.Read(config.listPlace);

            // Sort the array
            try
            {
                if (dataSourceDom != null)
                    FileManager.Quicksort(dataSourceDom, 0, dataSourceDom.Length - 1);
                if (dataSourceLoc != null)
                    FileManager.Quicksort(dataSourceLoc, 0, dataSourceLoc.Length - 1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Falha de Ordenação");
            }

            cbEmail.DataSource = dataSourceDom;
            cbLocal.DataSource = dataSourceLoc;
            tbConsole.Parent = pictureBox1;
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
            btConsole.Parent = pictureBox1;
            btConsole.BackColor = Color.Transparent;


            if (File.Exists(config.icon))
            {
                // You should replace the bold icon in the sample below
                // with an icon of your own choosing.
                // Note the escape character used (@) when specifying the path.
                notifyIcon1.Icon = new System.Drawing.Icon(config.icon);
                notifyIcon1.Visible = true;
                notifyIcon1.Text = this.Text;

                notifyIcon1.BalloonTipTitle = this.Text;
                notifyIcon1.BalloonTipText = "O programa está em execução...";
                notifyIcon1.ShowBalloonTip(500);
            }

            if (File.Exists(config.XMLFile))
            {
                FileManager.ReadXML(config.XMLFile, ref usuarios);
            }

            this.AcceptButton = btGenerate;
        }

        /// <summary>
        /// Retorna uma string com os dados do usuário recebido por parâmetro.
        /// </summary>
        public string PrintUserData(User usuario)
        {
            FileManager.Write(usuario.ToString(), config.LogFile, true);
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
            try
            {
                tbNome.Clear();
                tbEmail.Clear();
                tbCargo.Clear();
                mtbCPF.Clear();
                tbObservacoes.Clear();
            }
            catch
            {
                MessageBox.Show("Houve uma falha ao tentar limpar os campos!");
            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbReturn.Text);
            }
            catch
            {
                Clipboard.SetText(" ");
            }
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
            tbEmail.Enabled = checkE;
            if (!checkC)
            {
                tbEmail.Clear();
            }
        }

        private void checkCPF_CheckedChanged(object sender, EventArgs e)
        {
            checkC = checkCPF.Checked;
            mtbCPF.Enabled = checkC;
            if (!checkC)
            {
                mtbCPF.Clear();
            }
        }

        private void checkObservacao_CheckedChanged(object sender, EventArgs e)
        {
            checkO = checkObservacao.Checked;
            tbObservacoes.Enabled = checkO;
        }

        private void checkSENHA_CheckedChanged(object sender, EventArgs e)
        {
            checkS = checkSENHA.Checked;
            tbSenha.Enabled = checkS;
            if (!checkS)
            {
                tbSenha.Clear();
            }
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
            FileManager.WriteXML(config.XMLFile, ref usuarios, true);
            new CustomBinarySerializer<Parameters>().SerializeToBinaryFile(config, @"data/config.data");
        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(config.XMLFile))
            {
                FileManager.ReadXML(config.XMLFile, ref usuarios);
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
                        FileManager.WriteXML(config.XMLFile, ref usuarios, true);
                        new CustomBinarySerializer<Parameters>().SerializeToBinaryFile(config, @"data/config.data");
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && config.startMinimized)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (config.startMinimized)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void parâmetrosDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ParametersForm(ref config).ShowDialog();
        }

        private void btConsole_Click(object sender, EventArgs e)
        {
            checkG = !checkG;
            tbConsole.Visible = checkG;
            btConsoleGo.Visible = checkG;
            if (!checkG)
            {
                tbConsole.Clear();
            }
        }

        private void btConsoleGo_Click(object sender, EventArgs e)
        {
            switch (tbConsole.Text.ToUpper())
            {
                case "CONFIG ADMINMODE ON":
                case "CONFIG NORMALMODE OFF":
                case "CONFIG MODE ADMIN":
                    {
                        ChangeFormDesign(true);
                        break;
                    }

                case "CONFIG ADMINMODE OFF":
                case "CONFIG NORMALMODE ON":
                case "CONFIG MODE NORMAL":
                    {
                        ChangeFormDesign(false);
                        break;
                    }

                default:
                    {
                        
                    }
                    break;
            }
            tbConsole.Clear();
        }

        private void ChangeFormDesign(bool Admin)
        {
            if (Admin)
            {
                administrador_TSMI.Enabled = true;
                administrador_TSMI.Visible = true;
                this.Text = adminModeText;
                this.MenuBar.BackgroundImage = Gerador_de_Email.Properties.Resources.red_wall;
                this.pictureBox1.Image = Gerador_de_Email.Properties.Resources.red_silk_background;
                this.btClean.BackgroundImage = Gerador_de_Email.Properties.Resources.red_wall;
                this.btGenerate.BackgroundImage = Gerador_de_Email.Properties.Resources.red_wall;
                this.btCopy.BackgroundImage = Gerador_de_Email.Properties.Resources.red_wall;
            }
            else
            {
                administrador_TSMI.Enabled = false;
                administrador_TSMI.Visible = false;
                this.Text = normalModeText;
                this.MenuBar.BackgroundImage = Gerador_de_Email.Properties.Resources.big_bar2;
                this.pictureBox1.Image = Gerador_de_Email.Properties.Resources.abstract_blue_backgrounds;
                this.btClean.BackgroundImage = Gerador_de_Email.Properties.Resources.big_bar;
                this.btGenerate.BackgroundImage = Gerador_de_Email.Properties.Resources.big_bar;
                this.btCopy.BackgroundImage = Gerador_de_Email.Properties.Resources.big_bar;
            }
        }
    }
}
