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

namespace Gerador_de_Email
{
    public partial class MainForm : Form
    {
        static User usuario = null;

        static string[] dataSourceDom;
        static string[] dataSourceLoc;

        static bool checkE = false;
        static bool checkA = false;
        static bool lastExists = false;
        static bool lastCancel = false;
        const string log = "data/log.denner";
        const string dom = "data/dominios.denner";
        const string loc = "data/local.denner";

        public MainForm()
        {
            InitializeComponent();
            dataSourceDom = FileManager.Read(dom);
            dataSourceLoc = FileManager.Read(loc);
            
            // Sort the array
            FileManager.Quicksort(dataSourceDom, 0, dataSourceDom.Length - 1);
            FileManager.Quicksort(dataSourceLoc, 0, dataSourceLoc.Length - 1);

            cbEmail.DataSource = dataSourceDom;
            cbLocal.DataSource = dataSourceLoc;
        }

        public void PrintUserData()
        {
            FileManager.Write(usuario.ToString(), log, true);
            tbReturn.Text += usuario.ToString();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            lastCancel = false;
            lastExists = false;
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbReturn.Text);
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado por Denner Parreiras Aleixo\r\nNo dia 30/05/2016.");
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (VerifyFields())
            {
                //(string nome, string usuario, string dominio, string local, string cargo)
                usuario = new User(FileManager.CapitalizarNome(tbNome.Text), tbEmail.Text, cbEmail.Text, cbLocal.Text, tbCargo.Text);
                PrintUserData();
            }
            ClearFields();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            checkE = checkEmail.Checked;

            if (checkEmail.Checked)
            {
                tbEmail.Enabled = ((checkE) ? true : false);
            }
            else
            {
                tbEmail.Enabled = ((checkE) ? true : false);
            }
        }

        private void consultarLogMenuItem_Click(object sender, EventArgs e)
        {
            new logForm().Show();
        }

        private void btUserExists_Click(object sender, EventArgs e)
        {
            if (!lastExists)
            {
                lastExists = true;
                string msg = "---> O usuário acima já existe!\r\n";
                tbReturn.Text += msg + "\r\n";
                FileManager.Write(msg, log);
            }
            else
            {
                MessageBox.Show("Você já usou esta opção!");
            }
        }

        private void btCancelReg_Click(object sender, EventArgs e)
        {
            if (!lastCancel)
            {
                lastCancel = true;
                string msg = "---> A criação do usuário acima foi cancelada! \r\n";
                tbReturn.Text += msg;
                FileManager.Write(msg, log);
            }
            else
            {
                MessageBox.Show("Você já usou esta opção!");
            }
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            checkA = !checkA;
            groupActions.Enabled = ((checkA) ? true : false);
            btHide.Text = ((checkA) ? "Ocultar Opções de Log" : "Exibir Opções de Log");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
