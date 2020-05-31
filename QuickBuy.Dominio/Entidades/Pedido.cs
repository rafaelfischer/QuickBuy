using System;
using System.Collections.Generic;
using System.Linq;

using QuickBuy.Dominio.ObjedoDeValor;

namespace QuickBuy.Dominio.Entidades {
	public class Pedido : Entidade {
		public int Id { get; set; }
		public DateTime DataPedido { get; set; }
		public DateTime DataPrevisaoEntrega { get; set; }
		public string CEP { get; set; }
		public string Estado { get; set; }
		public string Cidade { get; set; }
		public string EnderecoCompleto { get; set; }
		public int NumeroEndereco { get; set; }

		public int UsuarioId { get; set; }
		public virtual Usuario Usuario { get; set; }

		public int FormaPagamentoId { get; set; }
		public virtual FormaPagamento FormaPagamento { get; set; }

		/// <summary>
		/// Pedido deve ter pelo menos um Item
		/// </summary>
		public virtual ICollection<ItemPedido> ItensPedidos { get; set; }

		public override void Validate() {
			LimparMensagensValidacao();

			if(!ItensPedidos.Any()) {
				AdicionarMensagem("Pedido não pode ser vazio");
			}

			if(string.IsNullOrEmpty(CEP)) {
				AdicionarMensagem("CEP não pode ser vazio");
			}

			if(FormaPagamentoId == 0) {
				AdicionarMensagem("Não foi informado uma forma de pagamento");
			}
		}
	}
}
