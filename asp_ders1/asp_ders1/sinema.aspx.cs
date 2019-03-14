using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_ders1
{
    public partial class sinema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
                return;
            TabloGuncelle();
        }

        private void TabloGuncelle()
        {
            SINEMAEntities ctx = new SINEMAEntities();
            DataList_Filmler.DataSource = ctx.Films.ToList();
            DataList_Filmler.DataBind();
        }

        protected void btn_FilmKaydet_Click(object sende,EventArgs e)
        {
            Film f1 = new Film();
            f1.FilmAdi = txt_FilmAd.Text;
            f1.FilmFragmanLink = txt_FilmFragman.Text;
            f1.FilmKisaBilgi = txt_FilmKısaBilgi.Text;
            SINEMAEntities ctx = new SINEMAEntities();
            ctx.Films.Add(f1);
            ctx.SaveChanges();
            TabloGuncelle();
        }

        protected void DataList_Filmler_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int txtFilmID = Convert.ToInt32(e.CommandArgument);
            SINEMAEntities ctx = new SINEMAEntities();
            Film f1 = ctx.Films.Find(txtFilmID);
            ctx.Films.Remove(f1);
            ctx.SaveChanges();
            TabloGuncelle();
        }

        protected void DataList_Filmler_EditCommand(object source, DataListCommandEventArgs e)
        {
            DataList_Filmler.EditItemIndex = e.Item.ItemIndex;
            TabloGuncelle();
        }

        protected void DataList_Filmler_CancelCommand(object source, DataListCommandEventArgs e)
        {
            DataList_Filmler.EditItemIndex = -1;
            TabloGuncelle();
        }

        protected void DataList_Filmler_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            int txtID = Convert.ToInt32(e.CommandArgument);
            TextBox txtFilmAd = e.Item.FindControl("txt_Guncelle_FilmAdi") as TextBox;
            TextBox txtFilmFragmanLink = e.Item.FindControl("txt_Guncelle_FilmFragmanLink") as TextBox;
            TextBox txtFilmKisaBilgi = e.Item.FindControl("txt_Guncelle_FilmKısaBilgi") as TextBox;

            SINEMAEntities ctx = new SINEMAEntities();
            Film f1 = ctx.Films.Find(txtID);
            f1.FilmID = txtID;
            f1.FilmAdi = txtFilmAd.Text;
            f1.FilmFragmanLink = txtFilmFragmanLink.Text;
            f1.FilmKisaBilgi = txtFilmKisaBilgi.Text;
            ctx.SaveChanges();
            DataList_Filmler.EditItemIndex = -1;
            TabloGuncelle();

        }
    }

}