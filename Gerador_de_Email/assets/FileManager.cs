using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Gerador_de_Email.assets
{
    class FileManager
    {
        public static string[] Read(string path)
        {
            string[] lines = null;
            try
            {
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

        public static void WriteXML(string path, ref List<User> usuarios, bool reset)
        {
            string filePath = Path.GetFullPath(path);
            try
            {
                if (!reset)
                {
                    if (File.Exists(filePath))
                    {
                        FileStream fsOpen = new FileStream(filePath, FileMode.Open);
                        XmlSerializer xsOpen = new XmlSerializer(typeof(List<User>));
                        List<User> usr = (List<User>)xsOpen.Deserialize(fsOpen);
                        usr.AddRange(usuarios);
                        fsOpen.Close();
                        File.Delete(filePath);
                        FileStream fsWrite = new FileStream(filePath, FileMode.CreateNew);
                        XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                        xs.Serialize(fsWrite, usr);
                        fsWrite.Close();
                    }
                    else
                    {
                        FileStream fsWrite = new FileStream(filePath, FileMode.CreateNew);
                        XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                        xs.Serialize(fsWrite, usuarios);
                        fsWrite.Close();
                    }
                }
                else
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    FileStream fsWrite = new FileStream(filePath, FileMode.CreateNew);
                    XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                    xs.Serialize(fsWrite, usuarios);
                    fsWrite.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static void ReadXML(string path, ref List<User> usuarios)
        {
            string filePath = Path.GetFullPath(path);
            try
            {
                if (File.Exists(filePath))
                {
                    FileStream fsOpen = new FileStream(filePath, FileMode.Open);
                    XmlSerializer xsOpen = new XmlSerializer(typeof(List<User>));
                    usuarios = (List<User>)xsOpen.Deserialize(fsOpen);
                    fsOpen.Close();
                }
                else
                {
                    MessageBox.Show("Não há arquivo para ser carregado!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
