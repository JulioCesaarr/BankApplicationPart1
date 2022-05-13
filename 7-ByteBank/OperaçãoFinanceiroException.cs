using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    public class OperaçãoFinanceiroException : Exception
    {
        public OperaçãoFinanceiroException()
        {

        }
        public OperaçãoFinanceiroException(string mensagem)
              : base(mensagem)
        {

        }
        public OperaçãoFinanceiroException(string mensagem, Exception ExcecaoInterna)
            : base(mensagem, ExcecaoInterna)
        {

        }
            
    }
}
