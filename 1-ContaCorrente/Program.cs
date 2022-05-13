{
    ContaCorrente contadajennifer = new ContaCorrente();

    contadajennifer.titular = ("Jennifer");
    Console.WriteLine("Nome do titular;" + contadajennifer.titular);
    contadajennifer.saldo = 1000.00;
    Console.WriteLine("Saldo da conta R$"+ contadajennifer.saldo);
    contadajennifer.agencia = 863;
    Console.WriteLine("Agencia:" + contadajennifer.agencia);
    contadajennifer.numero = 6929671;
    Console.WriteLine("Numero: " + contadajennifer.numero);

    contadajennifer.saldo += 200;
    Console.WriteLine("Saldo da conta R$" + contadajennifer.saldo);
    
    
    
    
    
    
    Console.ReadLine();
}