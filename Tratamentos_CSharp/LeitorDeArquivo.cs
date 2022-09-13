using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tratamentos_CSharp
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get;  }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo " + arquivo);
        }

        public string LerArquivo()
        {
            Console.WriteLine("Lendo arquivo");
            //Lançando uma exceção: 
            //throw new IOException();    //Trabalha com arquivos, entrada e saída;
            return "Linha do arquivo";
        }
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo");
        }
    }
}
