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
            Answer answer = new Answer();

            Object modified = 0;

            try
            {
                question.AddField("description", context.Request.Form["description"], "string");
                question.AddField("status", context.Request.Form["status"], "int");
                question.AddField("type", context.Request.Form["type"], "int");

                modified = question.Insert();

                question.AddField("answer1", context.Request.Form["answer1"], "string");
                question.AddField("answer2", context.Request.Form["answer2"], "string");
                question.AddField("answer3", context.Request.Form["answer3"], "string");
                question.AddField("answer4", context.Request.Form["answer4"], "string");
                question.AddField("answer5", context.Request.Form["answer5"], "string");
                question.AddField("question_id", modified, "int");

                answer.Insert();

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
                question.ID = Convert.ToInt32(context.Request.Form["id"]);
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
                question.ID = Convert.ToInt32(context.Request.Form["id"]);

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
                    result += "[\"" + dataRow["ID"] + "\",\"" + dataRow["DESCRIPTION"] + "\",\"" + dataRow["STATUS"] + "\",\"" + dataRow["TYPE"] + "\"],";
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

            question.ID = Convert.ToInt32(context.Request.Form["id"]);
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