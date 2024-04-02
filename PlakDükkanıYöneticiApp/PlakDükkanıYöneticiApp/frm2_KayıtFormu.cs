using PlakDükkanıYöneticiApp.Context;
using PlakDükkanıYöneticiApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlakDükkanıYöneticiApp
{
    public partial class frm2_KayıtFormu : Form
    {
        public frm2_KayıtFormu()
        {
            InitializeComponent();

        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_KullanıcıAdi.Text;
            string password = txt_password.Text;

            PlakDukkanıAppDbContext dbContext = new PlakDukkanıAppDbContext();
            var entity = dbContext.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi);

            if (entity != null)
            {
                MessageBox.Show("Kullanıcı vardır. tekarar deneyiniz.");
            }
            else
            {
                if (IsPasswordValid(password))
                {
                    if (txt_password.Text == txt_passwordTekrar.Text)
                    {
                        string hashPswrd = sha256_hash(txt_password.Text.Trim());
                        Kullanici kullanici = new Kullanici();
                        kullanici.KullaniciAdi = txt_KullanıcıAdi.Text.Trim();
                        kullanici.Sifre = hashPswrd;

                        dbContext.Add(kullanici);
                        dbContext.SaveChanges();
                        MessageBox.Show("Kullanıcı başarıyla kaydedilmiştir.");
                        txt_KullanıcıAdi.Text = string.Empty;
                        txt_password.Text = string.Empty;
                        txt_passwordTekrar.Text = string.Empty;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Şifreler birbiri ile uyuşmuyor");
                    
                }
                else
                {
                    MessageBox.Show("Şifre kriterlere uymamaktadır.");
                }
            }

        }

        private bool IsPasswordValid(string password)
        {
            // 1. En az 8 karakter uzunluğunda olmalıdır.
            if (password.Length < 8)
                return false;

            // 2. En az 2 büyük harf içermelidir.
            if (password.Count(char.IsUpper) < 2)
                return false;

            // 3. En az 3 küçük harf içermelidir.
            if (password.Count(char.IsLower) < 3)
                return false;

            // 4. ! (ünlem), : (iki nokta üst üste), + (artı), * (yıldız) karakterlerinden en az 2 tanesini içermelidir.
            string specialChars = "!:+*";
            int specialCharCount = password.Count(c => specialChars.Contains(c));

            return specialCharCount >= 2;
        }
    }
}
