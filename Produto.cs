using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO_TarefaLojaProdutos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaPreco(string etiquetaPreco)
        {
            return etiquetaPreco;

        }

        public override string ToString()
        {
            return Nome + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
