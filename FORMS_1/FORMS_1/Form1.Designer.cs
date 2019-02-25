namespace FORMS_1
{
    partial class Form_AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AnaEkran));
            this.label_baslik = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_tc = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Dogum = new System.Windows.Forms.DateTimePicker();
            this.label_dogum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_baslik
            // 
            this.label_baslik.AutoSize = true;
            this.label_baslik.BackColor = System.Drawing.Color.Transparent;
            this.label_baslik.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_baslik.ForeColor = System.Drawing.Color.Crimson;
            this.label_baslik.Location = new System.Drawing.Point(96, 10);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(282, 34);
            this.label_baslik.TabIndex = 1;
            this.label_baslik.Text = "Kullanıcı Kayıt İşlemleri";
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(177, 64);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(8);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(122, 29);
            this.txt_ad.TabIndex = 2;
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad.ForeColor = System.Drawing.Color.Crimson;
            this.label_ad.Location = new System.Drawing.Point(49, 64);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(49, 24);
            this.label_ad.TabIndex = 3;
            this.label_ad.Text = "Ad :";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soyad.ForeColor = System.Drawing.Color.Crimson;
            this.label_soyad.Location = new System.Drawing.Point(34, 124);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(67, 24);
            this.label_soyad.TabIndex = 5;
            this.label_soyad.Text = "Soyad :";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(177, 119);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(8);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(122, 29);
            this.txt_Soyad.TabIndex = 4;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.button_kaydet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Location = new System.Drawing.Point(236, 449);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 31);
            this.button_kaydet.TabIndex = 6;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(17, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tc.ForeColor = System.Drawing.Color.Crimson;
            this.label_tc.Location = new System.Drawing.Point(34, 183);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(45, 24);
            this.label_tc.TabIndex = 9;
            this.label_tc.Text = "TC :";
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(177, 178);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(8);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(122, 29);
            this.txt_tc.TabIndex = 8;
            // 
            // dateTimePicker_Dogum
            // 
            this.dateTimePicker_Dogum.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.dateTimePicker_Dogum.CustomFormat = "";
            this.dateTimePicker_Dogum.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Dogum.Location = new System.Drawing.Point(178, 228);
            this.dateTimePicker_Dogum.Name = "dateTimePicker_Dogum";
            this.dateTimePicker_Dogum.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker_Dogum.TabIndex = 10;
            // 
            // label_dogum
            // 
            this.label_dogum.AutoSize = true;
            this.label_dogum.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dogum.ForeColor = System.Drawing.Color.Crimson;
            this.label_dogum.Location = new System.Drawing.Point(13, 228);
            this.label_dogum.Name = "label_dogum";
            this.label_dogum.Size = new System.Drawing.Size(132, 24);
            this.label_dogum.TabIndex = 12;
            this.label_dogum.Text = "Doğum Tarihi :";
            // 
            // Form_AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(558, 547);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.label_dogum);
            this.Controls.Add(this.dateTimePicker_Dogum);
            this.Controls.Add(this.label_tc);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label_baslik);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AnaEkran";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "404 ilk Form Uygulaması";
            this.Load += new System.EventHandler(this.Form_AnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Dogum;
        private System.Windows.Forms.Label label_dogum;
    }
}

