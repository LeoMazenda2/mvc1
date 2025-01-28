using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[] 
        {
            new Produto{ ProdutoId=10, Nome="Caneta",Categoria="Material", Preco=2.0M},
            new Produto{ ProdutoId=20, Nome="Borracha",Categoria="Material", Preco=1.5M},
            new Produto{ ProdutoId=30, Nome="Estojo",Categoria="Material", Preco=3.0M}

        };
        public IEnumerable<Produto> Produtos { get => produtos;}
    }
}