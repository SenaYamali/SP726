<%@ Page Title="Sinema" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sinema.aspx.cs" Inherits="asp_ders1.sinema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section style="filmler_section">
        <asp:datalist id="DataList_Filmler" runat="server" Height="131px" OnDeleteCommand="DataList_Filmler_DeleteCommand" Width="748px" OnEditCommand="DataList_Filmler_EditCommand" OnCancelCommand="DataList_Filmler_CancelCommand" OnUpdateCommand="DataList_Filmler_UpdateCommand">

            <HeaderTemplate><table border="1" > </HeaderTemplate>

            <ItemTemplate>
                    <%# Eval("FilmID") %></td>
                    <td><%# Eval("FilmAdi") %></td>
                    <td><%# Eval("FilmKisaBilgi") %></td>
                    <td><%# Eval("FilmFragmanLink") %></td>
                    <td>
                        <asp:LinkButton ID="btn_Guncelle" runat="server" CommandName="Edit">Güncelle</asp:LinkButton> 

                    </td>
                    <td>
                        <asp:LinkButton ID="btn_Sil" runat="server" CommandName="Delete" CommandArgument='<%# Eval("FilmID") %>'>Sil</asp:LinkButton> 

                    </td>
                </tr>

            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txt_GuncelleID" runat="server" ReadOnly="true" text='<%# Eval("FilmID") %>'></asp:TextBox>
               
                    </td>
                     <td>
                         <asp:TextBox ID="txt_Guncelle_FilmAdi" runat="server" Text='<%# Eval("FilmAdi") %>'></asp:TextBox>

                     </td>
                     <td>
                         <asp:TextBox ID="txt_Guncelle_FilmKısaBilgi" runat="server" Text='<%# Eval("FilmKisaBilgi") %>'></asp:TextBox>

                     </td>
                     <td>
                         <asp:TextBox ID="txt_Guncelle_FilmFragmanLink" runat="server" Text='<%# Eval("FilmFragmanLink") %>'></asp:TextBox>

                     </td>  
                    <td>
                        <asp:Button ID="LinkButton1" runat="server" CommandName="Update" CommandArgument='<%# Eval("FilmID") %>' Text="Kaydet" /></td>
                    <td>
                    <asp:Button ID="LinkButton2" runat="server" CommandName="Cancel" Text="İptal" /></td> 
                     </tr>
            </EditItemTemplate>
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
