using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public  class ContaCorrente
    {
        public double Saldo;
        public string? Status;
        public string Saque(double value)
        {
            if (Saldo < value)
                return Status= "Saldo insuficiente";
            else
                Saldo = Saldo-value;
                return Status = "Operação Realizada com sucesso!";
        }
    }
}
