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
    class Hatchback:Araba  //Kalıtım
    {
        //Parametrelerin gönderildiği Constructor 
        public Hatchback(double km): base(km)
        {

        }
        //Hatchback için yakıt hesabı (Pollymorphism / çok biçimlilik)
        public override double YakitHesapla()
        {
            return km * 0.06;
        }
    }
}
