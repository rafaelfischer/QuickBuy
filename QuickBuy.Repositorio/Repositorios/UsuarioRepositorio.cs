using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios {
	public class UsuarioRepositorio : BaseRespositorio<Usuario>, IUsuarioRepositorio {
		public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto) {
		}
	}
}
