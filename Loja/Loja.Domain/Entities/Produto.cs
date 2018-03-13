using System;

namespace Loja.Domain.Entities
{
    public class Produto
    {
        public Guid IdProduto { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataVencimento { get; set; }

        public int Quantidade { get; set; }
    }
}
