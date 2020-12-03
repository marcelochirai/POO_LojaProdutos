using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO_TarefaLojaProdutos.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado()
        {
            
        }

        public ProdutoImportado (string nome, double preco, double taxaImportacao) : base(nome, preco)
        {
            TaxaImportacao = taxaImportacao;
        }

        public override string EtiquetaPreco(string etiquetapreco)
        {
            return base.EtiquetaPreco(etiquetapreco);
        }

        public double PrecoTotal()
        {
            return Preco * TaxaImportacao;
        }

        public override string ToString()
        {
            return Nome + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                " (Taxa de Importação: $ " + TaxaImportacao.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

    }
}
