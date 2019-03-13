<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="asp_ders1.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body{

            background-color:#d55fc4;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="img_section">
        <img src="C:\Users\sena.yamali\Source\Repos\SenaYamali\SP726\WEB\Asp.net blog\resources\img" />
    </section>
    <input id="ad" type="text"/>
    <input id="email" type="email"/>
    <textarea id="mesaj" ></textarea>
    <button type="submit">Gönder</button>
</asp:Content>
