namespace PlakDükkanıYöneticiApp
{
    partial class frm3_GirisYap
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
            txt_KullaniciAdi = new TextBox();
            txt_Sifre = new TextBox();
            btn_Giris = new Button();
            SuspendLayout();
            // 
            // txt_KullaniciAdi
            // 
            txt_KullaniciAdi.Location = new Point(57, 81);
            txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            txt_KullaniciAdi.PlaceholderText = "Kullanıcı Adi";
            txt_KullaniciAdi.Size = new Size(158, 23);
            txt_KullaniciAdi.TabIndex = 0;
            // 
            // txt_Sifre
            // 
            txt_Sifre.Location = new Point(57, 114);
            txt_Sifre.Name = "txt_Sifre";
            txt_Sifre.PlaceholderText = "Sifre";
            txt_Sifre.Size = new Size(158, 23);
            txt_Sifre.TabIndex = 1;
            // 
            // btn_Giris
            // 
            btn_Giris.Location = new Point(57, 162);
            btn_Giris.Name = "btn_Giris";
            btn_Giris.Size = new Size(158, 23);
            btn_Giris.TabIndex = 2;
            btn_Giris.Text = "Giriş";
            btn_Giris.UseVisualStyleBackColor = true;
            btn_Giris.Click += btn_Giris_Click;
            // 
            // GirisYap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 241);
            Controls.Add(btn_Giris);
            Controls.Add(txt_Sifre);
            Controls.Add(txt_KullaniciAdi);
            Name = "GirisYap";
            Text = "GirisYap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_KullaniciAdi;
        private TextBox txt_Sifre;
        private Button btn_Giris;
    }
}