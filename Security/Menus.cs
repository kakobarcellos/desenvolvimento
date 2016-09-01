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
    public class Menus : SqlAcess
    {
        public Menus() :
            base("menus", null) //aqui eh o construtor da tabela (nome_tabela)
        {
        }

        public Menus(NpgsqlTransaction transaction) :
            base("menus") //aqui eh o construtor da tabela (nome_tabela)
        {
            if (transaction != null)
            {
                transaction = this.transaction;
                con = transaction.Connection;
            }
        }

        public DataTable getMenus()
        {
            String sql = "SELECT * FROM MENUS";
            DataTable result = new DataTable();
            return result = queryToDataTable(sql, false);
        }
    }
}
