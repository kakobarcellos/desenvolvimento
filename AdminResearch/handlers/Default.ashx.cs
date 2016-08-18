﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Security;

namespace AdminResearch.handlers
{
    /// <summary>
    /// Summary description for Default
    /// </summary>
    public class Default : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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