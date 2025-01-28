namespace mvc1.Models
{
    public class Produto
    {
        public Produto()
        {}
        
        public Produto (string nome, string categoria,decimal preco)
        {
                    this.Nome = nome;
                    this.Categoria = categoria;
                    this.Preco= preco;
        }

        public Produto (int id, string nome, string categoria,decimal preco)
        {
                    this.ProdutoId = id;
                    this.Nome = nome;
                    this.Categoria = categoria;
                    this.Preco= preco;
        }

        public int ProdutoId {get; set;}
        public string? Nome {get; set;}
        public string? Categoria {get; set;}
        public decimal Preco {get; set;}
    }
}