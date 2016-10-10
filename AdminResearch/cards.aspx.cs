using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Security;
using System.Data;

namespace AdminResearch
{
    public partial class cards : System.Web.UI.Page
    {
        public String backlog = String.Empty;
        public String make = String.Empty;
        public String finished = String.Empty;
        public String archived = String.Empty;
        public int backlogCount, makeCount, finishedCount, archivedCount;

        protected void Page_Load(object sender, EventArgs e)
        {
            pullCards();
        }

        public void pullCards()
        {
            Card card = new Card();

            DataTable resultBacklogs = card.getBackLog();
            DataTable resultMake = card.getMake();
            DataTable resultFinished = card.getFinished();
            DataTable resultArchived = card.getArchived();

            backlogCount = resultBacklogs.Rows.Count;
            makeCount = resultMake.Rows.Count;
            finishedCount = resultFinished.Rows.Count;
            archivedCount = resultArchived.Rows.Count;

            for (int i = 0; i < resultBacklogs.Rows.Count; i++)
            {
                backlog += @"<div class='portlet portlet-sortable box red-flamingo' style='margin-top:15px;'>
                            <div class='portlet-title'>
                                <div class='caption'>
                                    " + resultBacklogs.Rows[i]["description"] + @"
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
                                <a>
                                </a>
                            </div>
                        </div>";
            }

            for (int i = 0; i < resultMake.Rows.Count; i++)
            {
                make += @"<div class='portlet portlet-sortable box white' style='margin-top:15px;'>
                            <div class='portlet-title'>
                                <div class='caption'>
                                    " + resultMake.Rows[i]["description"] + @"
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
                        </div>";
            }

            for (int i = 0; i < resultFinished.Rows.Count; i++)
            {
                finished += @"<div class='portlet portlet-sortable box white' style='margin-top:15px;'>
                            <div class='portlet-title'>
                                <div class='caption'>
                                    " + resultFinished.Rows[i]["description"] + @"
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
                        </div>";
            }

            for (int i = 0; i < resultArchived.Rows.Count; i++)
            {
                archived = @"<div class='portlet portlet-sortable box white' style='margin-top:15px;'>
                            <div class='portlet-title'>
                                <div class='caption'>
                                    " + resultArchived.Rows[i]["description"] + @"
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
                        </div>";
            }

        }



    }
}