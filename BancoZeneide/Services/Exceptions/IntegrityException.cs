using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string mensagem) : base(mensagem)
        {

        }
    }
}
