<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MyKindleBooks.Models.Category_ViewModel>" %>
<%@ Import Namespace="MyKindleBooks.Domain"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Category
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Category</h2>
    
    <% foreach (var category in Model.AllCategories) { %>
        <div class="category"><%= category.Name %></div>
        
    <% } %>

<hr />    
    <% foreach (var subcategory in Model.AllSubcategories) { %>
        <div class="subcategory"><%= subcategory.Name%></div>
   <% } %>

</asp:Content>
