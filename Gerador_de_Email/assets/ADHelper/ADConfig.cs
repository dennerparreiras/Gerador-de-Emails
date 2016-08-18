using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Email.assets.ADHelper
{
    [Serializable]
    public class ADConfig
    {
        //LDAPPath, LDAPUser, LDAPPassword, LDAPDomain
        public string LDAPPath { get; set; }
        public string LDAPUser { get; set; }
        public string LDAPPassword { get; set; }
        public string LDAPDomain { get; set; }

        public ADConfig(string path, string user, string passwd, string domain)
        {
            this.LDAPPath = path;
            this.LDAPUser = user;
            this.LDAPPassword = passwd;
            this.LDAPDomain = domain;
        }
        public ADConfig()
        {
            this.LDAPPath = " ";
            this.LDAPUser = " ";
            this.LDAPPassword = " ";
            this.LDAPDomain = " ";
        }
    }
}
