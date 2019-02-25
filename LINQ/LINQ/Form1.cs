using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        ODEV3_DataContext ct = new ODEV3_DataContext();
        private object ogrenci1;
        private object textbox_no;
        private object ogretmen1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = ct.Ogrencis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrenciNumara = textBox_no.Text;
            ogrenci1.OgrenciAdSoyad = textBox_ad.Text;
            ogrenci1.OgrenciBolum = comboBox1.Text;
            ogrenci1.OgrenciFakulte = textBox_fak.Text;

            ct.Ogrencis.InsertOnSubmit(ogrenci1);
            ct.SubmitChanges();
            dataGridView1.DataSource = ct.Ogrencis;
            MessageBox.Show("Kayıt İşlemi Başarılı");
            ODEV3_DataContext cttc = new ODEV3_DataContext();
            dataGridView1.DataSource = cttc.Ogrencis;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox_no.Tag = satir.Cells["OgrenciNumara"].Value;
            textBox_ad.Text = satir.Cells["OgrenciAdSoyad"].Value.ToString();
            comboBox1.Text = satir.Cells["OgrenciBolum"].Value.ToString();
            textBox_fak.Text = satir.Cells["OgrenciFakulte"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = (string)textBox_no.Tag;
            Ogrenci ogrenci1 = ct.Ogrencis.SingleOrDefault(Ogrenci => Ogrenci.OgrenciNumara == ID);
            ct.Ogrencis.Single(ogrenci => ogrenci.OgrenciNumara == ID);
            ogrenci1.OgrenciAdSoyad = textBox_ad.Text;
            ogrenci1.OgrenciBolum = comboBox1.Text;
            ogrenci1.OgrenciFakulte = textBox_fak.Text;
            ct.SubmitChanges();
            MessageBox.Show("Güncelleme Başarılı");
            ODEV3_DataContext cttc = new ODEV3_DataContext();
            dataGridView1.DataSource = cttc.Ogrencis;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = (string)textBox_no.Tag;
            Ogrenci ogrenci1 = ct.Ogrencis.SingleOrDefault(ogrenci => ogrenci.OgrenciNumara == ID);
            ct.Ogrencis.DeleteOnSubmit(ogrenci1);
            ct.SubmitChanges();
            dataGridView1.DataSource = ct.Ogrencis;
            MessageBox.Show("Silme işlemi Başarılı");
            ODEV3_DataContext cttc = new ODEV3_DataContext();
            dataGridView1.DataSource = cttc.Ogrencis;
        }
    }
}
