namespace _6_ByteBank
{
   class program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();
            cliente.nome = "Agnes";
            cliente.cpf = "371.791.988-45";
            cliente.profissão = "Estudante";

            conta.Saldo = -15;
            conta.Titular = cliente;
            
            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }

      
   
    
    }

}


