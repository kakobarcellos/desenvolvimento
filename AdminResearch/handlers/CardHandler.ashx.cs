using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Security;
using System.Collections;
using System.Data;
using System.Text;

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
                case "getCards":
                    getCards(context);
                    break;
            }
        }

        private void insert(HttpContext context)
        {
            Card card = new Card();

            try
            {
                card.AddField("description", context.Request.Form["description"], "string");
                card.AddField("date_limit", context.Request.Form["date_limit"], "date");

                card.Insert();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void getCards(HttpContext context)
        {
            Card card = new Card();
            DataTable dtBacklog = new DataTable();
            StringBuilder resultBacklog = new StringBuilder();

            try
            {
                dtBacklog = card.getBackLog();

                for (int i = 0; i < dtBacklog.Rows.Count; i++)
                {
                    resultBacklog.AppendFormat(@"<div class='portlet portlet-sortable box red-flamingo' style='margin-top:15px;'>
                            <div class='portlet-title'>
                                <div class='caption'>
                                    {0}
                                </div>
                                <div class='actions'>
                                    <div class='btn-group'>
                                        <ul class='dropdown-menu pull-right'>
                                            <li>
                                                <a href='javascript:;'>
                                                    <i class='fa fa-pencil'></i>Edit</a>
                                            </li>
                                            <li>
                                                <a href='javascript:;'>
                                                    <i class='fa fa-trash-o'></i>Delete</a>
                                            </li>
                                            <li>
                                                <a href='javascript:;'>
                                                    <i class='fa fa-ban'></i>Ban</a>
                                            </li>
                                            <li class='divider'></li>
                                            <li>
                                                <a href='javascript:;'> Make admin</a>
                                            </li>
                                        </ul>
                                    </div>
                                    <a class='btn btn-sm btn-icon-only btn-default fullscreen' href='javascript:;'></a>
                                </div>
                            </div>
                            <div class='portlet-body'>

                            </div>
                        </div>", dtBacklog.Rows[i]["description"]);
                }
            }
            catch (Exception ex)
            {
                throw(ex);
            }

            context.Response.Write(resultBacklog.ToString());
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