using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Security;
using System.Data;

namespace AdminResearch.handlers
{
    /// <summary>
    /// Summary description for MenuHandler
    /// </summary>
    public class MenuHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            switch (context.Request.QueryString["action"])
            {
                case "insert":
                    if (!String.IsNullOrEmpty(context.Request.Form["father_menu"]))
                    {
                        InsertSubMenu(context);
                    }
                    else
                    {
                        InsertMenu(context);
                    }
                    break;
                case "update":
                    Update(context);
                    break;
                case "delete":
                    Delete(context);
                    break;
                case "menuSelect":
                    MenuSelect(context);
                    break;
            }
        }
        
        private void InsertMenu(HttpContext context)
        {
            Menu menu = new Menu();
        }

        private void InsertSubMenu(HttpContext context)
        {
            SubMenu menu = new SubMenu();

        }

        private void Update(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private void Delete(HttpContext context)
        {
            throw new NotImplementedException();
        }


        private void MenuSelect(HttpContext context)
        {
            Menu menu = new Menu();
            String result = String.Empty;
            DataTable menuResult = new DataTable();

            menuResult = menu.getAllRecords();

            result = "<option value='0'>Nenhum</option>";

            for (int i = 0; i < menuResult.Rows.Count; i++)
            {
                result += @"<option value='" + menuResult.Rows[i]["menu_id"] + "' >" + menuResult.Rows[i]["name"] + "</option>";
            }

            context.Response.Write(result);
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