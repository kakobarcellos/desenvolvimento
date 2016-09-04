<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="column-with-rotated-series.aspx.cs" Inherits="AdminResearch.column_with_rotated_series" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <link rel="stylesheet" href="css/column-with-rotated-series.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceContainer" runat="server">
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <div id="chartdiv">
            </div>
        </div>
    </div>													
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
    <script type="text/javascript" src="js/charts.js"></script>
</asp:Content>
