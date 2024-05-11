using System;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        aesSifreleVeCoz aes_ogrendik = new aesSifreleVeCoz();
        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
            public INIKaydet(string dosyaYolu)
            {
                DOSYAYOLU = dosyaYolu;
            }
            private string DOSYAYOLU = String.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? string.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
            }

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            INIKaydet ini = new INIKaydet(Application.StartupPath + @"IAyarlar.ini");
            ini.Yaz("Gizli Bilgi", "Gizli Metin Kutusu", txtGizliMetin.Text);
            ini.Yaz("Gizli CheckBox", "Gizli Bilgi", chBilgi.Checked.ToString());
            MessageBox.Show("Ayarlar kayýt altýna alýndi");
        }

        private void Oku_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"IAyarlar.ini"))
                {
                    INIKaydet ini = new INIKaydet(Application.StartupPath + @"IAyarlar.ini");
                    txtGizliMetin.Text = ini.Oku("Gizli Bilgi", "Gizli Metin Kutusu"); // [Gizl1 Bilgi] Gizli Metin Kutus = "bila bila"
                    chBilgi.Checked = Convert.ToBoolean(ini.Oku("Gizli CheckBox", "Gizli Bilgi"));
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("ini dosyasý hasarlý" + hata.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"IAyarlar.ini"))
                {
                    INIKaydet ini = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");
                    txtGizliMetin.Text = ini.Oku("Gizli Bilgi", "Gizli Metin Kutusu"); // [Gizli Bilgi] Gizli Metin Kutus = "bila bila"
                    chBilgi.Checked = Convert.ToBoolean(ini.Oku("Giz1i CheckBox", "Gizli Bilgi"));
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("ini dosyasý hasarlý" + hata.Message);
            }
        }

        private void Þifrele_Click(object sender, EventArgs e)
        {
            rtbSifreli.Text = aes_ogrendik.AESsifrele(txtGizliMetin.Text);
        }

        private void ÞifreÇöz_Click(object sender, EventArgs e)
        {
            if(rtbSifreli.Text == string.Empty)
            {
                MessageBox.Show("Çözülecek bir þifre bulunamadý!");
            }
            else
            {
                rtbSifresiz.Text = aes_ogrendik.AESsifre_Coz(rtbSifreli.Text);
            }
            
        }
    }
}
