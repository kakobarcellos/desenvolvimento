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
            base("charts", null) //aqui eh o construtor da tabela (nome_tabela)
        {
        }

        public Charts(NpgsqlTransaction transaction) :
            base("charts") //aqui eh o construtor da tabela (nome_tabela)
        {
            if (transaction != null)
            {
                transaction = this.transaction;
                con = transaction.Connection;
            }
        }

        public DataTable listaTestes(object parametro)
        {
            string sql = "SELECT * FROM charts WHERE chart_id = {0}";

            sql = String.Format(sql, parametro);
            return queryToDataTable(sql);
        }
    }

}
