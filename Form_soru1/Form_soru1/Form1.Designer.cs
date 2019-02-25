namespace Form_soru1
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
            this.label_ad = new System.Windows.Forms.Label();
            this.label_parola = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_prl = new System.Windows.Forms.TextBox();
            this.button_grs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ad.Location = new System.Drawing.Point(32, 67);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(107, 17);
            this.label_ad.TabIndex = 0;
            this.label_ad.Text = "Kullanıcı Adı :";
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_parola.Location = new System.Drawing.Point(32, 130);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(65, 17);
            this.label_parola.TabIndex = 1;
            this.label_parola.Text = "Parola :";
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ad.Location = new System.Drawing.Point(207, 67);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_prl
            // 
            this.txt_prl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_prl.Location = new System.Drawing.Point(207, 130);
            this.txt_prl.Name = "txt_prl";
            this.txt_prl.PasswordChar = '*';
            this.txt_prl.Size = new System.Drawing.Size(100, 20);
            this.txt_prl.TabIndex = 3;
            // 
            // button_grs
            // 
            this.button_grs.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.button_grs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_grs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_grs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_grs.FlatAppearance.BorderSize = 5;
            this.button_grs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_grs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_grs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_grs.Location = new System.Drawing.Point(170, 199);
            this.button_grs.Name = "button_grs";
            this.button_grs.Size = new System.Drawing.Size(92, 36);
            this.button_grs.TabIndex = 4;
            this.button_grs.Text = "Giriş";
            this.button_grs.UseVisualStyleBackColor = false;
            this.button_grs.Click += new System.EventHandler(this.button_grs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 366);
            this.Controls.Add(this.button_grs);
            this.Controls.Add(this.txt_prl);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.label_ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_prl;
        private System.Windows.Forms.Button button_grs;
    }
}

