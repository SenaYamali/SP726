namespace Sinema_Projesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_flmad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sln = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ad = new System.Windows.Forms.Button();
            this.button_sln = new System.Windows.Forms.Button();
            this.button_yayin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FİLM EKLEME OTOMASYONU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Adı Giriniz : ";
            // 
            // txt_flmad
            // 
            this.txt_flmad.Location = new System.Drawing.Point(259, 75);
            this.txt_flmad.Name = "txt_flmad";
            this.txt_flmad.Size = new System.Drawing.Size(100, 20);
            this.txt_flmad.TabIndex = 2;
            this.txt_flmad.TextChanged += new System.EventHandler(this.txt_flmad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salon Giriniz :";
            // 
            // txt_sln
            // 
            this.txt_sln.Location = new System.Drawing.Point(259, 114);
            this.txt_sln.Name = "txt_sln";
            this.txt_sln.Size = new System.Drawing.Size(100, 20);
            this.txt_sln.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yayın Tarihi Seçiniz :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(259, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // button_ad
            // 
            this.button_ad.Location = new System.Drawing.Point(551, 72);
            this.button_ad.Name = "button_ad";
            this.button_ad.Size = new System.Drawing.Size(75, 23);
            this.button_ad.TabIndex = 8;
            this.button_ad.Text = "Kaydet";
            this.button_ad.UseVisualStyleBackColor = true;
            this.button_ad.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_sln
            // 
            this.button_sln.Location = new System.Drawing.Point(551, 109);
            this.button_sln.Name = "button_sln";
            this.button_sln.Size = new System.Drawing.Size(75, 23);
            this.button_sln.TabIndex = 9;
            this.button_sln.Text = "Kaydet";
            this.button_sln.UseVisualStyleBackColor = true;
            this.button_sln.Click += new System.EventHandler(this.button_sln_Click);
            // 
            // button_yayin
            // 
            this.button_yayin.Location = new System.Drawing.Point(551, 148);
            this.button_yayin.Name = "button_yayin";
            this.button_yayin.Size = new System.Drawing.Size(75, 23);
            this.button_yayin.TabIndex = 10;
            this.button_yayin.Text = "Kaydet";
            this.button_yayin.UseVisualStyleBackColor = true;
            this.button_yayin.Click += new System.EventHandler(this.button_yayin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 465);
            this.Controls.Add(this.button_yayin);
            this.Controls.Add(this.button_sln);
            this.Controls.Add(this.button_ad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sln);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_flmad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_flmad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sln;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ad;
        private System.Windows.Forms.Button button_sln;
        private System.Windows.Forms.Button button_yayin;
    }
}

