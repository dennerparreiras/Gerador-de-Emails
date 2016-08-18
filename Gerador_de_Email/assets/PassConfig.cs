using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Email.assets
{
    [Serializable]
    public class PassConfig
    {
        public string charString { get; set; }
        public int letters { get; set; }
        public int numbers { get; set; }
        public int espChars { get; set; }
        public bool randomChars { get; set; }

        public PassConfig()
        {
            this.charString = "!?@#$:;*-+";
            this.letters = 2;
            this.numbers = 4;
            this.espChars = 0;
            this.randomChars = false;
        }
        public PassConfig(string a, int b, int c, int d, bool e)
        {
            this.charString = a;
            this.letters = b;
            this.numbers = c;
            this.espChars = d;
            this.randomChars = e;
        }
    }
}