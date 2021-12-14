using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JcpApi.Models
{
    [Table("Fornecedor")]

    public class Fornecedor
    {
        [Key]
        public int IdFornecedor { get; set; }
        public string Marca{ get; set; }
        public string Fantasia{ get; set; }
        public string RazaoSocial{ get; set; }
        public string Cnpj { get; set; }
        public string NumeroContato { get; set; }
        public string NomeContato { get; set; }
        public string CidadeFornecedor { get; set; }
        public string EstadoFornecedor { get; set; }
        public string PaisFornecedor { get; set; }



        [ForeignKey("Produto")]
        public int IdProduto { get; set; }

        public Produto Produto { get; set; }

        public DateTime? DataCadastroFornecedor { get; } = DateTime.Now;

    }
}
