using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config {
	public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido> {
		public void Configure(EntityTypeBuilder<ItemPedido> builder) {
			builder.HasKey(u => u.Id);

			builder
				.Property(i => i.Quantidade)
				.IsRequired();

			builder
				.HasOne(p => p.Pedido)
				.WithMany(i => i.ItensPedidos);

			builder.HasOne(p => p.Produto);
		}
	}
}
