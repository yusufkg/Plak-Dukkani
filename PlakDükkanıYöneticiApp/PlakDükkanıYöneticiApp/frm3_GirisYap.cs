using PlakDükkanıYöneticiApp.Context;
using PlakDükkanıYöneticiApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PlakDükkanıYöneticiApp
{
    public partial class frm3_GirisYap : Form
    {
        public frm3_GirisYap()
        {
            InitializeComponent();
        }

        private void Giris_Click(object sender, EventArgs e)
        {

        }

        private void FormClear()
        {
            txt_KullaniciAdi.Text = "";
            txt_Sifre.Text = "";
        }

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        public bool KullaniciAdControl(string kullaniciAd)
        {
            try
            {

                PlakDukkanıAppDbContext dbContext = new PlakDukkanıAppDbContext();
                var entity = dbContext.Kullanicis.Where(x => x.KullaniciAdi == kullaniciAd).FirstOrDefault();
                if (entity is not null)
                {
                    return true;
                }

                else
                {
                    MessageBox.Show("Kullanıcı mevcut değil.");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lutfen Kullanıcı Adınızı Giris Yapiniz.", "Giris Hatasi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            bool control = true;
            string klncAdi;

            klncAdi = txt_KullaniciAdi.Text;
            control = KullaniciAdControl(klncAdi);

            if (control)
            {

                string password = sha256_hash(txt_Sifre.Text);

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Parola bos olamaz!", "Giris Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FormClear();
                }

                else
                {
                    PlakDukkanıAppDbContext dbContext = new PlakDukkanıAppDbContext();
                    var entity = dbContext.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == klncAdi && x.Sifre == password );
                    if (entity == null)
                    {
                        MessageBox.Show("Hatalı Giris Yaptiniz Tekrar Deneyiniz!", "Giris Hatasi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FormClear();
                    }
                    else
                    {
                        frm4_AlbumCRUD form = new frm4_AlbumCRUD();
                        form.Show();
                        this.Hide();
                    }

                }


            }
        }
    }
}
