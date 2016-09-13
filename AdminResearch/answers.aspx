<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="answers.aspx.cs" Inherits="AdminResearch.answers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceContainer" runat="server">
     <div class="page-container">
            <!-- BEGIN CONTENT -->
        <div class="page-content-wrapper">
            <!-- BEGIN CONTENT BODY -->
            <!-- BEGIN PAGE HEAD-->
            <div class="page-head">
                <div class="container">
                    <!-- BEGIN PAGE TITLE -->
                    <div class="page-title">
                        <h1>Perguntas
                            <small>Especificação</small>
                        </h1>
                    </div>
                    <!-- END PAGE TITLE -->
                    <!-- BEGIN PAGE TOOLBAR -->
                    <div class="page-toolbar">
                        <!-- BEGIN THEME PANEL -->
                        <div class="btn-group btn-theme-panel">
                            <a href="javascript:;" class="btn dropdown-toggle" data-toggle="dropdown">
                                <i class="icon-settings"></i>
                            </a>
                            <div class="dropdown-menu theme-panel pull-right dropdown-custom hold-on-click">
                                <div class="row">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <h3>THEME COLORS</h3>
                                        <div class="row">
                                            <div class="col-md-6 col-sm-6 col-xs-12">
                                                <ul class="theme-colors">
                                                    <li class="theme-color theme-color-default" data-theme="default">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Default</span>
                                                    </li>
                                                    <li class="theme-color theme-color-blue-hoki" data-theme="blue-hoki">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Blue Hoki</span>
                                                    </li>
                                                    <li class="theme-color theme-color-blue-steel" data-theme="blue-steel">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Blue Steel</span>
                                                    </li>
                                                    <li class="theme-color theme-color-yellow-orange" data-theme="yellow-orange">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Orange</span>
                                                    </li>
                                                    <li class="theme-color theme-color-yellow-crusta" data-theme="yellow-crusta">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Yellow Crusta</span>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="col-md-6 col-sm-6 col-xs-12">
                                                <ul class="theme-colors">
                                                    <li class="theme-color theme-color-green-haze" data-theme="green-haze">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Green Haze</span>
                                                    </li>
                                                    <li class="theme-color theme-color-red-sunglo" data-theme="red-sunglo">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Red Sunglo</span>
                                                    </li>
                                                    <li class="theme-color theme-color-red-intense" data-theme="red-intense">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Red Intense</span>
                                                    </li>
                                                    <li class="theme-color theme-color-purple-plum" data-theme="purple-plum">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Purple Plum</span>
                                                    </li>
                                                    <li class="theme-color theme-color-purple-studio" data-theme="purple-studio">
                                                        <span class="theme-color-view"></span>
                                                        <span class="theme-color-name">Purple Studio</span>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12 seperator">
                                        <h3>LAYOUT</h3>
                                        <ul class="theme-settings">
                                            <li> Theme Style
                                                <select class="theme-setting theme-setting-style form-control input-sm input-small input-inline tooltips" data-original-title="Change theme style" data-container="body" data-placement="left">
                                                    <option value="boxed" selected="selected">Square corners</option>
                                                    <option value="rounded">Rounded corners</option>
                                                </select>
                                            </li>
                                            <li> Layout
                                                <select class="theme-setting theme-setting-layout form-control input-sm input-small input-inline tooltips" data-original-title="Change layout type" data-container="body" data-placement="left">
                                                    <option value="boxed" selected="selected">Boxed</option>
                                                    <option value="fluid">Fluid</option>
                                                </select>
                                            </li>
                                            <li> Top Menu Style
                                                <select class="theme-setting theme-setting-top-menu-style form-control input-sm input-small input-inline tooltips" data-original-title="Change top menu dropdowns style" data-container="body"
                                                    data-placement="left">
                                                    <option value="dark" selected="selected">Dark</option>
                                                    <option value="light">Light</option>
                                                </select>
                                            </li>
                                            <li> Top Menu Mode
                                                <select class="theme-setting theme-setting-top-menu-mode form-control input-sm input-small input-inline tooltips" data-original-title="Enable fixed(sticky) top menu" data-container="body" data-placement="left">
                                                    <option value="fixed">Fixed</option>
                                                    <option value="not-fixed" selected="selected">Not Fixed</option>
                                                </select>
                                            </li>
                                            <li> Mega Menu Style
                                                <select class="theme-setting theme-setting-mega-menu-style form-control input-sm input-small input-inline tooltips" data-original-title="Change mega menu dropdowns style" data-container="body"
                                                    data-placement="left">
                                                    <option value="dark" selected="selected">Dark</option>
                                                    <option value="light">Light</option>
                                                </select>
                                            </li>
                                            <li> Mega Menu Mode
                                                <select class="theme-setting theme-setting-mega-menu-mode form-control input-sm input-small input-inline tooltips" data-original-title="Enable fixed(sticky) mega menu" data-container="body"
                                                    data-placement="left">
                                                    <option value="fixed" selected="selected">Fixed</option>
                                                    <option value="not-fixed">Not Fixed</option>
                                                </select>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- END THEME PANEL -->
                    </div>
                    <!-- END PAGE TOOLBAR -->
                </div>
            </div>
            <!-- END PAGE HEAD-->
            <!-- BEGIN PAGE CONTENT BODY -->
            <div class="page-content">
                <div class="container">
                    <!-- BEGIN PAGE BREADCRUMBS -->
                    <ul class="page-breadcrumb breadcrumb">
                        <li>
                            <a href="index.html">Home</a>
                            <i class="fa fa-circle"></i>
                        </li>
                        <li>
                            <a href="#">More</a>
                            <i class="fa fa-circle"></i>
                        </li>
                        <li>
                            <span>Form Stuff</span>
                        </li>
                    </ul>
                    <div class="page-content-inner">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="portlet-body">
                                    <div class="portlet box green">
                                        <div class="portlet-title">
                                            <div class="caption">
                                                <i class="fa fa-globe"></i>Perguntas
                                            </div>
                                            <div class="tools"></div>
                                        </div>
                                        <div class="portlet-body">
                                            <table class="table table-striped table-bordered table-hover order-column" id="questions-grid">
                                                <thead>
                                                    <tr>
                                                        <th>Cód.
                                                        </th>
                                                        <th>Descrição
                                                        </th>
                                                        <th>Status
                                                        </th>
                                                        <th>Tipo
                                                        </th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="portlet light">
                                    <div class="portlet-title">
                                        <div class="caption font-red-sunglo">
                                            <i class="icon-settings font-red-sunglo"></i>
                                            <span class="caption-subject bold uppercase"> Crie as suas respostas</span>
                                        </div> 
                                    </div>
                                    <div class="portlet-body form">
                                        <form role="form" id="form_answers">
                                            <div class="form-body">
                                                <div class="form-group" >
                                                    <label>Descrição</label> 
                                                    <div class="row">
                                                        <div class="col-md-12" id="fields_div"> 
                                                            <div class="col-md-10">
                                                                <input type="text" name="resposta1" id="resposta1" class="form-control" placeholder="Resposta 1" />
                                                            </div>
                                                            <div class="col-md-2">
                                                                <button class="btn green add_field2" type="button">+</button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-actions" style="position:relative">
                                                <button type="button" class="btn blue" id="btn_save">Salvar</button>
                                                <button type="button" class="btn green" id="btn_edit" hidden>Alterar</button>
                                                <button type="button" class="btn red" id="btn_delete" hidden>Remover</button>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
    <script type="text/javascript" src="js/answers.js"></script>
</asp:Content>
