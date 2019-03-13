<%@ Page Title="Sinema" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sinema.aspx.cs" Inherits="asp_ders1.sinema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section style="filmler_section">
        <asp:datalist id="DataList_Filmler" runat="server">

            <HeaderTemplate><table border="1" > </HeaderTemplate>

            <ItemTemplate>

                <tr>
                    <td><%# Eval("FilmID") %></td>
                    <td><%# Eval("FilmAdi") %></td>
                    <td><%# Eval("FilmKisaBilgi") %></td>
                    <td><%# Eval("FilmFragmanLink") %></td>
                </tr>

            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:datalist>
    </section>
    <section class="film_kaydet_section">
        <asp:textbox id="txt_FilmAd" runat="server"  placeholder="Film Adı"></asp:textbox>
        <asp:textbox  id="txt_FilmFragman" runat="server" placeholder="Film Fragmanı"></asp:textbox>
        <asp:textbox  id="txt_FilmKısaBilgi" runat="server" placeholder="Film Özeti"></asp:textbox>
        <asp:button id="btn_FilmKaydet" runat="server" text="Kaydet" OnClick="btn_FilmKaydet_Click" />
      
    </section>
</asp:Content>
