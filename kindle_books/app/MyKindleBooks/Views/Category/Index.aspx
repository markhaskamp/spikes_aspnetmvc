
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MyKindleBooks.Models.Category_ViewModel>" %>
<%@ Import Namespace="MyKindleBooks.Domain"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Category
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src="/Scripts/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="/Scripts/js/jquery-ui-1.7.2.custom.min.js"></script>
    <script type="text/javascript" src="/Scripts/js/categoryIndex.js"></script>
    <script type="text/javascript" src="/Scripts/js/EventAggregator.js"></script>

    <h2>Category</h2>
    
    <div id="accordion">
    <% foreach (var category in Model.AllCategories) { %>
        <div class="category"><%= category.Name %></div>

        <div class="subcategoryContainer">
        <% foreach (var sc in category.Subcategories) { %>
          <div class="subcategory"><%= sc.Name%></div>
        <% } %>     
        </div>
        
    <% } %>
    </div>
    
    <form action="#">
        <input type="text" id="txtActivateNdx" />
        <input type="button" id="btnActivateNdx" value="Activate" />
    </form>

</asp:Content>
