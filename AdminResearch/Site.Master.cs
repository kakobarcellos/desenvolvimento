using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Security;
using System.Data;

namespace AdminResearch
{
    public partial class Site : System.Web.UI.MasterPage
    {

        public StringBuilder resultMenu = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            createMenu();
        }

        public void createMenu()
        {
            Security.Menu menu = new Security.Menu();
            SubMenu sub_menu = new SubMenu();

            DataTable resultMenus = new DataTable();
            DataTable resultSubMenus = new DataTable();

            resultMenus = menu.getMenus();

            for (int i = 0; i < resultMenus.Rows.Count; i++)
            {
                resultMenu.AppendFormat(@"<li class='menu-dropdown classic-menu-dropdown'>
                        <a href='{0}'> {1}
                                <span class='arrow'></span>
                        </a>", resultMenus.Rows[i]["url"], resultMenus.Rows[i]["name"]);

                resultSubMenus = sub_menu.getSubMenus(resultMenus.Rows[i]["menu_id"]);

                if (resultSubMenus.Rows.Count > 0)
                {
                    resultMenu.Append("<ul class='dropdown-menu pull-left'>");
                    for (int j = 0; j < resultSubMenus.Rows.Count; j++)
                    {
                        resultMenu.AppendFormat(@"
                        
                            <li class=''>
                                <a href='{0}' class='nav-link'>{1}</a>
                            </li>
                        
                    ", resultSubMenus.Rows[j]["url"], resultSubMenus.Rows[j]["name"]);
                    }
                    resultMenu.Append("</ul>");
                }
               
                

                resultMenu.Append("</li>");
                
            }
        }
    }
}