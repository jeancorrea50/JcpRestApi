using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JcpApi.Models
{
   
        public enum TipoMensagem
        {
            Informacao,
            Erro
        }

        public class Mensagem
        {
            public TipoMensagem Tipo { get; set; }
            public string Texto { get; set; }
            public Mensagem(string mensagem, TipoMensagem tipo = TipoMensagem.Informacao)
            {
                this.Tipo = tipo;
                this.Texto = mensagem;
            }

            public static string Serializar(string mensagem, TipoMensagem tipo = TipoMensagem.Informacao)
            {
                var mensagemModel = new Mensagem(mensagem, tipo);
                return JsonConvert.SerializeObject(mensagemModel);
            }

            public static Mensagem Desserializar(string mensagemString)
            {
                return JsonConvert.DeserializeObject<Mensagem>(mensagemString);
            }
        }
    }

