<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="salon.aspx.cs" Inherits="asp_ders1.salon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<section class="filmler_section">

    <asp:DataList ID="DataList_Salonlar" runat="server" OnCancelCommand="DataList_Salonlar_CancelCommand" OnDeleteCommand="DataList_Salonlar_DeleteCommand" OnEditCommand="DataList_Salonlar_EditCommand" OnUpdateCommand="DataList_Salonlar_UpdateCommand">
    <HeaderTemplate><table border="1" > </HeaderTemplate>

            <ItemTemplate>

                <tr>
                    <td><%# Eval("SalonID") %></td>
                    <td><%# Eval("SalonAdi") %></td>
                    <td>
                        <asp:Button ID="btn_salon_guncelle" runat="server"  CommandName="Edit" Text="Güncelle" />
                        </td>
                    <td>
                        <asp:Button ID="btn_salon_sil" runat="server" CommandName="Delete" CommandArgument='<%# Eval("SalonID") %>' Text="Sil" />
                        </td>
                </tr>

            </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txt_salon_gun_id" runat="server" ReadOnly="true" text='<%# Eval("SalonID") %>'></asp:TextBox>
                </td>
            <td>
                <asp:TextBox ID="txt_salon_gun_salonAd" runat="server" Text='<%# Eval("SalonAdi") %>'></asp:TextBox>
            </td>
            <td>
                 <asp:Button ID="Button2" runat="server" CommandName="Update" CommandArgument='<%# Eval("SalonID") %>' Text="Kaydet" />
              
            </td>
            <td>
                 <asp:Button ID="Button1" runat="server" CommandName="Cancel" Text="İptal" />
            </td>
            </tr>
        </EditItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:DataList>
       <section class="salon_kaydet_section">
        <asp:textbox id="txt_SalonAd" runat="server"  placeholder="Salon Adı"></asp:textbox>
        <asp:button id="btn_SalonKaydet" runat="server" text="Kaydet" OnClick="btn_SalonKaydet_Click" />
      
    </section>
</section>
</asp:Content>
