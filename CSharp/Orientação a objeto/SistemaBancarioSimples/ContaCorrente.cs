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
        public string Transacao(double saque)
        {
            if (Saldo < saque)
                return Status= "Saldo insuficiente";
            else
                Saldo = Saldo-saque;
                return Status = "Operação Realizada com sucesso!";
        }
    }
}
