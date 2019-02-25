using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_form552
{
    
    public partial class Form1 : Form
    {
        private object ovt;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Okul_VTEntities ovt = new Okul_VTEntities();
            dataGridView1.DataSource = ovt.Ogretmenlers.ToList();
            dataGridView2.DataSource = ovt.Ogrencilers.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Okul_VTEntities ovt = new Okul_VTEntities();
            Ogretmenler ogrtmn = new Ogretmenler();
            ogrtmn.OgretmenAdi = txt_ad.Text;
            ogrtmn.DogumTarihi = dateTimePicker1.Value;

            ovt.Ogretmenlers.Add(ogrtmn);
            ovt.SaveChanges();
            dataGridView1.DataSource = ovt.Ogretmenlers.ToList();
            MessageBox.Show(ogrtmn.OgretmenID.ToString());
        }

        private void btn_gncl_Click(object sender, EventArgs e)
        {
            Okul_VTEntities ovt = new Okul_VTEntities();
            int ogretmenID = Convert.ToInt32(txt_ad.Tag);
            var ogrtmn = ovt.Ogretmenlers.Find(ogretmenID);
            ogrtmn.OgretmenAdi = txt_ad.Text;
            ogrtmn.DogumTarihi = dateTimePicker1.Value;
            dataGridView1.DataSource = ovt.Ogretmenlers.ToList();
            MessageBox.Show(ogrtmn.OgretmenAdi.ToString());


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ad.Tag = dataGridView1.CurrentRow.Cells[0].Value;
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value == "" || dataGridView1.CurrentRow.Cells[2].Value == null)
            {
                dateTimePicker1.Value = DateTime.Now;

            }
            else {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Okul_VTEntities ovt = new Okul_VTEntities();
            int ogretmenID = Convert.ToInt32(txt_ad.Tag);
            Ogretmenler ogrtmn = ovt.Ogretmenlers.Find(ogretmenID);
            ovt.Ogretmenlers.Remove(ogrtmn);
            ovt.SaveChanges();
            dataGridView1.DataSource = ovt.Ogretmenlers.ToList();

        }

        private void btn_ogrncı_gncl_Click(object sender, EventArgs e)
        {
            Okul_VTEntities ovt = new Okul_VTEntities();
            int ogrenciID = Convert.ToInt32(txt_ogrenci_ad.Tag);
                   Ogrenciler ogrnci = ovt.Ogrencilers.Find(ogrenciID);
            ogrnci.OgrenciAdi = txt_ogrenci_ad.Text;
            ogrnci.Mezun = checkBox1.Checked;
     
            ovt.SaveChanges();
            dataGridView2.DataSource = ovt.Ogrencilers.ToList(); 
            MessageBox.Show(ogrnci.OgrenciID.ToString());


        }

        private void btn_ogrenci_ekle_Click(object sender, EventArgs e)
        {
            Okul_VTEntities ovt = new Okul_VTEntities();
            Ogrenciler ogrnci = new Ogrenciler();
            ogrnci.OgrenciAdi = txt_ogrenci_ad.Text;
            ogrnci.Mezun = checkBox1.Checked;

            ovt.Ogrencilers.Add(ogrnci);
            ovt.SaveChanges();
            dataGridView2.DataSource = ovt.Ogrencilers.ToList();
            MessageBox.Show(ogrnci.OgrenciID.ToString());

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ogrenci_ad.Tag = dataGridView2.CurrentRow.Cells[0].Value;
            txt_ogrenci_ad.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(dataGridView2.CurrentRow.Cells[2].Value);
        }

        private void btn_ogrenci_sil_Click(object sender, EventArgs e)
        {
            Okul_VTEntities ovt = new Okul_VTEntities();
            int ogrenciID = Convert.ToInt32(txt_ogrenci_ad.Tag);
            Ogrenciler ogrnci = ovt.Ogrencilers.Find(ogrenciID);
            ovt.Ogrencilers.Remove(ogrnci);
            ovt.SaveChanges();
            dataGridView2.DataSource = ovt.Ogrencilers.ToList();
        }
    }
}
