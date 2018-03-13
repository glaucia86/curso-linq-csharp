using System;
using System.Collections.Generic;

namespace Loja.Domain.Entities
{
    public class Produto
    {
        private List<Produto> _produtos;

        public Produto()
        {
            _produtos = new List<Produto>();    
        }

        //Método para Listar Produtos:
        public List<Produto> ListarProdutos()
        {
            _produtos.Add(new Produto() { IdProduto = Guid.NewGuid(), Nome = "Banana", Quantidade = 2, Valor = 5, DataVencimento = DateTime.Now.AddDays(5) });
            _produtos.Add(new Produto() { IdProduto = Guid.NewGuid(), Nome = "Maçã", Quantidade = 10, Valor = 15, DataVencimento = DateTime.Now.AddDays(3) });
            _produtos.Add(new Produto() { IdProduto = Guid.NewGuid(), Nome = "Pêra", Quantidade = 3, Valor = 23, DataVencimento = DateTime.Now.AddDays(4) });
            _produtos.Add(new Produto() { IdProduto = Guid.NewGuid(), Nome = "Melancia", Quantidade = 1, Valor = 8, DataVencimento = DateTime.Now.AddDays(6) });
            _produtos.Add(new Produto() { IdProduto = Guid.NewGuid(), Nome = "Laranja", Quantidade = 12, Valor = 11, DataVencimento = DateTime.Now.AddDays(2) });
            _produtos.Add(new Produto() { IdProduto = Guid.NewGuid(), Nome = "Manga", Quantidade = 6, Valor = 3, DataVencimento = DateTime.Now.AddDays(1) });
            _produtos.Add(new Produto() { IdProduto = Guid.NewGuid(), Nome = "Coco", Quantidade = 3, Valor = 9, DataVencimento = DateTime.Now.AddDays(2) });

            return _produtos;
        }

        public Guid IdProduto { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataVencimento { get; set; }

        public int Quantidade { get; set; }

    }
}
