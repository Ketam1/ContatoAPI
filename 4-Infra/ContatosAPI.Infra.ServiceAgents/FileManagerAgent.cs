using ContatosAPI.Infra.ServiceAgents.Interface;
using System;
using System.IO;

namespace ContatosAPI.Infra.ServiceAgents
{
    public class FileManagerAgent : IFileManager
    {
        public int EscreverNoArquivo(string Conteudo, string Caminho, string Arquivo)
        {
            StreamWriter Escritor = new StreamWriter(Caminho + Arquivo);
            try{
                Escritor.Write(Conteudo);
                return 0;
            }
            catch(IOException)
            {
                return 1;
            }

        }

        public string LerArquivo(string Caminho, string Arquivo)
        {
            
            try
            {
                string ConteudoDoArquivo = File.ReadAllText(Caminho + Arquivo);
                return ConteudoDoArquivo;
            }
            catch (IOException)
            {
                return "ERROR";
            }
        }
    }

}
