namespace math_sınıfı
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblKok = new System.Windows.Forms.Label();
            this.lblYuvarla = new System.Windows.Forms.Label();
            this.lblAssagiYuvarla = new System.Windows.Forms.Label();
            this.lblYukariYuvarla = new System.Windows.Forms.Label();
            this.lblMutlak = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(14, 74);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(145, 39);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.Location = new System.Drawing.Point(193, 35);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(31, 18);
            this.lblUs.TabIndex = 1;
            this.lblUs.Text = "Üs:";
            // 
            // lblKok
            // 
            this.lblKok.AutoSize = true;
            this.lblKok.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKok.Location = new System.Drawing.Point(193, 69);
            this.lblKok.Name = "lblKok";
            this.lblKok.Size = new System.Drawing.Size(76, 18);
            this.lblKok.TabIndex = 2;
            this.lblKok.Text = "KareKök:";
            // 
            // lblYuvarla
            // 
            this.lblYuvarla.AutoSize = true;
            this.lblYuvarla.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYuvarla.Location = new System.Drawing.Point(193, 103);
            this.lblYuvarla.Name = "lblYuvarla";
            this.lblYuvarla.Size = new System.Drawing.Size(70, 18);
            this.lblYuvarla.TabIndex = 3;
            this.lblYuvarla.Text = "Yuvarla:";
            // 
            // lblAssagiYuvarla
            // 
            this.lblAssagiYuvarla.AutoSize = true;
            this.lblAssagiYuvarla.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssagiYuvarla.Location = new System.Drawing.Point(193, 137);
            this.lblAssagiYuvarla.Name = "lblAssagiYuvarla";
            this.lblAssagiYuvarla.Size = new System.Drawing.Size(127, 18);
            this.lblAssagiYuvarla.TabIndex = 4;
            this.lblAssagiYuvarla.Text = "Aşşağı Yuvarla:";
            // 
            // lblYukariYuvarla
            // 
            this.lblYukariYuvarla.AutoSize = true;
            this.lblYukariYuvarla.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYukariYuvarla.Location = new System.Drawing.Point(193, 171);
            this.lblYukariYuvarla.Name = "lblYukariYuvarla";
            this.lblYukariYuvarla.Size = new System.Drawing.Size(124, 18);
            this.lblYukariYuvarla.TabIndex = 5;
            this.lblYukariYuvarla.Text = "Yukarı Yuvarla:";
            // 
            // lblMutlak
            // 
            this.lblMutlak.AutoSize = true;
            this.lblMutlak.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMutlak.Location = new System.Drawing.Point(193, 203);
            this.lblMutlak.Name = "lblMutlak";
            this.lblMutlak.Size = new System.Drawing.Size(107, 18);
            this.lblMutlak.TabIndex = 6;
            this.lblMutlak.Text = "Mutlak Alma:";
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSayi.Location = new System.Drawing.Point(14, 35);
            this.txtSayi.Multiline = true;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(145, 33);
            this.txtSayi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(449, 264);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lblMutlak);
            this.Controls.Add(this.lblYukariYuvarla);
            this.Controls.Add(this.lblAssagiYuvarla);
            this.Controls.Add(this.lblYuvarla);
            this.Controls.Add(this.lblKok);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblKok;
        private System.Windows.Forms.Label lblYuvarla;
        private System.Windows.Forms.Label lblAssagiYuvarla;
        private System.Windows.Forms.Label lblYukariYuvarla;
        private System.Windows.Forms.Label lblMutlak;
        private System.Windows.Forms.TextBox txtSayi;
    }
}

