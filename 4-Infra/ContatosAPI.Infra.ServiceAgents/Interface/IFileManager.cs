using System;
using System.Collections.Generic;
using System.Text;

namespace ContatosAPI.Infra.ServiceAgents.Interface
{
    public interface IFileManager
    {
        int EscreverNoArquivo(string Conteudo, string Caminho);

        int LerArquivo(string Caminho, string Arquivo);

    }
}
