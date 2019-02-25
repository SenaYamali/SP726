using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Projesi
{
    public partial class Form1 : Form
    {
        Sinema_VTDataContext svt = new Sinema_VTDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_flmad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film film1 = new Film();
            film1.FilmAdi = txt_flmad.Text;
            
           
            svt.Films.InsertOnSubmit(film1);
           
           
            svt.SubmitChanges();
            MessageBox.Show("Kayıt Tamamlandı.");
        }

        private void button_sln_Click(object sender, EventArgs e)
        {
            Salon sln1 = new Salon();
            sln1.SalonAdi = txt_sln.Text;
            svt.Salons.InsertOnSubmit(sln1);
            svt.SubmitChanges();
            MessageBox.Show("Kayıt Tamamlandı.");

        }

        private void button_yayin_Click(object sender, EventArgs e)
        {
            FilmYayin filmYayın1 = new FilmYayin();
            filmYayın1.FYZaman = dateTimePicker1.Value;
            svt.FilmYayins.InsertOnSubmit(filmYayın1);
            svt.SubmitChanges();
            MessageBox.Show("Kayıt Tamamlandı.");
        }
    }
}
