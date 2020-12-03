using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO_TarefaLojaProdutos.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataProducao { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string nome, double preco, DateTime dataProducao) : base(nome, preco)
        {
            DataProducao = dataProducao;
        }

        public override string EtiquetaPreco(string etiquetaPreco)
        {
            return base.EtiquetaPreco(etiquetaPreco);
        }

        public override string ToString()
        {
            return Nome + " (usado) $" + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                " (Data de Produção: " + DataProducao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
