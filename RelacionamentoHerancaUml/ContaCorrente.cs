namespace RelacionamentoHerancaUml
{
    public class ContaCorrente : Conta
    {
        public decimal Limite { get; set; }

        public void DescontoJuros(decimal juros)
        {
            this.Saque(juros);
        }
    }
}
