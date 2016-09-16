using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Email.assets
{
    static class Password
    {
        public const string validTXT = "abcdefghijklmnopqrstuvwxyz";
        public const string validNUM = "1234567890";
        public const string validESP = "!?@#$:;*-+";

        public static string CreatePassword(this string senha, int str, int num, int esp, bool ordered)
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            if (str > 0)
            {
                while (0 < str--) { res.Append(validTXT[rnd.Next(validTXT.Length)]); }
            }
            if (num > 0)
            {
                while (0 < num--) { res.Append(validNUM[rnd.Next(validNUM.Length)]); }
            }
            if (esp > 0)
            {
                while (0 < esp--) { res.Append(validESP[rnd.Next(validESP.Length)]); }
            }
            senha = (ordered) ? res.ToString() : res.ToString().RandomizeString();
            return senha;
        }

        public static string CreatePassword(this string senha, int str, int num, int esp, bool ordered, string manualESP)
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            if (str > 0)
            {
                while (0 < str--) { res.Append(validTXT[rnd.Next(validTXT.Length)]); }
            }
            if (num > 0)
            {
                while (0 < num--) { res.Append(validNUM[rnd.Next(validNUM.Length)]); }
            }
            if (esp > 0)
            {
                while (0 < esp--) { res.Append(manualESP[rnd.Next(manualESP.Length)]); }
            }
            senha = (ordered) ? res.ToString() : res.ToString().RandomizeString();
            return senha;
        }

        /// <summary>
        ///  Randomize chars from a string.
        /// </summary>
        /// <param text=string></param>
        /// <returns>string</returns>
        public static string RandomizeString(this string txt)
        {
            // The random number sequence.
            Random num = new Random();

            // Create new string from the reordered char array.
            string rand = new string(txt.ToCharArray().
                OrderBy(s => (num.Next(2) % 2) == 0).ToArray());

            return rand;
        }
    }
}
