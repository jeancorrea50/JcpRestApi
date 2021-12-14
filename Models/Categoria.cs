using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JcpApi.Models
{
    [Table("Categoria")]

    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string DescCategoria { get; set; }
    }
}
