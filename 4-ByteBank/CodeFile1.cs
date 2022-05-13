public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100.00;
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
    public void depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool transferencia(double valor, ContaCorrente contadestino)
    {
        if (this.saldo < valor)
        {
            return false; 
        }
         else
        {
            this.saldo -= valor;
            contadestino.depositar(valor );
            return true; 
        }
                
                
    }
    
    
    
    



}







