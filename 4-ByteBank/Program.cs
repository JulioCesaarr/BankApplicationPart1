{
    ContaCorrente ContaDojoão = new ContaCorrente();
    ContaDojoão.titular = "João";

    Console.WriteLine("seu saldo é de: " + ContaDojoão.saldo);
    bool resultadosaque = ContaDojoão.Sacar(909);
    Console.WriteLine( ContaDojoão.saldo);
    Console.WriteLine(resultadosaque);

    ContaDojoão.depositar(809);
    
    Console.WriteLine(ContaDojoão.saldo);

    ContaCorrente contadoPaulo = new ContaCorrente();  
    contadoPaulo.titular = "paulo";

    Console.WriteLine("saldo do joão " + ContaDojoão.saldo);
    Console.WriteLine("saldo do paulo " + contadoPaulo.saldo);


   bool resultadotranferencia =  ContaDojoão.transferencia(909, contadoPaulo);
  
    Console.WriteLine("saldo do joão " + ContaDojoão.saldo );
    Console.WriteLine("saldo do paulo " + contadoPaulo.saldo);

    Console.WriteLine("resultado da transferencia: " + resultadotranferencia);

    contadoPaulo.transferencia(900, ContaDojoão);
    Console.WriteLine("saldo do joão " + ContaDojoão.saldo);
    Console.WriteLine("saldo do paulo " + contadoPaulo.saldo);
   
  

    Console.ReadLine();
}