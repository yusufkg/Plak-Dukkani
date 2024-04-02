namespace PlakDükkanıYöneticiApp
{
    partial class frm4_AlbumCRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcAlbumPanel = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbAlbumAdı = new TextBox();
            cbSanatcı = new ComboBox();
            rbKapalı = new RadioButton();
            rbAcık = new RadioButton();
            dtAlbumCıkıs = new DateTimePicker();
            lblSanatcı = new Label();
            lblSatısDurumu = new Label();
            lblIndirimOrani = new Label();
            lblAlbumFiyat = new Label();
            lblCıkısTarihi = new Label();
            lblAlbumAdı = new Label();
            tbIndirim = new TextBox();
            tbAlbumFiyat = new TextBox();
            dgvAlbum = new DataGridView();
            btnSil = new Button();
            BtnGuncelle = new Button();
            btnEkle = new Button();
            tabPage2 = new TabPage();
            label6 = new Label();
            dtgrIndirimdekiAlbum = new DataGridView();
            label7 = new Label();
            dtgrSon10 = new DataGridView();
            label8 = new Label();
            dtgr_SatısDevam = new DataGridView();
            label9 = new Label();
            dtgr_SatısDurmus = new DataGridView();
            tcAlbumPanel.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrIndirimdekiAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrSon10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgr_SatısDevam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgr_SatısDurmus).BeginInit();
            SuspendLayout();
            // 
            // tcAlbumPanel
            // 
            tcAlbumPanel.Controls.Add(tabPage1);
            tcAlbumPanel.Controls.Add(tabPage2);
            tcAlbumPanel.Location = new Point(14, 12);
            tcAlbumPanel.Name = "tcAlbumPanel";
            tcAlbumPanel.SelectedIndex = 0;
            tcAlbumPanel.Size = new Size(921, 520);
            tcAlbumPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbAlbumAdı);
            tabPage1.Controls.Add(cbSanatcı);
            tabPage1.Controls.Add(rbKapalı);
            tabPage1.Controls.Add(rbAcık);
            tabPage1.Controls.Add(dtAlbumCıkıs);
            tabPage1.Controls.Add(lblSanatcı);
            tabPage1.Controls.Add(lblSatısDurumu);
            tabPage1.Controls.Add(lblIndirimOrani);
            tabPage1.Controls.Add(lblAlbumFiyat);
            tabPage1.Controls.Add(lblCıkısTarihi);
            tabPage1.Controls.Add(lblAlbumAdı);
            tabPage1.Controls.Add(tbIndirim);
            tabPage1.Controls.Add(tbAlbumFiyat);
            tabPage1.Controls.Add(dgvAlbum);
            tabPage1.Controls.Add(btnSil);
            tabPage1.Controls.Add(BtnGuncelle);
            tabPage1.Controls.Add(btnEkle);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(913, 492);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Albüm Ekle";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(693, 277);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 25;
            label5.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(693, 229);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(693, 184);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 23;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(693, 140);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 22;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(693, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 21;
            label1.Text = "label1";
            // 
            // tbAlbumAdı
            // 
            tbAlbumAdı.Location = new Point(693, 28);
            tbAlbumAdı.Name = "tbAlbumAdı";
            tbAlbumAdı.Size = new Size(174, 23);
            tbAlbumAdı.TabIndex = 20;
            // 
            // cbSanatcı
            // 
            cbSanatcı.FormattingEnabled = true;
            cbSanatcı.Location = new Point(693, 251);
            cbSanatcı.Name = "cbSanatcı";
            cbSanatcı.Size = new Size(174, 23);
            cbSanatcı.TabIndex = 19;
            // 
            // rbKapalı
            // 
            rbKapalı.AutoSize = true;
            rbKapalı.Location = new Point(793, 207);
            rbKapalı.Name = "rbKapalı";
            rbKapalı.Size = new Size(57, 19);
            rbKapalı.TabIndex = 18;
            rbKapalı.TabStop = true;
            rbKapalı.Text = "Kapalı";
            rbKapalı.UseVisualStyleBackColor = true;
            // 
            // rbAcık
            // 
            rbAcık.AutoSize = true;
            rbAcık.Location = new Point(693, 207);
            rbAcık.Name = "rbAcık";
            rbAcık.Size = new Size(48, 19);
            rbAcık.TabIndex = 17;
            rbAcık.TabStop = true;
            rbAcık.Text = "Açık";
            rbAcık.UseVisualStyleBackColor = true;
            // 
            // dtAlbumCıkıs
            // 
            dtAlbumCıkıs.Location = new Point(693, 72);
            dtAlbumCıkıs.Name = "dtAlbumCıkıs";
            dtAlbumCıkıs.Size = new Size(174, 23);
            dtAlbumCıkıs.TabIndex = 16;
            // 
            // lblSanatcı
            // 
            lblSanatcı.AutoSize = true;
            lblSanatcı.Location = new Point(602, 251);
            lblSanatcı.Name = "lblSanatcı";
            lblSanatcı.Size = new Size(48, 15);
            lblSanatcı.TabIndex = 15;
            lblSanatcı.Text = "Sanatçı:";
            // 
            // lblSatısDurumu
            // 
            lblSatısDurumu.AutoSize = true;
            lblSatısDurumu.Location = new Point(602, 207);
            lblSatısDurumu.Name = "lblSatısDurumu";
            lblSatısDurumu.Size = new Size(81, 15);
            lblSatısDurumu.TabIndex = 14;
            lblSatısDurumu.Text = "Satış Durumu:";
            // 
            // lblIndirimOrani
            // 
            lblIndirimOrani.AutoSize = true;
            lblIndirimOrani.Location = new Point(602, 166);
            lblIndirimOrani.Name = "lblIndirimOrani";
            lblIndirimOrani.Size = new Size(80, 15);
            lblIndirimOrani.TabIndex = 13;
            lblIndirimOrani.Text = "İndirim Oranı:";
            // 
            // lblAlbumFiyat
            // 
            lblAlbumFiyat.AutoSize = true;
            lblAlbumFiyat.Location = new Point(602, 123);
            lblAlbumFiyat.Name = "lblAlbumFiyat";
            lblAlbumFiyat.Size = new Size(77, 15);
            lblAlbumFiyat.TabIndex = 12;
            lblAlbumFiyat.Text = "Albüm Fiyatı:";
            // 
            // lblCıkısTarihi
            // 
            lblCıkısTarihi.AutoSize = true;
            lblCıkısTarihi.Location = new Point(602, 80);
            lblCıkısTarihi.Name = "lblCıkısTarihi";
            lblCıkısTarihi.Size = new Size(66, 15);
            lblCıkısTarihi.TabIndex = 11;
            lblCıkısTarihi.Text = "Çıkış Tarihi:";
            // 
            // lblAlbumAdı
            // 
            lblAlbumAdı.AutoSize = true;
            lblAlbumAdı.Location = new Point(601, 36);
            lblAlbumAdı.Name = "lblAlbumAdı";
            lblAlbumAdı.Size = new Size(67, 15);
            lblAlbumAdı.TabIndex = 10;
            lblAlbumAdı.Text = "Albüm Adı:";
            // 
            // tbIndirim
            // 
            tbIndirim.Location = new Point(693, 158);
            tbIndirim.Name = "tbIndirim";
            tbIndirim.Size = new Size(174, 23);
            tbIndirim.TabIndex = 7;
            // 
            // tbAlbumFiyat
            // 
            tbAlbumFiyat.Location = new Point(693, 115);
            tbAlbumFiyat.Name = "tbAlbumFiyat";
            tbAlbumFiyat.Size = new Size(174, 23);
            tbAlbumFiyat.TabIndex = 6;
            // 
            // dgvAlbum
            // 
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbum.Location = new Point(17, 15);
            dgvAlbum.Name = "dgvAlbum";
            dgvAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbum.Size = new Size(536, 458);
            dgvAlbum.TabIndex = 3;
            dgvAlbum.CellClick += dgvAlbumEkle_CellClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(768, 403);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(114, 38);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(768, 359);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(114, 38);
            BtnGuncelle.TabIndex = 1;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(768, 309);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(114, 44);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dtgrIndirimdekiAlbum);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dtgrSon10);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dtgr_SatısDevam);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dtgr_SatısDurmus);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(913, 492);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Raporlama";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, 253);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 15;
            label6.Text = "İndirimdeki Albümler";
            // 
            // dtgrIndirimdekiAlbum
            // 
            dtgrIndirimdekiAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrIndirimdekiAlbum.Location = new Point(449, 271);
            dtgrIndirimdekiAlbum.Name = "dtgrIndirimdekiAlbum";
            dtgrIndirimdekiAlbum.Size = new Size(390, 214);
            dtgrIndirimdekiAlbum.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 250);
            label7.Name = "label7";
            label7.Size = new Size(185, 15);
            label7.TabIndex = 13;
            label7.Text = "Sisteme En Son Eklenen 10 Albüm";
            // 
            // dtgrSon10
            // 
            dtgrSon10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrSon10.Location = new Point(74, 271);
            dtgrSon10.Name = "dtgrSon10";
            dtgrSon10.Size = new Size(360, 214);
            dtgrSon10.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(570, 8);
            label8.Name = "label8";
            label8.Size = new Size(155, 15);
            label8.TabIndex = 11;
            label8.Text = "Satışı Devam Eden Albümler";
            // 
            // dtgr_SatısDevam
            // 
            dtgr_SatısDevam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgr_SatısDevam.Location = new Point(449, 26);
            dtgr_SatısDevam.Name = "dtgr_SatısDevam";
            dtgr_SatısDevam.Size = new Size(390, 197);
            dtgr_SatısDevam.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 8);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 9;
            label9.Text = "Satışı Durmuş Albümler";
            // 
            // dtgr_SatısDurmus
            // 
            dtgr_SatısDurmus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgr_SatısDurmus.Location = new Point(74, 26);
            dtgr_SatısDurmus.Name = "dtgr_SatısDurmus";
            dtgr_SatısDurmus.Size = new Size(360, 197);
            dtgr_SatısDurmus.TabIndex = 8;
            // 
            // AlbumCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 544);
            Controls.Add(tcAlbumPanel);
            Name = "AlbumCRUD";
            Text = "Albüm Ekleme Paneli";
            Load += Form1_Load;
            tcAlbumPanel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrIndirimdekiAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrSon10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgr_SatısDevam).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgr_SatısDurmus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAlbumPanel;
        private TabPage tabPage1;
        private DataGridView dgvAlbum;
        private Button btnSil;
        private Button BtnGuncelle;
        private Button btnEkle;
        private TabPage tabPage2;
        private TextBox textBox5;
        private TextBox tbIndirim;
        private TextBox tbAlbumFiyat;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblSanatcı;
        private Label lblSatısDurumu;
        private Label lblIndirimOrani;
        private Label lblAlbumFiyat;
        private Label lblCıkısTarihi;
        private Label lblAlbumAdı;
        private DateTimePicker dtAlbumCıkıs;
        private RadioButton rbKapalı;
        private RadioButton rbAcık;
        private ComboBox cbSanatcı;
        private TextBox tbAlbumAdı;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dtgrIndirimdekiAlbum;
        private Label label7;
        private DataGridView dtgrSon10;
        private Label label8;
        private DataGridView dtgr_SatısDevam;
        private Label label9;
        private DataGridView dtgr_SatısDurmus;
    }
}
