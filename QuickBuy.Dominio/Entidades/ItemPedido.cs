﻿namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarMensagem("Não foi identificado qual a referência do produto");

            if (Quantidade == 0)
                AdicionarMensagem("Quantidade não foi informado");
        }
    }
}
