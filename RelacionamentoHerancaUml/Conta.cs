namespace RelacionamentoHerancaUml
{
    public class Conta
    { 
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public void Deposito(decimal valor)
        {
            Saldo += valor; 
        }

        public void Saque(decimal valor)
        {
            Saldo -= valor; 
        }
    }
}
