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

namespace Gerador_de_Email.forms
{
    public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
            foreach (string s in FileManager.Read("data/log.denner"))
            {
                tbRelaLog.Text += s + "\r\n";
            }
        }

        private void btFechaRelat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRelaLog.Text);
        }
    }
}
