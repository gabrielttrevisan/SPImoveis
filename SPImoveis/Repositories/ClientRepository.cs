using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SPImoveis.Models;

namespace SPImoveis.Repositories
{
    public class ClientRepository : Repository<Client>
    {

        public ClientRepository() : base()
        {
        }

        public override Client Mapper(SqlDataReader reader)
        {
            return new Client
            {
                ClienteId = reader.GetInt32(0),
                Cliente = reader.GetString(1),
                TipoCliente = reader.GetString(2),
                NomeContato = reader.GetString(3),
                Telefone = reader.IsDBNull(4) ? String.Empty : reader.GetString(4),
                Cidade = reader.IsDBNull(5) ? String.Empty : reader.GetString(5),
                Bairro = reader.IsDBNull(6) ? String.Empty : reader.GetString(6),
                Logradouro = reader.IsDBNull(7) ? String.Empty : reader.GetString(7),
                DataCadastro = reader.GetDateTime(9),
            };
        }
    }
}