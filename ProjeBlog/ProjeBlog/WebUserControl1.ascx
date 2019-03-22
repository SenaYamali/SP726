<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="ProjeBlog.WebUserControl1" %>
<ul class="ustNavUl">
    <li><asp:HyperLink ID="LinkAnasayfa" runat="server" NavigateUrl="~/index.aspx">Anasayfa</asp:HyperLink></li>
    <li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/hakkımızda.aspx">Sinema</asp:HyperLink></li>
    <li><asp:HyperLink ID="LinkBlog" runat="server" NavigateUrl="~/blog.aspx">Blog</asp:HyperLink></li>
    <li><asp:HyperLink ID="LinkIletisim" runat="server" NavigateUrl="~/iletisim.aspx">İletişim</asp:HyperLink></li>
</ul>
