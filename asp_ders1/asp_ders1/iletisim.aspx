<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="asp_ders1.iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            background-color: #d55fc4;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="IMG/cikartmalar-iletisim-web-vektor-ikonlar-ayarlayin.jpg.jpg" style="float: left; width:150px;" />
    <span style="float: left">
        <input id="ad" type="text"/>
        <input id="email" type="email" />
        <textarea id="mesaj"> </textarea>
        <button type="submit">Gönder</button>
    </span>
</asp:Content>
