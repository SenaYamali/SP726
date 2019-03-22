using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_ders1
{
    public partial class salon : System.Web.UI.Page
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
            DataList_Salonlar.DataSource = ctx.Salons.ToList();
            DataList_Salonlar.DataBind();
        }

        protected void btn_SalonKaydet_Click(object sender, EventArgs e)
        {
            Salon s1 = new Salon();
            s1.SalonAdi = txt_SalonAd.Text;
            SINEMAEntities ctx = new SINEMAEntities();
            ctx.Salons.Add(s1);
            ctx.SaveChanges();
            TabloGuncelle();
        }

        protected void DataList_Salonlar_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int txtSalonId = Convert.ToInt32(e.CommandArgument);
            SINEMAEntities ctx = new SINEMAEntities();
            Salon s1 = ctx.Salons.Find(txtSalonId);
            ctx.Salons.Remove(s1);
            ctx.SaveChanges();
            TabloGuncelle();
        }

        protected void DataList_Salonlar_EditCommand(object source, DataListCommandEventArgs e)
        {
            DataList_Salonlar.EditItemIndex = e.Item.ItemIndex;
            TabloGuncelle();
        }

        protected void DataList_Salonlar_CancelCommand(object source, DataListCommandEventArgs e)
        {
            DataList_Salonlar.EditItemIndex = -1;
            TabloGuncelle();
        }

        protected void DataList_Salonlar_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            int txtSID = Convert.ToInt32(e.CommandArgument);
            TextBox txtSalonAd = e.Item.FindControl("txt_salon_gun_salonAd") as TextBox;

            SINEMAEntities ctx = new SINEMAEntities();
         Salon s1 = ctx.Salons.Find(txtSID);
            s1.SalonID = txtSID;
            s1.SalonAdi = txtSalonAd.Text;
       
            ctx.SaveChanges();
            DataList_Salonlar.EditItemIndex = -1;
            TabloGuncelle();

        }
    }
}