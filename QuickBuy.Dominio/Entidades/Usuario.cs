﻿using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id{ get; set; }
        public string Email{ get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um Usuário pode possuir NENHUM ou MUITOS Pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarMensagem("Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarMensagem("Senha não foi informado");
        }
    }
}
