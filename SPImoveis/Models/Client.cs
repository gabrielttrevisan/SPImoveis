using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SPImoveis.Models
{
    public class Client
    {
        
        public Int32? ClienteId { get; set; }

        public String Cliente { get; set; }

        public String TipoCliente { get; set; }

        public String NomeContato { get; set; }

        public String Telefone { get; set; }

        public String Cidade { get; set; }

        public String Bairro { get; set; }

        public String Logradouro { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

    }
}