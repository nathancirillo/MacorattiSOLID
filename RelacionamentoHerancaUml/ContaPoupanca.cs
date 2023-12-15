using System;

namespace RelacionamentoHerancaUml
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }
        public decimal Rendimentos { get; set; }

        public void CreditoJuros(decimal valor)
        {
            this.Deposito(valor);
        }
    }
}
