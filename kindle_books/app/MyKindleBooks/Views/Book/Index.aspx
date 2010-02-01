<%@ Page Title="" Language="C#" 
         MasterPageFile="~/Views/Shared/Site.Master" 
         Inherits="System.Web.Mvc.ViewPage<MyKindleBooks.Models.Book_ViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    
    <form method="post">
        Author: <input type="text" name="authorName" />
                <input type="submit" value="Search By Auhor" />
    </form>
    
    <% if (Model.showAuthorLabel) { %>
        <div id="authorLabel"><%= Model.authorLabel %></div>
    <% } %>
    
    <% foreach (var book in Model.AllBooks)
       { %>
        <div class="bookListing">
            <span class="bookTitle"><%= book.Title%></span>,
            <span class="bookAuthor"><%= book.Author %></span>,
            <span class="bookOrderDate"><%= book.OrderDate.ToShortDateString() %></span>
        </div>
        
        <% } %>
    
</asp:Content>
