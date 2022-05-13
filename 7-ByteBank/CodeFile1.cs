//using _6_ByteBank;

namespace _7_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacional { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        
       public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciaNaoPermitidas { get; private set; }
        
        public int Agencia { get; }
        public int Numero {get;}  
     
        private double _saldo = 100;

        public double Saldo
        {
            get { return _saldo; }
            set { if (value < 0) { return; } _saldo = value; }
        }
       
        public ContaCorrente(int agencia, int numero)
        {
          
            if (agencia <= 0) 
            {
                throw new ArgumentException("O argumento Agencia deve ser maior que 0.",nameof(agencia));
            }
            
           if (numero <= 0)
            {
                throw new ArgumentException("O Argumento Número deve ser maior que 0.", nameof(numero));
            }
           
           
            Agencia = agencia;  
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacional = 30 / TotalDeContasCriadas;
        }
        
        
        
        
        public void sacar(double valor)
        {
            if (valor < 0)
            throw new ArgumentException("valor invalido para o saque.", nameof(valor));
            
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;
            
        }
        
        public void depositar(double valor)
        { _saldo += valor; }
        public void transferir(double valor, ContaCorrente contadestino)
        {
            if (valor < 0)
                throw new ArgumentException("valor invalido para a transferencia.", nameof(valor));
            
            try
            { 
                Sacar(valor); 
            }
            catch(SaldoInsuficienteException ex)
            {
                
                ContadorTransferenciaNaoPermitidas++;
                throw new OperaçãoFinanceiroException("Operação não realizada ", ex);
            }
                
                contadestino.depositar(valor);

        }
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }







    }
}
    
        
        




