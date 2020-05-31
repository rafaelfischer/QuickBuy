﻿using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios {
	public class PedidoRepositorio : BaseRespositorio<Pedido>, IPedidoRepositorio {
		public PedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto) {
		}
	}
}
