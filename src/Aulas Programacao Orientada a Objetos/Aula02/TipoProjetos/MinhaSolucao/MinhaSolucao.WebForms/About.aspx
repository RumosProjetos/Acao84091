<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MinhaSolucao.WebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>
        <p>&nbsp;</p>
        <p>
            <asp:Button runat="server" Text="Button" ID="btnFuncao" OnClick="btnFuncao_Click"></asp:Button><asp:TextBox runat="server" ID="txtTexto"></asp:TextBox>&nbsp;</p><asp:Label runat="server" Text="Label" ID="lblTexto"></asp:Label>
        <p>&nbsp;</p>
    </main>
</asp:Content>
