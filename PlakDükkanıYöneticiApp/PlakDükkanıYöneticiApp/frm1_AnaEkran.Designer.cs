namespace PlakDükkanıYöneticiApp
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            button1 = new Button();
            button2 = new Button();
            lblHosgeldniz = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(78, 66);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(180, 117);
            button1.TabIndex = 0;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(283, 66);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(186, 117);
            button2.TabIndex = 1;
            button2.Text = "Kayıt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblHosgeldniz
            // 
            lblHosgeldniz.AutoSize = true;
            lblHosgeldniz.BackColor = Color.GhostWhite;
            lblHosgeldniz.Font = new Font("Harlow Solid Italic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHosgeldniz.Location = new Point(78, 19);
            lblHosgeldniz.Name = "lblHosgeldniz";
            lblHosgeldniz.Size = new Size(164, 34);
            lblHosgeldniz.TabIndex = 2;
            lblHosgeldniz.Text = "Hosgeldiniz.";
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(542, 263);
            Controls.Add(lblHosgeldniz);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AnaEkran";
            Text = "AlbumApp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblHosgeldniz;
    }
}
