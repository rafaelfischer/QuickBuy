using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjedoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto
        {
            get { return Id == (int)TipoFormaPagamentosEnum.Boleto; }
        }
        public bool IsCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentosEnum.CartaoCredito; }
        }
        public bool IsDeposito
        {
            get { return Id == (int)TipoFormaPagamentosEnum.Deposito; }
        }
        public bool IsNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentosEnum.NaoDefinido; }
        }
    }
}
