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
    public class Question: SqlAcess
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int Type { get; set; }
        
        public Question() :
            base("questions", null) //aqui eh o construtor da tabela (nome_tabela)
        {
        }

        public Question(NpgsqlTransaction transaction) :
            base("questions") //aqui eh o construtor da tabela (nome_tabela)
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

        public void UpdateQuestion(Question question)
        {
            String sql = "UPDATE QUESTIONS SET DESCRIPTION = '{0}', STATUS = {1}, TYPE = {2} WHERE ID = {4}";

            sql = String.Format(sql, question.Description, question.Status, question.Type, question.ID);
            question.queryExecute(sql);
        }

        public void DeleteQuestion(Question question)
        {
            String sql = "DELETE QUESTIONS WHERE ID = {0}";

            sql = String.Format(sql, question.ID);
            question.queryExecute(sql);
        }

        public DataTable GetQuestions(string dsfiltro, int iDisplayStart, int iDisplayLength)
        {
            DataTable result = new DataTable();

            this.OpenConnection();
            
            String sql = @" SELECT
	                            *
                            FROM
	                            (
		                            SELECT
                                        ID,
                                        DESCRIPTION,
			                            TYPE, 
                                        STATUS,
			                            ROW_NUMBER () OVER (ORDER BY ID) AS RowNumber
		                            FROM
			                            QUESTIONS
                                        ";
            sql += "        WHERE DESCRIPTION LIKE '%" + limpaLixo(dsfiltro) + "%'";
            sql += @"       ) Derived
                            WHERE
	                            RowNumber BETWEEN {0}
                            AND {1} ";


            sql = String.Format(sql, iDisplayStart, iDisplayLength);

            return result = queryToDataTable(sql);
        }

        public DataTable SetQuestion(Question question)
        {
            String sql = "SELECT * FROM QUESTIONS WHERE ID = {0}";

            sql = String.Format(sql, question.ID);
            return queryToDataTable(sql);
        }
    }
}
