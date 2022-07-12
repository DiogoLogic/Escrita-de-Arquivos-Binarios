using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Escrita_de_arquivos_Binários
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando Arquivo
            FileStream stream = new FileStream("C:\\estudos c#\\meuarquivo.Diogo",FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, 120);
            encoder.Serialize(stream, "Diogo Felipe");
            stream.Close();
        }
    }
}
