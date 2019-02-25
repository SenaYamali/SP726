namespace soru_form552
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_gncl = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ogrenci_sil = new System.Windows.Forms.Button();
            this.btn_ogrenci_ekle = new System.Windows.Forms.Button();
            this.btn_ogrncı_gncl = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_ogrenci_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.btn_gncl);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 161);
            this.panel1.TabIndex = 0;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(76, 133);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(115, 104);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_gncl
            // 
            this.btn_gncl.Location = new System.Drawing.Point(27, 104);
            this.btn_gncl.Name = "btn_gncl";
            this.btn_gncl.Size = new System.Drawing.Size(75, 23);
            this.btn_gncl.TabIndex = 5;
            this.btn_gncl.Text = "GÜNCELLE";
            this.btn_gncl.UseVisualStyleBackColor = true;
            this.btn_gncl.Click += new System.EventHandler(this.btn_gncl_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(73, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(117, 34);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(73, 20);
            this.txt_ad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOĞUM TARİHİ  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRETMEN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ogrenci_sil);
            this.panel2.Controls.Add(this.btn_ogrenci_ekle);
            this.panel2.Controls.Add(this.btn_ogrncı_gncl);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.txt_ogrenci_ad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(24, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 134);
            this.panel2.TabIndex = 1;
            // 
            // btn_ogrenci_sil
            // 
            this.btn_ogrenci_sil.Location = new System.Drawing.Point(58, 108);
            this.btn_ogrenci_sil.Name = "btn_ogrenci_sil";
            this.btn_ogrenci_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrenci_sil.TabIndex = 11;
            this.btn_ogrenci_sil.Text = "SİL";
            this.btn_ogrenci_sil.UseVisualStyleBackColor = true;
            this.btn_ogrenci_sil.Click += new System.EventHandler(this.btn_ogrenci_sil_Click);
            // 
            // btn_ogrenci_ekle
            // 
            this.btn_ogrenci_ekle.Location = new System.Drawing.Point(113, 75);
            this.btn_ogrenci_ekle.Name = "btn_ogrenci_ekle";
            this.btn_ogrenci_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrenci_ekle.TabIndex = 8;
            this.btn_ogrenci_ekle.Text = "EKLE";
            this.btn_ogrenci_ekle.UseVisualStyleBackColor = true;
            this.btn_ogrenci_ekle.Click += new System.EventHandler(this.btn_ogrenci_ekle_Click);
            // 
            // btn_ogrncı_gncl
            // 
            this.btn_ogrncı_gncl.Location = new System.Drawing.Point(6, 75);
            this.btn_ogrncı_gncl.Name = "btn_ogrncı_gncl";
            this.btn_ogrncı_gncl.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrncı_gncl.TabIndex = 10;
            this.btn_ogrncı_gncl.Text = "GÜNCELLE";
            this.btn_ogrncı_gncl.UseVisualStyleBackColor = true;
            this.btn_ogrncı_gncl.Click += new System.EventHandler(this.btn_ogrncı_gncl_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Mezun mu?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(115, 30);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(73, 20);
            this.txt_ogrenci_ad.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ADI : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ÖĞRENCİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 145);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(252, 194);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(266, 134);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 391);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_gncl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ogrenci_sil;
        private System.Windows.Forms.Button btn_ogrenci_ekle;
        private System.Windows.Forms.Button btn_ogrncı_gncl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_ogrenci_ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

