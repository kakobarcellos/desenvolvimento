using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Security;
using System.Collections;

namespace AdminResearch.handlers
{
    /// <summary>
    /// Summary description for CardHandler
    /// </summary>
    public class CardHandler : IHttpHandler
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
            Card card = new Card();

            try
            {
                card.AddField("description", context.Request.Form["description"], "string");

                card.Insert();
            }
            catch (Exception ex)
            {
                throw(ex);
            }
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