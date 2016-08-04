using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador_de_Email.assets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gerador_de_Email
{
    public class CustomBinarySerializer<T>
    {
        public bool SerializeToBinaryFile(T data, string path) //@"data/parameters.data"
        {
            try
            {
                if (data != null)
                {
                    FileStream streamFile = new FileStream(path, FileMode.Create);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(streamFile, data);
                    streamFile.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public T DeserializeFromBinaryFile(string path)
        {
            T retorno = default(T);
            try
            {
                if (File.Exists(path))
                {
                    FileStream streamFile = new FileStream(path, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    retorno = (T)formatter.Deserialize(streamFile);
                    streamFile.Close();
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Falha ao deserializar o arquivo.");
            }
            return retorno;
        }
    }
}
