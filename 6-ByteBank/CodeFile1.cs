//using _6_ByteBank;

namespace _6_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int agencia { get; set; }
        public int numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get { return _saldo; }
            set { if (value < 0) { return; } _saldo = value; }
        }
        public void depositar(double valor)
        { _saldo += valor; }


        public bool transferencia(double valor, ContaCorrente contadestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contadestino.depositar(valor);
                return true;
            }



        }

    }
}
    
        
        




