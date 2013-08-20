<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 id="selResult" runat="server" ></h2>
    
    <h2>
        Select your Favorite color</h2>
        
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        
    </p>
    <div style="width:40%">
   <ul id="unselected" runat="server">
    
   </ul> 
   </div>  
    <p>
        &nbsp;</p>
</asp:Content>
