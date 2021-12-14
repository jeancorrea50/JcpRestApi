using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JcpApi.Models
{
    [Table("Usuario")]

    public class Usuario
    {
     
            [Key]
            public int IdUsuario { get; set; }

            [Required, MaxLength(128)]
            public string Nome { get; set; }

            [Required, MaxLength(128)]
            public string Email { get; set; }

            [Required, MaxLength(128)]
            public string Senha { get; set; }

            [ReadOnly(true)]
            public DateTime? DataCadastro { get; }

        }
    }

