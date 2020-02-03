using QuickBuy.Dominio.ObjedoDeValor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int IdFormaPagamento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um Item de pedido
        /// ou muitos itens de pedido
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedidos.Any())
            {
                AdicionarMensagem("Pedido não pode ser vazio");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarMensagem("CEP não pode ser vazio");
            }
        }
    }
}
