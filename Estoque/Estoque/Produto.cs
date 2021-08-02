using System.Globalization;

namespace Estoque {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {

        }
        
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            if (quantidade > 0) {
                Quantidade += quantidade;
            }
        }

        public void RemoverProdutos(int quantidade) {
            if (quantidade > 0 && Quantidade > quantidade) {
                Quantidade -= quantidade;
            }
        }

        public override string ToString() {
            return $"{Nome} (R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}), " +
                $"{Quantidade} unidades, Total em estoque: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
