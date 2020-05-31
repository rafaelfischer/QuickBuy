﻿using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios {
	public class ProdutoRepositorio : BaseRespositorio<Produto>, IProdutoRepositorio {
		public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto) {
		}
	}
}
