<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	All
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    Все курсы для обучения

    <% foreach (var course in Model){ %>
    <div class="course">
        <h3><%= course.ID %></h3>
        <%= course.Name %>
        <%= Html.ActionLink((string)course.Name, (string)("Detail/" + course.ID.ToString()), "Courses")%>
        <%: Html.ActionLink("Список уроков", "Index", "Lessons", new { courseID = course.ID }, null)%>
    </div>
    <%   } %>

</asp:Content>
