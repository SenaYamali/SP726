<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="salon.aspx.cs" Inherits="asp_ders1.salon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<section class="filmler_section">

    <asp:DataList ID="DataList_Salonlar" runat="server">
    <HeaderTemplate><table border="1" > </HeaderTemplate>

            <ItemTemplate>

                <tr>
                    <td><%# Eval("SalonID") %></td>
                    <td><%# Eval("SalonAdi") %></td>
                </tr>

            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:DataList>
       <section class="salon_kaydet_section">
        <asp:textbox id="txt_SalonAd" runat="server"  placeholder="Salon Adı"></asp:textbox>
        <asp:button id="btn_SalonKaydet" runat="server" text="Kaydet" OnClick="btn_SalonKaydet_Click" />
      
    </section>
</section>
</asp:Content>
