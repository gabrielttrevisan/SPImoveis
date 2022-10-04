using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SPImoveis.Entities
{
    public abstract class Entity<T>
    {
        protected SqlConnection con;
        public bool IgnoraTransacao { get; set; }

        public Entity()
        {
            con = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbTeste;User ID=root;Password=;Trusted_Connection=True;");
        }

        public abstract T Mapper(SqlDataReader reader);

        public List<T> RunProcudure(string procedure)
        {
            SqlCommand command = new SqlCommand("exec " + procedure + ";", con);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<T> list = new List<T>();

            while (reader.Read())
            {
                list.Add(Mapper(reader));
            }

            con.Close();

            return list;
        }

    }
}