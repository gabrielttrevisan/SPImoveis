using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SPImoveis.Utils;

namespace SPImoveis.Repositories
{
    public abstract class Repository<T>
    {
        protected SqlConnection con;
        public bool IgnoraTransacao { get; set; }

        public Repository()
        {
            con = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbTeste;User ID=root;Password=;Trusted_Connection=True;");
        }

        public abstract T Mapper(SqlDataReader reader);

        public List<T> RunProcudure(string procedure, ProcedureParams procedureParams = null)
        {
            if (procedureParams == null) procedureParams = ProcedureParams.Empty;

            SqlCommand command = new SqlCommand("exec " + procedure + procedureParams.ToString() + ";", con);
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

        public Int32 SilentlyRunProcudure(string procedure, ProcedureParams procedureParams = null)
        {
            if (procedureParams == null) procedureParams = ProcedureParams.Empty;

            string sql = "exec " + procedure + " "+ procedureParams.ToString() + ";";
            SqlCommand command = new SqlCommand(sql, con);
            con.Open();

            Int32 affected = command.ExecuteNonQuery();

            con.Close();

            return affected;
        }

    }
}