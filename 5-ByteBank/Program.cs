using _5_ByteBank;
{
    Cliente Rodrigo = new Cliente();
    Rodrigo.profissão = "Gerente";
    Rodrigo.nome = "Rodrigo Aquino";
    Rodrigo.cpf = "575.902.108-70";
    Rodrigo.cvv = "143"; 

    ContaCorrente conta = new ContaCorrente();

    conta.titular = Rodrigo;
    conta.agencia = 863;
    conta.saldo = 19430.00;
    conta.numero = 2937651;

    Console.WriteLine("nome do titular: " + Rodrigo.nome);
    Console.WriteLine("cpf:" + conta.titular.cpf);
    Console.WriteLine("profissão: " + Rodrigo.profissão);
    Console.WriteLine("seu saldo é de R$" + conta.saldo);
    Console.WriteLine("seu cvv é: " + Rodrigo.cvv);
    Console.WriteLine("agencia: " + conta.agencia);



    Console.ReadLine();
}
