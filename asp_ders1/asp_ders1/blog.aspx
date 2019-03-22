<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="asp_ders1.blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:label runat="server" text="Yazı Başlığı"></asp:label>
        <br />
        <asp:textbox class="blog-input" id="txt_blog_baslik" runat="server" placeholder="Başlık"></asp:textbox>
        <br />
        <asp:label runat="server" text="Yazı İçeriği"></asp:label>

        <asp:textbox class="blog-input" id="txt_blog_icerik"  runat="server"  placholder="Başlık"></asp:textbox>

    </div>

</asp:Content>
