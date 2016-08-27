using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Data;
using System.Text;
using Newtonsoft.Json;


namespace Security
{
    public class Charts : SqlAcess
    {

        public Charts() :
            base("TESTE", null)
        {
        }

        public Charts(NpgsqlTransaction transaction) :
            base("TESTE")
        {
            if (transaction != null)
            {
                transaction = this.transaction;
                con = transaction.Connection;
            }
        }

        public DataTable listaTestes(object parametro)
        {
            string sql = "SELECT * FROM TESTE WHERE TESTE = {0}";

            sql = String.Format(sql, parametro);
            return queryToDataTable(sql);
        }
    }

}
