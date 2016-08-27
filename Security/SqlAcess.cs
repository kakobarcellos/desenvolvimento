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
    public class SqlAcess
    {
        private string ConnectionString;
        public NpgsqlConnection con;
        public NpgsqlTransaction transaction;

        protected string table;
        private string v;

        public SqlAcess(String table, NpgsqlTransaction transaction)
        {
            if (transaction != null)
            {
                this.table = table;
                this.con = transaction.Connection;
                this.transaction = transaction;
            }
            else
            {
                this.table = table;
                OpenConnection();
                startTransaction();
            }
        } 

        public void startTransaction()
        {
            if (transaction == null)
            {
                transaction = con.BeginTransaction();
            }
        }


        public string OpenConnection()
        {
            string result;
            this.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            this.con = new NpgsqlConnection(this.ConnectionString);

            try
            {
                this.con.Open();//abre e mostra msg
                result = "Conectado ao banco";
            }
            catch (NpgsqlException ex)
            {
                result = ex.Message;
            }

            return result;
        }


        public string CloseConnection(Boolean close = true)
        {
            string result;

            try
            {
                if (close == true)
                {
                    this.con.Close();//fecha conexao
                }
                result = "Conexão fechada";
            }
            catch (NpgsqlException ex)
            {
                result = ex.Message;
            }

            return result;
        }


        public string executarQuery(string sql)//Método que executa qualquer query sem retorno(UPDATE, INSERT, DELETE, SET)
        {
            string result;
            var transaction = con.BeginTransaction();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, this.con, transaction);// cria o comendo de acordo com sua conexão e transação
                command.ExecuteNonQuery();//executa a query especifica aos parâmetros comentados
                transaction.Commit();// Commita para o banco
                result = "Transacao aceita";
            }
            catch (NpgsqlException ex)
            {
                transaction.Rollback(); // Em caso de erro cancela (Rollback) a transação.
                result = ex.Message;
            }

            return result;
        }

        public DataTable queryToDataTable(string sql, Boolean close = true)
        {
            OpenConnection();
            DataTable dataTable = new DataTable();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, this.con);
                IDataReader buffer = command.ExecuteReader();
                dataTable.Load(buffer);
                buffer.Close();
                CloseConnection(close);
                return dataTable;
            }
            catch (NpgsqlException)
            {
                return null;
            }
        }

    }
}
