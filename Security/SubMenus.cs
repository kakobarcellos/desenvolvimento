using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Data;
using System.Text;
using Newtonsoft.Json;
using System;

namespace Security
{
    public class SubMenus : SqlAcess
    {
        public SubMenus() :
            base("sub_menus", null) //aqui eh o construtor da tabela (nome_tabela)
        {
        }

        public SubMenus(NpgsqlTransaction transaction) :
            base("sub_menus") //aqui eh o construtor da tabela (nome_tabela)
        {
            if (transaction != null)
            {
                transaction = this.transaction;
                con = transaction.Connection;
            }
        }

        public DataTable getSubMenus(object menu_id)
        {
            String sql = "SELECT * FROM SUB_MENUS WHERE MENU_ID = {0}";
            DataTable result = new DataTable();

            sql = String.Format(sql, menu_id);
            return result = queryToDataTable(sql);
        }
    }
}
