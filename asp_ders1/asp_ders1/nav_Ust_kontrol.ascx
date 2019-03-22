<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="nav_Ust_kontrol.ascx.cs" Inherits="asp_ders1.nav_Ust_kontrol" %>
<ul>
    <li><asp:HyperLink ID="LinkAnasayfa" runat="server" NavigateUrl="~/default.aspx">Anasayfa</asp:HyperLink></li>
    <li><asp:HyperLink ID="HyperSalon" runat="server" NavigateUrl="~/salon.aspx">Salon</asp:HyperLink></li>
    <li><asp:HyperLink ID="HyperSinema" runat="server" NavigateUrl="~/sinema.aspx">Sinema</asp:HyperLink></li>
    <li><asp:HyperLink ID="HyperBlog" runat="server" NavigateUrl="~/blog.aspx">Sinema</asp:HyperLink></li>
   <li><asp:HyperLink ID="Linkiletisim" runat="server" NavigateUrl="~/iletisim.aspx">İletişim</asp:HyperLink></li>

</ul>

