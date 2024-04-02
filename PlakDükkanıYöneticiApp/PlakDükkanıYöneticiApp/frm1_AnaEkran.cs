using System.Diagnostics;

namespace PlakDükkanıYöneticiApp
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2_KayıtFormu form2 = new frm2_KayıtFormu();
            form2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm3_GirisYap girisYap = new frm3_GirisYap();
            girisYap.ShowDialog();
            this.Hide();
        }
    }
}
