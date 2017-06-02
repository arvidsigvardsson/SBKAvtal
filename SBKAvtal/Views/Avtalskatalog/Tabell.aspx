<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SBKAvtal.Models.Avtalsmodel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Tabell
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Tabell</h2>

    <table class="table">
        <tr>
           
            <th>
                id
            </th>
            <th>
                Enligt avtal
            </th>
            
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            
            <td>
                <%: item.id %>
            </td>
            <td>
                <%: item.enligtAvtal %>
            </td>
            
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

