namespace LINQ
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_no = new System.Windows.Forms.Label();
            this.label_bolum = new System.Windows.Forms.Label();
            this.label_fak = new System.Windows.Forms.Label();
            this.textBox_no = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_fak = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ad.Location = new System.Drawing.Point(19, 230);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(41, 17);
            this.label_ad.TabIndex = 1;
            this.label_ad.Text = "Adı :";
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_no.Location = new System.Drawing.Point(19, 204);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(79, 17);
            this.label_no.TabIndex = 2;
            this.label_no.Text = "Numara : ";
            // 
            // label_bolum
            // 
            this.label_bolum.AutoSize = true;
            this.label_bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bolum.Location = new System.Drawing.Point(19, 259);
            this.label_bolum.Name = "label_bolum";
            this.label_bolum.Size = new System.Drawing.Size(67, 17);
            this.label_bolum.TabIndex = 3;
            this.label_bolum.Text = "Bolum : ";
            // 
            // label_fak
            // 
            this.label_fak.AutoSize = true;
            this.label_fak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_fak.Location = new System.Drawing.Point(19, 292);
            this.label_fak.Name = "label_fak";
            this.label_fak.Size = new System.Drawing.Size(76, 17);
            this.label_fak.TabIndex = 4;
            this.label_fak.Text = "Fakulte : ";
            // 
            // textBox_no
            // 
            this.textBox_no.Location = new System.Drawing.Point(157, 203);
            this.textBox_no.Name = "textBox_no";
            this.textBox_no.Size = new System.Drawing.Size(100, 20);
            this.textBox_no.TabIndex = 5;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(157, 230);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_ad.TabIndex = 6;
            // 
            // textBox_fak
            // 
            this.textBox_fak.Location = new System.Drawing.Point(157, 292);
            this.textBox_fak.Name = "textBox_fak";
            this.textBox_fak.Size = new System.Drawing.Size(100, 20);
            this.textBox_fak.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(11, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(101, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(182, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bilgisayar",
            "Edebiyat",
            "Matematik",
            "Fizik",
            "Coğrafya",
            "Hemşirelik"});
            this.comboBox1.Location = new System.Drawing.Point(136, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 390);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_fak);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.textBox_no);
            this.Controls.Add(this.label_fak);
            this.Controls.Add(this.label_bolum);
            this.Controls.Add(this.label_no);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label_bolum;
        private System.Windows.Forms.Label label_fak;
        private System.Windows.Forms.TextBox textBox_no;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_fak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

