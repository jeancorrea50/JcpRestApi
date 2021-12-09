using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JcpApi.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string CorProduto { get; set; }
        public string InformacoesProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public string MemoriaProduto { get; set; }
        public string PolegadaProduto { get; set; }
        public string TamanhoProduto { get; set; }
        public string VoltagemProduto { get; set; }



    }
}
