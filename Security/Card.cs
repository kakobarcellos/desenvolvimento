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
    public class Card : SqlAcess
    {
        public Card() :
            base("cards", null) 
        {
        }

        public Card(NpgsqlTransaction transaction) :
            base("cards")
        {
            if (transaction != null)
            {
                transaction = this.transaction;
                con = transaction.Connection;
            }
        }

        public DataTable getBackLog()
        {
            String sql = "SELECT * FROM CARDS WHERE PHASE = 0";

            return queryToDataTable(sql);
        }

        public DataTable getFinished()
        {
            String sql = "SELECT * FROM CARDS WHERE PHASE = 1";

            return queryToDataTable(sql);
        }

        public DataTable getArchived()
        {
            String sql = "SELECT * FROM CARDS WHERE PHASE = 2";

            return queryToDataTable(sql);
        }

        public DataTable getMake()
        {
            String sql = "SELECT * FROM CARDS WHERE PHASE = 3";

            return queryToDataTable(sql);
        }
    }
}
