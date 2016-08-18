using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Email.assets
{
    [Serializable]
    public class Parameters
    {
        public string listDomain { get; set; }
        public string listPlace { get; set; }
        public string XMLFile { get; set; }
        public string LogFile { get; set; }
        public string icon { get; set; }
        public bool startMinimized { get; set; }
        public bool startAdmMode { get; set; }
        public bool deleteUserButton { get; set; }
        public bool generateEnterButton { get; set; }

        public ADHelper.ADConfig configAD { get; set; }
        public PassConfig passwordConfig { get; set; }

        public Parameters()
        {
            this.listDomain = @"data/dominios.denner";
            this.listPlace = @"data/local.denner";
            this.XMLFile = @"data/lista.xml";
            this.LogFile = @"data/log.denner";
            this.icon = @"data/app.ico";
            this.startMinimized = false;
            this.startAdmMode = false;
            this.deleteUserButton = false;
            this.generateEnterButton = false;
            this.passwordConfig = new PassConfig();
            this.configAD = new ADHelper.ADConfig();
        }
    }
}
