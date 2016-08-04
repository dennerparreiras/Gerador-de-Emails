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
            Config.listDomain = tbDominio.Text;
            Config.listPlace = tbLocal.Text;
            Config.XMLFile = tbUsuario.Text;
            Config.LogFile = tbLog.Text;
            Config.icon = tbIcone.Text;
            Config.startMinimized = checkMinim.Checked;
            Config.startAdmMode = checkAdm.Checked;
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
