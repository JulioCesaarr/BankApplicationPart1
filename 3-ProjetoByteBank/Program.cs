{
 ContaCorrente ContaDoAguinaldo =  new ContaCorrente();
    ContaDoAguinaldo.titular = ("aguinaldo");
    ContaDoAguinaldo.saldo = 100.00;
    ContaDoAguinaldo.agencia = 888;
    ContaDoAguinaldo.numero = 2968189;

    ContaCorrente ContaDoAguinaldoaquino = new ContaCorrente();
    ContaDoAguinaldoaquino.titular = ("aguinaldo");
    ContaDoAguinaldoaquino.saldo = 100.00;
    ContaDoAguinaldoaquino.agencia = 888;
    ContaDoAguinaldoaquino.numero = 2968189;

    if (ContaDoAguinaldo.saldo >= 100)
    {
        ContaDoAguinaldo.saldo -= 100;
    } 




    Console.ReadLine(); 
}