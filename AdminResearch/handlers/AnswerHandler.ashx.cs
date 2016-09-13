using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Security;
using System.Collections;

namespace AdminResearch.handlers
{
    /// <summary>
    /// Summary description for AnswerHandler
    /// </summary>
    public class AnswerHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            switch (context.Request.QueryString["action"])
            {
                case "insert":
                    insert(context);
                    break;
            }
        }

        private void insert(HttpContext context)
        {
            ArrayList teste = new ArrayList();

            String teste1 = context.Request.Form["answers"];
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