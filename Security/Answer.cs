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
    public class Answer: SqlAcess
    {
        public Answer() :
            base("answers", null) //aqui eh o construtor da tabela (nome_tabela)
        {
        }

        public Answer(NpgsqlTransaction transaction) :
            base("answers") //aqui eh o construtor da tabela (nome_tabela)
        {
            if (transaction != null)
            {
                transaction = this.transaction;
                con = transaction.Connection;
            }
        }

        public void InsertQuestion(Question question)
        {
            String sql = "INSERT INTO QUESTIONS (DESCRIPTION, STATUS, TYPE) VALUES ( '{0}', {1}, {2} )";

            sql = String.Format(sql, question.Description, question.Status, question.Type);
            question.queryExecute(sql);
        }
    }
}
