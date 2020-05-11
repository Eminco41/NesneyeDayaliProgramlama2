using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:1
** ÖĞRENCİ ADI............:Muhammed Emin AKBULUT
** ÖĞRENCİ NUMARASI.......:B151200023
** DERSİN ALINDIĞI GRUP...:A
****************************************************************************/

namespace cars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Try catch hata fırlatma mekanizması kullanımı
            try
            {

          
                label7.Visible = true;
                comboBox4.Visible = true;
                //Nesne Türettim
                Sedan s1 = new Sedan(Convert.ToDouble(txtKiloMetre.Text));
                s1.Marka = "BMW";
                Sedan s2 = new Sedan(Convert.ToDouble(txtKiloMetre.Text));
                s2.Marka = "Mercedes";
                Sedan s3 = new Sedan(Convert.ToDouble(txtKiloMetre.Text));
                s3.Marka = "Audi";

                //Liste Kullanımı
                List<Sedan> sedans = new List<Sedan>();
                sedans.Add(s1);
                sedans.Add(s2);
                sedans.Add(s3);

                //Nesne Türettim
                Hatchback h1 = new Hatchback(Convert.ToDouble(txtKiloMetre.Text));
                h1.Marka = "Seat";
                Hatchback h2 = new Hatchback(Convert.ToDouble(txtKiloMetre.Text));
                h2.Marka = "Volkswagen";
                Hatchback h3 = new Hatchback(Convert.ToDouble(txtKiloMetre.Text));
                h3.Marka = "Ford";

                //Liste Kullanımı
                List<Hatchback> hatchbacks = new List<Hatchback>();
                hatchbacks.Add(h1);
                hatchbacks.Add(h2);
                hatchbacks.Add(h3);

                Kullanici k = new Kullanici();
                //Nesne Türettim
                Suv suv1 = new Suv(Convert.ToDouble(txtKiloMetre.Text));
                suv1.Marka = "Toyota";
                Suv suv2 = new Suv(Convert.ToDouble(txtKiloMetre.Text));
                suv2.Marka = "Skoda";
                Suv suv3 = new Suv(Convert.ToDouble(txtKiloMetre.Text));
                suv3.Marka = "Volvo";
                //Liste Kullanımı
                List<Suv> Suvs = new List<Suv>();
                Suvs.Add(suv1);
                Suvs.Add(suv2);
                Suvs.Add(suv3);

                k.Butce = Convert.ToDouble(textBox1.Text);
                //if else Kontrol Yapıları
                //Kullanıcının girdiği bütçe değerlerini belirli aralıklara bölerek, bütçeye göre araç tipi önerdim.
                //liste yapısı kullandığımız için döngü seçeneği olarak FOREACH DÖNGÜSÜ tercih ettim.
                if (k.Butce >= 100000)
                {
                    comboBox4.Items.Clear();
                    foreach (var item in sedans)
                    {
                        comboBox4.Items.Add(item.Marka);
                    }
                    comboBox1.Text = "Sedan";
                }
                else if (k.Butce>=50000 && k.Butce <= 99999)
                {
                    comboBox4.Items.Clear();
                    foreach (var item in Suvs)
                    {
                        comboBox4.Items.Add(item.Marka);
                    }
                    comboBox1.Text = "Suv";
                }
                else if (k.Butce >=30000 && k.Butce <= 49999)
                {
                    comboBox4.Items.Clear();
                    foreach (var item in hatchbacks)
                    {
                        comboBox4.Items.Add(item.Marka);
                    }
                    comboBox1.Text = "Hatchback";
                }
                else //Her miktara uygun arabalar bulunmadığı için başlangıç koşulu olarak 30.000Tl belirledim.
                {
                    MessageBox.Show("En düşük bütçe 30.000 Tl olmalıdır. Uygun değeri girdikten sonra tekrar sorgulama yapınız.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //Form Yapısı'nın adım adım ilerlemesini istediğim için bütün form elemanlarının program çalıştırıldığı andan itibaren gözükmesini istemedim.
        //Kullanıcı değerleri girdikçe ilerleyen (kullanıcı adımına göre ekranda beliren form elemanları) bir yapı kurdum.
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            textBox2.Visible = true;
           

        }
        //Nerdeyse bütün form elemanları ilk çalışma anında saklı durumda.(Yalnızca 'Bütçeme uygun araba bul' butonu aktif.)
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            textBox2.Visible = false;
            label7.Visible = false;
            comboBox4.Visible = false;
            button2.Visible = false;
        }

        //Kullanıcının Form Elemanlarına girdiği değerleri kendi değişkenlerimize atayarak Method'umuzu devreye soktuk.
        //Bu sayede araç oluşturdum.
        //Araç tipi'ni kullanıcının bütçesine göre atanacak şekilde oluşturdum. Geri kalan tüm özellikleri kullanıcı belirliyor. Aşağıda araç tipinin sabit tutulduğu, diğer değerler alındıktan sonra aracın oluşturulduğu kod bloğu mevcut.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

          
                if (comboBox1.Text == "Sedan") 
                {
                    Sedan s = new Sedan(Convert.ToDouble(txtKiloMetre.Text));
                    string Marka = comboBox4.Text;
                    string Aractipi = comboBox1.Text;
                    string Motorgucu =comboBox3.Text;
                    string Yakittipi = comboBox2.Text;
                    int BagajHacmi =Convert.ToInt32(textBox2.Text);
                    s.AracOlustur(Marka, Motorgucu, Aractipi,Yakittipi, BagajHacmi);

                    lblAracTipi.Text = s.Aractipi;
                    lblBagajHacmi.Text = s.BagajHacmi.ToString();
                    lblMarka.Text = s.Marka;
                    lblYakitTuru.Text = s.Yakittipi;
                    lblMotorGucu.Text = s.Motorgucu.ToString();

                    MessageBox.Show("Aracınız Oluşturuldu. Sonuç sekmesinde görüntüleyebilirsiniz.", "Bilgi", MessageBoxButtons.OK);

                }
                else if (comboBox1.Text== "Suv")
                {
                    Suv s = new Suv(Convert.ToDouble(txtKiloMetre.Text));
                    string Marka = comboBox4.Text;
                    string Aractipi = comboBox1.Text;
                    string Motorgucu = comboBox3.Text;
                    string Yakittipi = comboBox2.Text;
                    int BagajHacmi = Convert.ToInt32(textBox2.Text);
                    s.AracOlustur(Marka, Motorgucu, Aractipi, Yakittipi, BagajHacmi);

                    lblAracTipi.Text = s.Aractipi;
                    lblBagajHacmi.Text = s.BagajHacmi.ToString();
                    lblMarka.Text = s.Marka;
                    lblYakitTuru.Text = s.Yakittipi;
                    lblMotorGucu.Text = s.Motorgucu.ToString();
                    MessageBox.Show("Aracınız Oluşturuldu. Sonuç sekmesinde görüntüleyebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
                }
                else if(comboBox1.Text == "Hatchback")
                {
                    Hatchback h = new Hatchback(Convert.ToDouble(txtKiloMetre.Text));
                    string Marka = comboBox4.Text;
                    string Aractipi = comboBox1.Text;
                    string Motorgucu = comboBox3.Text;
                    string Yakittipi = comboBox2.Text;
                    int BagajHacmi = Convert.ToInt32(textBox2.Text);
                    h.AracOlustur(Marka, Motorgucu, Aractipi, Yakittipi, BagajHacmi);

                    lblAracTipi.Text = h.Aractipi;
                    lblBagajHacmi.Text = h.BagajHacmi.ToString();
                    lblMarka.Text = h.Marka;
                    lblYakitTuru.Text = h.Yakittipi;
                    lblMotorGucu.Text = h.Motorgucu.ToString();
                    MessageBox.Show("Aracınız Oluşturuldu. Sonuç sekmesinde görüntüleyebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Her araç tipi için ayrı ayrı yakıt tüketimi fonksiyonları çağırıldı ve 'lblYakitHacmi' elemanına atandı.
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Sedan s = new Sedan(Convert.ToDouble(txtKiloMetre.Text));
                Suv suv = new Suv(Convert.ToDouble(txtKiloMetre.Text));
                Hatchback h = new Hatchback(Convert.ToDouble(txtKiloMetre.Text));

                //Switch Case Kullanımı
                switch (lblAracTipi.Text)
                {
                    case "Sedan":
                        lblYakitHacmi.Text = s.YakitHesapla().ToString()+" litre";
                        break;
                    case "Suv":
                        lblYakitHacmi.Text = suv.YakitHesapla().ToString()+" litre";
                        break;
                    case "Hatchback":
                        lblYakitHacmi.Text = h.YakitHesapla().ToString()+"litre";
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        
    }
}
