<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="EnumToDropDown._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Let's coding!
    </h2>
    <p>
       Selecione uma opção: <asp:DropDownList ID="ddlEnum" runat="server" /> <asp:Button ID="btnValorSelecionado" runat="server" Text="Ok" OnClick="btnValorSelecionado_Click" />
    </p>
    <p>
        Texto selecionado: <asp:Label ID="lblTextoSelecionado" runat="server" Font-Bold="true" />
        <br />
        Valor selecionado: <asp:Label ID="lblValorSelecionado" runat="server" Font-Bold="true" />
    </p>
</asp:Content>
