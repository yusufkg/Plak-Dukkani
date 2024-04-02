namespace PlakDükkanıYöneticiApp
{
    partial class frm2_KayıtFormu
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
            txt_KullanıcıAdi = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_passwordTekrar = new TextBox();
            txt_password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_KullanıcıAdi
            // 
            txt_KullanıcıAdi.Location = new Point(116, 36);
            txt_KullanıcıAdi.Margin = new Padding(2, 2, 2, 2);
            txt_KullanıcıAdi.Name = "txt_KullanıcıAdi";
            txt_KullanıcıAdi.Size = new Size(106, 23);
            txt_KullanıcıAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "kullanıcı adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 128);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Şifre Tekrar:";
            // 
            // txt_passwordTekrar
            // 
            txt_passwordTekrar.Location = new Point(116, 124);
            txt_passwordTekrar.Margin = new Padding(2, 2, 2, 2);
            txt_passwordTekrar.Name = "txt_passwordTekrar";
            txt_passwordTekrar.Size = new Size(106, 23);
            txt_passwordTekrar.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(116, 95);
            txt_password.Margin = new Padding(2, 2, 2, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(106, 23);
            txt_password.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(132, 170);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 37);
            button1.TabIndex = 8;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm2_KayıtFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 271);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_passwordTekrar);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_KullanıcıAdi);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frm2_KayıtFormu";
            Text = "Kayıt Formu";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_KullanıcıAdi;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_passwordTekrar;
        private TextBox txt_password;
        private Button button1;
    }
}