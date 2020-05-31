using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Web.Controllers {
	[Route("api/[controller]")]
	public class ProdutoController : ControllerBase {

		private readonly IProdutoRepositorio _produtoRepositorio;
		public ProdutoController(IProdutoRepositorio produtoRepositorio) {
			this._produtoRepositorio = produtoRepositorio;
		}

		[HttpGet]
		public IActionResult Get(){
			try {
				return Ok(this._produtoRepositorio.ObterTodos());
			}
			catch(Exception ex) {
				return BadRequest(ex.ToString());
			}
		}

		[HttpPost]
		public IActionResult Post([FromBody] Produto produto) {
			try {
				if(produto is null) {
					throw new ArgumentNullException(nameof(produto));
				}

				this._produtoRepositorio.Adicionar(produto);
				return Created("api/produto", produto);
			}
			catch(Exception ex) {
				return BadRequest(ex.ToString());
			}
		}

		[HttpPost]
		public IActionResult Put([FromBody] Produto produto) {
			try {
				if(produto is null) {
					throw new ArgumentNullException(nameof(produto));
				}

				this._produtoRepositorio.Atualizar(produto);
				return Created("api/produto", produto);
			}
			catch(Exception ex) {
				return BadRequest(ex.ToString());
			}
		}
	}
}
