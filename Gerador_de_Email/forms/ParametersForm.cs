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
using System.IO;

namespace Gerador_de_Email.forms
{
    public partial class ParametersForm : Form
    {
        static Parameters Config = new Parameters();

        public ParametersForm(ref Parameters param)
        {
            Config = param;

            InitializeComponent();
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;

            tbDominio.Text = Config.listDomain;
            tbLocal.Text = Config.listPlace;
            tbUsuario.Text = Config.XMLFile;
            tbLog.Text = Config.LogFile;
            tbIcone.Text = Config.icon;
            checkMinim.Checked = Config.startMinimized;
            checkAdm.Checked = Config.startAdmMode;
            checkDeleteUserBt.Checked = Config.deleteUserButton;
            checkGenerateEnter.Checked = Config.generateEnterButton;

            tbCharEspecial.Text = Config.passwordConfig.charString;
            numLetras.Value = Config.passwordConfig.letters;
            numNumeros.Value = Config.passwordConfig.numbers;
            numCharEspeciais.Value = Config.passwordConfig.espChars;
            rbRandom.Checked = Config.passwordConfig.randomChars;

            this.Visible = false;
        }

        private void ParametersForm_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            this.Visible = true;
        }

        private void Verify(string ShortFilePath)
        {
            try
            {
                string fullPath = Path.GetFullPath(ShortFilePath);
                bool exists = File.Exists(fullPath);
                string mensage = (exists) ? "O arquivo indicado existe!" : "O arquivo indicado não existe!";
                object type = (exists) ? MessageBoxIcon.Information : MessageBoxIcon.Stop;
                MessageBox.Show(mensage + "\r\n\r\n" + fullPath, "Verificação de parâmetros do sistema", MessageBoxButtons.OK, (MessageBoxIcon)type);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Houve uma falha na configuração dos parâmetros:\r\n\r\n" + erro.Message, "Verificação de parâmetros do sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja salvar os dados e sair?", "Salvar e sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Config.listDomain = tbDominio.Text;
                    Config.listPlace = tbLocal.Text;
                    Config.XMLFile = tbUsuario.Text;
                    Config.LogFile = tbLog.Text;
                    Config.icon = tbIcone.Text;
                    Config.startMinimized = checkMinim.Checked;
                    Config.startAdmMode = checkAdm.Checked;
                    Config.deleteUserButton = checkDeleteUserBt.Checked;
                    Config.generateEnterButton = checkGenerateEnter.Checked;

                    Config.passwordConfig.charString = tbCharEspecial.Text;
                    Config.passwordConfig.letters = (int) numLetras.Value;
                    Config.passwordConfig.numbers = (int) numNumeros.Value;
                    Config.passwordConfig.espChars = (int) numCharEspeciais.Value;
                    Config.passwordConfig.randomChars = rbRandom.Checked;

                    new CustomBinarySerializer<Parameters>().SerializeToBinaryFile(Config, @"data/config.data");

                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Houve uma falha ao tentar salvar!");
                    this.Dispose();
                }
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja sair sem salvar os dados", "Sair sem salvar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void VerificarDominio(object sender, EventArgs e)
        {
            Verify(tbDominio.Text);
        }

        private void VerificarLocais(object sender, EventArgs e)
        {
            Verify(tbLocal.Text);
        }

        private void VerificarUsuarios(object sender, EventArgs e)
        {
            Verify(tbUsuario.Text);
        }

        private void VerificarLog(object sender, EventArgs e)
        {
            Verify(tbLog.Text);
        }

        private void VerificarIcone(object sender, EventArgs e)
        {
            Verify(tbIcone.Text);
        }

        private void AllDefault(object sender, EventArgs e)
        {
            tbDominio.Text = @"data/dominios.denner";
            tbLocal.Text = @"data/local.denner";
            tbUsuario.Text = @"data/lista.xml";
            tbLog.Text = @"data/log.denner";
            tbIcone.Text = @"data/app.ico";
        }

        private void DefaultDominio(object sender, EventArgs e)
        {
            tbDominio.Text = @"data/dominios.denner";
        }

        private void DefaultLocal(object sender, EventArgs e)
        {
            tbLocal.Text = @"data/local.denner";
        }

        private void DefaultUsuarios(object sender, EventArgs e)
        {
            tbUsuario.Text = @"data/lista.xml";
        }

        private void DefaultLog(object sender, EventArgs e)
        {
            tbLog.Text = @"data/log.denner";
        }

        private void DefaultIcone(object sender, EventArgs e)
        {
            tbIcone.Text = @"data/app.ico";
        }

        private void ResetPassConfig(object sender, EventArgs e)
        {
            PassConfig aux = new PassConfig();
            tbCharEspecial.Text = aux.charString;
            numLetras.Value = aux.letters;
            numNumeros.Value = aux.numbers;
            numCharEspeciais.Value = aux.espChars;
            rbRandom.Checked = aux.randomChars;
            rbOrdered.Checked = !aux.randomChars;
        }
    }
}
