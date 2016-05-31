using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Email.assets
{
    class FileManager
    {
        public static string[] Read(string path)
        {
            string[] lines = null;
            try {
                //byte[] bytes = null;
                lines = System.IO.File.ReadAllLines(path);
                //for (int i = 0; i < lines.Length; i++){
                //    bytes = Encoding.Default.GetBytes(lines[i]);
                //    lines[i] = Encoding.UTF8.GetString(bytes);
                //}
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Arquivo '" + path + "' não encontrado!");
            }
            return lines;
        }

        public static void Write(string text, string path)
        {
            try
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(path, true))
                {
                    file.Write(text);
                    file.Close();
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Arquivo '" + path + "' não encontrado!");
            }
        }

        public static void Write(string txt, string path, bool log)
        {
            if (log || !log)
            {
                string text = "\r\nEntrada de log : " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString() + "\r\n" + txt;
                try
                {
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(path, true))
                    {
                        file.Write(text);
                        file.Close();
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Arquivo '" + path + "' não encontrado!");
                }
            }
        }

        public static string CapitalizarNome(string nome)
        {
            string[] excecoes = new string[] { "e", "de", "da", "das", "do", "dos" };
            var palavras = new Queue<string>();
            foreach (var palavra in nome.Split(' '))
            {
                if (!string.IsNullOrEmpty(palavra))
                {
                    var emMinusculo = palavra.ToLower();
                    var letras = emMinusculo.ToCharArray();
                    if (!excecoes.Contains(emMinusculo)) letras[0] = char.ToUpper(letras[0]);
                    palavras.Enqueue(new string(letras));
                }
            }
            return string.Join(" ", palavras);
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

    }
}
