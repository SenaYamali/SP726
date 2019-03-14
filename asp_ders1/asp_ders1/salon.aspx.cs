﻿using System;
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
    }
}