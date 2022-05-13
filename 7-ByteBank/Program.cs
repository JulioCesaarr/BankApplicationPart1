namespace _7_ByteBank
{
    class program
    {
        static void Main(string[] args)
        {
            try { CarregarContas(); }

            catch
            {
                Console.WriteLine("Catch No Metodo Main");
            }
            Console.WriteLine("Execução finalizada, aperte ENTER");
            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("Teste.txt"))
            {
                leitor.LerProximaLinha();
            }
            
            
            
        //    LeitorDeArquivo leitor = null;
        //    try
        //    {
        //        leitor = new LeitorDeArquivo("contas.txt");

        //        leitor.LerProximaLinha();
        //        leitor.LerProximaLinha();
        //        leitor.LerProximaLinha();

                
        //    }
        //    catch(IOException)
        //    {
        //        Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
        //    }
        //    finally
        //    {
        //        if(leitor != null)
        //        {
        //            leitor.Fechar();
        //        }
        //    }
            
        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                //conta1.transferir(10000, conta2);
                conta1.sacar(10000);
            }
            catch (OperaçãoFinanceiroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                // Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

            }
            //Metodo();

            
        }
            private static void Metodo()
            {
                TestaDivisao(1);
            }

            private static void TestaDivisao(int divisor)
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }

            private static int Dividir(int numero, int divisor)
            {
                try
                {
                    return numero / divisor;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                    throw;
                }
            }
        


}   }


    

