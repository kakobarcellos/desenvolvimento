<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="questions.aspx.cs" Inherits="AdminResearch.questions" %>

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
                                            <li>Theme Style
                                                <select class="theme-setting theme-setting-style form-control input-sm input-small input-inline tooltips" data-original-title="Change theme style" data-container="body" data-placement="left">
                                                    <option value="boxed" selected="selected">Square corners</option>
                                                    <option value="rounded">Rounded corners</option>
                                                </select>
                                            </li>
                                            <li>Layout
                                                <select class="theme-setting theme-setting-layout form-control input-sm input-small input-inline tooltips" data-original-title="Change layout type" data-container="body" data-placement="left">
                                                    <option value="boxed" selected="selected">Boxed</option>
                                                    <option value="fluid">Fluid</option>
                                                </select>
                                            </li>
                                            <li>Top Menu Style
                                                <select class="theme-setting theme-setting-top-menu-style form-control input-sm input-small input-inline tooltips" data-original-title="Change top menu dropdowns style" data-container="body"
                                                    data-placement="left">
                                                    <option value="dark" selected="selected">Dark</option>
                                                    <option value="light">Light</option>
                                                </select>
                                            </li>
                                            <li>Top Menu Mode
                                                <select class="theme-setting theme-setting-top-menu-mode form-control input-sm input-small input-inline tooltips" data-original-title="Enable fixed(sticky) top menu" data-container="body" data-placement="left">
                                                    <option value="fixed">Fixed</option>
                                                    <option value="not-fixed" selected="selected">Not Fixed</option>
                                                </select>
                                            </li>
                                            <li>Mega Menu Style
                                                <select class="theme-setting theme-setting-mega-menu-style form-control input-sm input-small input-inline tooltips" data-original-title="Change mega menu dropdowns style" data-container="body"
                                                    data-placement="left">
                                                    <option value="dark" selected="selected">Dark</option>
                                                    <option value="light">Light</option>
                                                </select>
                                            </li>
                                            <li>Mega Menu Mode
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
                            <div class="col-md-12">
                                <div class="portlet light " id="form_wizard_1">
                                    <div class="portlet-title">
                                        <div class="caption">
                                            <i class=" icon-layers font-red"></i>
                                            <span class="caption-subject font-red bold uppercase">Pergunta
                                                    <span class="step-title">Etapa 1 de 4 </span>
                                            </span>
                                        </div>
                                        <div class="actions">
                                            <a class="btn btn-circle btn-icon-only btn-default" href="javascript:;">
                                                <i class="icon-cloud-upload"></i>
                                            </a>
                                            <a class="btn btn-circle btn-icon-only btn-default" href="javascript:;">
                                                <i class="icon-wrench"></i>
                                            </a>
                                            <a class="btn btn-circle btn-icon-only btn-default" href="javascript:;">
                                                <i class="icon-trash"></i>
                                            </a>
                                        </div>
                                    </div>
                                    <div class="portlet-body form">
                                        <form class="form-horizontal" action="#" id="submit_form" method="POST">
                                            <div class="form-wizard">
                                                <div class="form-body">
                                                    <ul class="nav nav-pills nav-justified steps">
                                                        <li>
                                                            <a href="#tab1" data-toggle="tab" class="step">
                                                                <span class="number">1 </span>
                                                                <span class="desc">
                                                                    <i class="fa fa-check"></i>Pergunta </span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a href="#tab2" data-toggle="tab" class="step">
                                                                <span class="number">2 </span>
                                                                <span class="desc">
                                                                    <i class="fa fa-check"></i>Respostas </span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a href="#tab3" data-toggle="tab" class="step active">
                                                                <span class="number">3 </span>
                                                                <span class="desc">
                                                                    <i class="fa fa-check"></i>Tipo </span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a href="#tab4" data-toggle="tab" class="step">
                                                                <span class="number">4 </span>
                                                                <span class="desc">
                                                                    <i class="fa fa-check"></i>Confirmação </span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                    <div id="bar" class="progress progress-striped" role="progressbar">
                                                        <div class="progress-bar progress-bar-success"></div>
                                                    </div>
                                                    <div class="tab-content">
                                                        <div class="alert alert-danger display-none">
                                                            <button class="close" data-dismiss="alert"></button>
                                                            You have some form errors. Please check below.
                                                        </div>
                                                        <div class="alert alert-success display-none">
                                                            <button class="close" data-dismiss="alert"></button>
                                                            Your form validation is successful!
                                                        </div>
                                                        <div class="tab-pane active" id="tab1">
                                                            <h3 class="block">Provide your account details</h3>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">
                                                                    Descrição
                                                                        <span class="required">* </span>
                                                                </label>
                                                                <div class="col-md-4">
                                                                    <input type="text" class="form-control" name="description" id="description" />
                                                                    <span class="help-block">Informe a descrição da pergunta </span>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">
                                                                    Status
                                                                        <span class="required">* </span>
                                                                </label>
                                                                <div class="col-md-4">
                                                                    <div class="radio-list">
                                                                        <label>
                                                                            <input type="radio" name="status" value="True" data-title="Ativo" />
                                                                            Ativo
                                                                        </label>
                                                                        <label>
                                                                            <input type="radio" name="status" value="False" data-title="Inativo" />
                                                                            Inativo
                                                                        </label>
                                                                    </div>
                                                                    <div id="form_gender_error"></div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="tab-pane" id="tab2">
                                                            <h3 class="block">Provide your profile details</h3>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">
                                                                    Fullname
                                                                        <span class="required">* </span>
                                                                </label>
                                                                <div class="col-md-4">
                                                                    <input type="text" class="form-control" name="fullname" />
                                                                    <span class="help-block">Provide your fullname </span>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">
                                                                    Phone Number
                                                                        <span class="required">* </span>
                                                                </label>
                                                                <div class="col-md-4">
                                                                    <input type="text" class="form-control" name="phone" />
                                                                    <span class="help-block">Provide your phone number </span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="tab-pane" id="tab3">
                                                            <h3 class="block">Confirm your account</h3>
                                                            <h4 class="form-section">Account</h4>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Username:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="username"></p>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="tab-pane" id="tab4">
                                                            <h3 class="block">Confirm your account</h3>
                                                            <h4 class="form-section">Account</h4>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Username:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="username"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Email:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="email"></p>
                                                                </div>
                                                            </div>
                                                            <h4 class="form-section">Profile</h4>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Fullname:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="fullname"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Gender:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="gender"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Phone:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="phone"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Address:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="address"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">City/Town:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="city"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Country:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="country"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Remarks:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="remarks"></p>
                                                                </div>
                                                            </div>
                                                            <h4 class="form-section">Billing</h4>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Card Holder Name:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="card_name"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Card Number:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="card_number"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">CVC:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="card_cvc"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Expiration:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="card_expiry_date"></p>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Payment Options:</label>
                                                                <div class="col-md-4">
                                                                    <p class="form-control-static" data-display="payment[]"></p>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="form-actions">
                                                    <div class="row">
                                                        <div class="col-md-offset-3 col-md-9">
                                                            <a href="javascript:;" class="btn default button-previous">
                                                                <i class="fa fa-angle-left"></i>Back </a>
                                                            <a href="javascript:;" class="btn btn-outline green button-next">Continue
                                                                    <i class="fa fa-angle-right"></i>
                                                            </a>
                                                            <a href="javascript:;" class="btn green button-submit">Submit
                                                                    <i class="fa fa-check"></i>
                                                            </a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
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
                                            <table data-toggle="table" data-url="../assets/global/plugins/bootstrap-table/data/data1.json" id="questions-grid" data-height="299" data-show-refresh="true" data-show-toggle="true" data-show-columns="true" data-search="false">

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
                                            <span class="caption-subject bold uppercase">Crie a sua pergunta</span>
                                        </div>
                                    </div>
                                    <div class="portlet-body form">
                                        <form role="form">
                                            <div class="form-body">
                                                <div class="form-group">
                                                    <label>Descrição</label>
                                                    <input type="hidden" name="description" id="question_id" class="form-control" />
                                                    <input type="text" name="description" id="description" class="form-control" placeholder="Escreva aqui a descrição" />
                                                </div>
                                                <div class="form-group">
                                                    <div class="col-md-6">
                                                        <label>Análise:</label>
                                                        <div class="mt-radio-list" style="margin-left: 50px">
                                                            <label class="mt-radio">
                                                                Tipo 1
	                                                            <input type="radio" value="1" name="type" />
                                                                <span></span>
                                                            </label>
                                                            <label class="mt-radio">
                                                                Tipo 2
	                                                            <input type="radio" value="2" name="type" />
                                                                <span></span>
                                                            </label>
                                                            <label class="mt-radio">
                                                                Tipo 3
	                                                            <input type="radio" value="3" name="type" />
                                                                <span></span>
                                                            </label>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <label>Status:</label>
                                                        <div class="mt-radio-list" style="margin-left: 50px">
                                                            <label class="mt-radio">
                                                                Ativo
	                                                            <input type="radio" value="True" name="status" />
                                                                <span></span>
                                                            </label>
                                                            <label class="mt-radio">
                                                                Cancelado
	                                                            <input type="radio" value="False" name="status" />
                                                                <span></span>
                                                            </label>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <div class="row">
                                                        <div class="col-md-12" id="fields_div">
                                                            <input type="text" name="resposta1" id="resposta1" class="form-control" placeholder="Resposta 1" />

                                                        </div>
                                                        <div class="col-md-12" id="answer2" hidden>
                                                            <br />
                                                            <input type="text" name="resposta2" id="resposta2" class="form-control" placeholder="Resposta 2" />
                                                        </div>

                                                        <div class="col-md-12" id="answer3" hidden>
                                                            <br />
                                                            <input type="text" name="resposta3" id="resposta3" class="form-control" placeholder="Resposta 3" />
                                                        </div>

                                                        <div class="col-md-12" id="answer4" hidden>
                                                            <br />
                                                            <input type="text" name="resposta4" id="resposta4" class="form-control" placeholder="Resposta 4" />
                                                        </div>

                                                        <div class="col-md-12" id="answer5" hidden>
                                                            <br />
                                                            <input type="text" name="resposta5" id="resposta5" class="form-control" placeholder="Resposta 5" />
                                                        </div>
                                                        <div class="col-md-12">
                                                            <br />
                                                            <button class="btn green add_field" type="button">+</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="form-actions">
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
    <script type="text/javascript" src="js/questions.js"></script>
    <script type="text/javascript" src="js/charts.js"></script>
</asp:Content>
