using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JcpApi.Models
{
    [Table("Produto")]

    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        public string DscProduto { get; set; }
        public string CorProduto { get; set; }
        public string InfoProduto { get; set; }
        public decimal ValorUniProduto { get; set; }
        public decimal ValorTotalProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public string MemoriaProduto { get; set; }
        public string PolegadaProduto { get; set; }
        public string TamanhoProduto { get; set; }
        public string VoltagemProduto { get; set; }

        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }

        public Categoria Categoria { get; set; }


        public DateTime? DataCadastroProduto { get; } = DateTime.Now;



    }
}
