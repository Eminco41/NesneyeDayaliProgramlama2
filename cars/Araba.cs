using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    //AnaClass ve Soyut Sınıfımız (Abstract Class)
    abstract class Araba : IAraba
    {
       protected double km;
        //Constructor Yapıcı Method (parametresiz)
        public Araba()
        {

        }
        //Constructor Yapıcı (Method parametreli)
        public Araba(double km)
        {
            this.km = km;
        }
        //Private Alanlar(Fields)
        private string _marka;
        private string _motorgucu;
        private string _aractipi;
        private string _yakittipi;
       
        private int _bagajHacmi;

        //Properties
        public string Motorgucu { get => _motorgucu; set => _motorgucu = value; }
        public string Aractipi { get => _aractipi; set => _aractipi = value; }
        public string Yakittipi { get => _yakittipi; set => _yakittipi = value; }
        public int BagajHacmi { get => _bagajHacmi; set => _bagajHacmi = value; }
        public string Marka { get => _marka; set => _marka = value; }
     
        //Araç oluşturma methodu
        public void AracOlustur(string marka,string motorgucu,string aractipi,string yakittipi,int bagajhacmi)
        {

            _marka = marka;
            _motorgucu = motorgucu;
            _aractipi = aractipi;
            _yakittipi = yakittipi;
            _bagajHacmi = bagajhacmi;
        }
        //Pollymorphism tüm araçlar için override olacak method
        public virtual double YakitHesapla()
        {
                return km * 0.05; 
        }
    }
}
