
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MyKindleBooks.Models.Category_ViewModel>" %>
<%@ Import Namespace="MyKindleBooks.Domain"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Category
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src="/Scripts/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="/Scripts/js/categoryIndex.js"></script>

    <h2>Category</h2>
    
    <% foreach (var category in Model.AllCategories) { %>
        <div class="category"><%= category.Name %></div>

        <div class="subcategoryContainer">
        <% foreach (var sc in category.Subcategories) { %>
          <div class="subcategory"><%= sc.Name%></div>
        <% } %>     
        </div>
        
    <% } %>

</asp:Content>
