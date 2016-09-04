using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Security;
using System.Data;

namespace AdminResearch.handlers
{
    /// <summary>
    /// Summary description for QuestionHandler
    /// </summary>
    public class QuestionHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            switch (context.Request.QueryString["action"])
            {
                case "insert":
                    Insert(context);
                    break;
                case "update":
                    Update(context);
                    break;
                case "delete":
                    Delete(context);
                    break;
                case "getQuestions":
                    GetQuestions(context);
                    break;
                case "setQuestion":
                    SetQuestion(context);
                    break;
            }
        }

        
        private void Insert(HttpContext context)
        {
            Question question = new Question();

            try
            {
                question.Description = context.Request.Form["description"];
                question.Status = Convert.ToBoolean(context.Request.Form["status"]);
                question.Type = Convert.ToInt32(context.Request.Form["type"]);

                question.InsertQuestion(question);
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }


        private void Update(HttpContext context)
        {
            Question question = new Question();

            try
            {
                question.ID = Convert.ToInt32(context.Request.Form["question_id"]);
                question.Description = context.Request.Form["description"];
                question.Status = Convert.ToBoolean(context.Request.Form["status"]);
                question.Type = Convert.ToInt32(context.Request.Form["type"]);

                question.UpdateQuestion(question);
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void Delete(HttpContext context)
        {
            Question question = new Question();

            try
            {
                question.ID = Convert.ToInt32(context.Request.Form["question_id"]);

                question.DeleteQuestion(question);
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void GetQuestions(HttpContext context)
        {
            Question questions = new Question();
            DataTable resultQuestions = new DataTable();
            
            String sSearch = "";
            int iDisplayStart = 0;
            int iDisplayLength = 10;
            int sEcho = 1;
            String result = "";

            try
            {
                if (!string.IsNullOrEmpty(context.Request.QueryString["draw"]))
                {
                    sEcho = Convert.ToInt32(context.Request.QueryString["draw"]);
                }

                if (!string.IsNullOrEmpty(context.Request.QueryString["start"]))
                {
                    iDisplayStart = Convert.ToInt32(context.Request.QueryString["start"]);
                }

                if (!string.IsNullOrEmpty(context.Request.QueryString["length"]))
                {
                    iDisplayLength = Convert.ToInt32(context.Request.QueryString["length"]);
                }

                if (!string.IsNullOrEmpty(context.Request.QueryString["search[value]"]))
                {
                    sSearch = context.Request.QueryString["search[value]"];
                }
                
                resultQuestions = questions.GetQuestions(sSearch, iDisplayStart, iDisplayLength + iDisplayStart);


                result = "{\"draw\": \"" + sEcho + "\",    \"recordsTotal\": \"" + resultQuestions.Rows.Count + "\",   \"recordsFiltered\": \"" + resultQuestions.Rows.Count + "\",     \"data\":[";

                foreach (DataRow dataRow in resultQuestions.Rows)
                {
                    result += "[\"" + dataRow["QUESTION_ID"] + "\",\"" + dataRow["DESCRIPTION"] + "\",\"" + dataRow["STATUS"] + "\",\"" + dataRow["TYPE"] + "\"],";
                }

                if (resultQuestions.Rows.Count != 0)
                {
                    result = result.Substring(0, result.Length - 1);
                }

                result += "]}";

            }
            finally
            {
                questions = null;
            }

            context.Response.Write(result);

    }


        private void SetQuestion(HttpContext context)
        {
            Question question = new Question();
            DataTable result = new DataTable();
            String resultJson = String.Empty;

            question.ID = Convert.ToInt32(context.Request.Form["question_id"]);
            result = question.SetQuestion(question);
            resultJson = functions.DataTableToJson(result);

            context.Response.Write(resultJson);
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}