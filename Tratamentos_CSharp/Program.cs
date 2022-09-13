using System;
using System.IO;

namespace Tratamentos_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            try
            {
                Metodo();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir 0");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Erro");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("==========================");

            CarregarConta();

            Console.ReadKey();
        }
        public static void Metodo()
        {
            TestaDivisao(0);
        }

        public static void TestaDivisao(int divisor)
        {          
            int resultado = Dividir(10, divisor);

            Console.WriteLine("O resultado da divisão entre 10 e " + divisor + " é " + resultado);
        }
        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch  (Exception) //Exception:
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor = " + divisor);
                
                throw; //Busca novas Exceções anteriores;
            }
        }
        private static void CarregarConta()
        {
            LeitorDeArquivo leitor = null;
            
            try
            {
                using (leitor = new LeitorDeArquivo("contas.txt"))
                {
                    leitor.LerArquivo();
                    leitor.LerArquivo();
                    leitor.LerArquivo();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IOException, capturada e tratada");
            }
            finally //Executado mesmo sem tratamento;
            {
                if (leitor != null)
                {
                    leitor.Dispose();
                }
            }
        }
    }
}
