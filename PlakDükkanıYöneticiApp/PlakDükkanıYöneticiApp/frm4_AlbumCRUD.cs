using Microsoft.EntityFrameworkCore;
using PlakDükkanıYöneticiApp.Context;
using PlakDükkanıYöneticiApp.Entities;
using System.Windows.Forms;

namespace PlakDükkanıYöneticiApp
{
    public partial class frm4_AlbumCRUD : Form
    {

        PlakDukkanıAppDbContext db = new PlakDukkanıAppDbContext();
        Album secilenAlbum;

        public frm4_AlbumCRUD()
        {
            InitializeComponent();
            AlbumGoster();
            SatisiDurmusAlbumler();
            SatisiDevamEdenAlbumler();
            EklenenSon10Album();
            IndirimdekiAlbumler();

        }
        public void SatisiDurmusAlbumler()
        {
            PlakDukkanıAppDbContext dbContext = new PlakDukkanıAppDbContext();
            var datas = dbContext.Albums
                .Include(a => a.Sanatci)
                .Where(x => x.SatısDurum == false).ToList();


            //  var veri = datas.Select(a => (a.Adi, a.Sanatci.AlbumSanatcısı)).ToList();


            dtgr_SatısDurmus.DataSource = datas;
            dtgr_SatısDurmus.Columns[0].Visible = false;
            dtgr_SatısDurmus.Columns[2].Visible = false;
            dtgr_SatısDurmus.Columns[3].Visible = false;
            dtgr_SatısDurmus.Columns[4].Visible = false;
            dtgr_SatısDurmus.Columns[5].Visible = false;
            dtgr_SatısDurmus.Columns[6].Visible = false;

        }


        public void SatisiDevamEdenAlbumler()
        {
            PlakDukkanıAppDbContext dbContext = new PlakDukkanıAppDbContext();
            var datas = dbContext.Albums
                .Include(a => a.Sanatci)
                .Where(x => x.SatısDurum == true).ToList();


            //var veri = datas.Select(a => (a.Adi, a.Sanatci.AlbumSanatcısı)).ToList();

            dtgr_SatısDevam.DataSource = datas;

            dtgr_SatısDevam.Columns[0].Visible = false;
            dtgr_SatısDevam.Columns[2].Visible = false;
            dtgr_SatısDevam.Columns[3].Visible = false;
            dtgr_SatısDevam.Columns[4].Visible = false;
            dtgr_SatısDevam.Columns[5].Visible = false;
            dtgr_SatısDevam.Columns[6].Visible = false;

        }

        public void EklenenSon10Album()
        {
            PlakDukkanıAppDbContext dbContext = new PlakDukkanıAppDbContext();
            var data = dbContext.Albums
                                .OrderByDescending(a => a.AlbumCikisTarihi)
                                .Take(10)
                                .ToList();
            dtgrSon10.DataSource = data;

            dtgrSon10.Columns[0].Visible = false;
            dtgrSon10.Columns[2].Visible = false;
            dtgrSon10.Columns[3].Visible = false;
            dtgrSon10.Columns[4].Visible = false;
            dtgrSon10.Columns[5].Visible = false;
            dtgrSon10.Columns[6].Visible = false;

        }

        public void IndirimdekiAlbumler()
        {
            PlakDukkanıAppDbContext dbContext = new PlakDukkanıAppDbContext();
            var data = dbContext.Albums.OrderByDescending(a => a.IndirimOranı).ToList();
            // var veri = data.Select(a => (a.Adi, a.Sanatci.AlbumSanatcısı)).ToList();

            dtgrIndirimdekiAlbum.DataSource = data;

            dtgrIndirimdekiAlbum.Columns[0].Visible = false;
            dtgrIndirimdekiAlbum.Columns[2].Visible = false;
            dtgrIndirimdekiAlbum.Columns[3].Visible = false;
            dtgrIndirimdekiAlbum.Columns[4].Visible = false;
            dtgrIndirimdekiAlbum.Columns[5].Visible = false;
            dtgrIndirimdekiAlbum.Columns[6].Visible = false;

        }
        private void AlbumGoster()
        {
            dgvAlbum.DataSource = db.Albums.ToList();
            dgvAlbum.Columns[0].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSanatcı.DataSource = db.Sanatcis.ToList();
            labelClear();
        }

        private void dgvAlbumEkle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenAlbum = (Album)dgvAlbum.SelectedRows[0].DataBoundItem;
            cbSanatcı.SelectedItem = secilenAlbum.Sanatci;
            tbAlbumAdı.Text = secilenAlbum.Adi;
            tbAlbumFiyat.Text = secilenAlbum.AlbumFiyat.ToString();
            tbIndirim.Text = secilenAlbum.IndirimOranı.ToString();
            if (secilenAlbum.SatısDurum == true)
                rbAcık.Checked = true;
            else
                rbKapalı.Checked = true;
            dtAlbumCıkıs.Value = secilenAlbum.AlbumCikisTarihi;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (FormControl())
            {

                Album album = new Album();
                album.SanatciId = ((Sanatci)(cbSanatcı.SelectedItem)).Id;
                album.Adi = tbAlbumAdı.Text;
                if (!int.TryParse(tbAlbumFiyat.Text, out _))
                {
                    MessageBox.Show("Lütfen sadece sayısal değerler giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    album.AlbumFiyat = Convert.ToDouble(tbAlbumFiyat.Text);


                album.AlbumCikisTarihi = dtAlbumCıkıs.Value;
                album.SatısDurum = (rbAcık.Checked == true) ? true : false; //???

                if (!int.TryParse(tbIndirim.Text, out _))
                {
                    MessageBox.Show("Lütfen sadece sayısal değerler giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    album.IndirimOranı = Convert.ToInt32(tbIndirim.Text);



                db.Albums.Add(album);
                db.SaveChanges();
                MessageBox.Show("Albüm eklenmiştir.");
                AlbumGoster();
            }

        }
        private void labelClear()
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
        }
        private bool FormControl()
        {
            labelClear();



            if (string.IsNullOrWhiteSpace(tbAlbumAdı.Text))
            {
                label1.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbAlbumFiyat.Text))
            {
                label2.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbIndirim.Text))
            {
                label3.Text = "Zorunlu Alanı Doldurunuz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbAlbumFiyat.Text) || !double.TryParse(tbAlbumFiyat.Text, out _))
            {
                label2.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbIndirim.Text) || !double.TryParse(tbIndirim.Text, out _))
            {
                label3.Text = "Geçerli bir değer giriniz.";
                return false;
            }

            if (rbAcık.Checked == false && rbKapalı.Checked == false)
            {
                label4.Text = "Değerlerden birini seçiniz.";
                return false;
            }

            if (cbSanatcı.Items == null)
            {
                label5.Text = "Sanatçı sorusu seçiniz.";
                return false;
            }

            return true;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenAlbum != null)
            {
                secilenAlbum.SanatciId = ((Sanatci)(cbSanatcı.SelectedItem)).Id;
                secilenAlbum.Adi = tbAlbumAdı.Text;
                secilenAlbum.AlbumFiyat = Convert.ToDouble(tbAlbumFiyat.Text);
                secilenAlbum.AlbumCikisTarihi = dtAlbumCıkıs.Value;
                secilenAlbum.SatısDurum = (rbAcık.Checked == true) ? true : false; //???
                secilenAlbum.IndirimOranı = Convert.ToInt32(tbIndirim.Text);
                db.SaveChanges();
                MessageBox.Show("Albüm güncellenmiştir.");
                AlbumGoster();
                tbAlbumAdı.Text = "";
                tbAlbumFiyat.Text = "";
                tbIndirim.Text = "";
                secilenAlbum = null;

            }
            else
                MessageBox.Show("Güncellemek için albüm seçiniz.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenAlbum != null)
            {
                db.Albums.Remove(secilenAlbum);
                db.SaveChanges();
                MessageBox.Show("Albüm silinmiştir.");
                AlbumGoster();
                tbAlbumAdı.Text = "";
                tbAlbumFiyat.Text = "";
                tbIndirim.Text = "";
                secilenAlbum = null;

            }
            else
                MessageBox.Show("Silmek için albüm seçiniz.");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }

}
