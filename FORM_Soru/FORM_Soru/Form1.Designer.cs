namespace FORM_Soru
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
            this.label_no = new System.Windows.Forms.Label();
            this.label_ders = new System.Windows.Forms.Label();
            this.label_vize = new System.Windows.Forms.Label();
            this.label_final = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_ders = new System.Windows.Forms.TextBox();
            this.txt_vize = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.label_baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_no.Location = new System.Drawing.Point(58, 72);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(96, 20);
            this.label_no.TabIndex = 0;
            this.label_no.Text = "Ögrenci No :";
            // 
            // label_ders
            // 
            this.label_ders.AutoSize = true;
            this.label_ders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ders.Location = new System.Drawing.Point(58, 112);
            this.label_ders.Name = "label_ders";
            this.label_ders.Size = new System.Drawing.Size(82, 20);
            this.label_ders.TabIndex = 1;
            this.label_ders.Text = "Ders Adı : ";
            // 
            // label_vize
            // 
            this.label_vize.AutoSize = true;
            this.label_vize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_vize.Location = new System.Drawing.Point(58, 152);
            this.label_vize.Name = "label_vize";
            this.label_vize.Size = new System.Drawing.Size(52, 20);
            this.label_vize.TabIndex = 2;
            this.label_vize.Text = "Vize : ";
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_final.Location = new System.Drawing.Point(58, 197);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(55, 20);
            this.label_final.TabIndex = 3;
            this.label_final.Text = "Final : ";
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(170, 72);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(100, 20);
            this.txt_no.TabIndex = 4;
            // 
            // txt_ders
            // 
            this.txt_ders.Location = new System.Drawing.Point(170, 114);
            this.txt_ders.Name = "txt_ders";
            this.txt_ders.Size = new System.Drawing.Size(100, 20);
            this.txt_ders.TabIndex = 5;
            // 
            // txt_vize
            // 
            this.txt_vize.Location = new System.Drawing.Point(170, 152);
            this.txt_vize.Name = "txt_vize";
            this.txt_vize.Size = new System.Drawing.Size(100, 20);
            this.txt_vize.TabIndex = 6;
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(170, 197);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(100, 20);
            this.txt_final.TabIndex = 7;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(120, 261);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(75, 23);
            this.hesapla.TabIndex = 8;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // label_baslik
            // 
            this.label_baslik.AutoSize = true;
            this.label_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baslik.Location = new System.Drawing.Point(69, 9);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(201, 31);
            this.label_baslik.TabIndex = 9;
            this.label_baslik.Text = "Not Hesaplama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 345);
            this.Controls.Add(this.label_baslik);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.txt_vize);
            this.Controls.Add(this.txt_ders);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.label_final);
            this.Controls.Add(this.label_vize);
            this.Controls.Add(this.label_ders);
            this.Controls.Add(this.label_no);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label_ders;
        private System.Windows.Forms.Label label_vize;
        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_ders;
        private System.Windows.Forms.TextBox txt_vize;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label label_baslik;
    }
}

