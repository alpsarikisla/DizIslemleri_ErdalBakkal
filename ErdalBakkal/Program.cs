using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Domates", "Biber", "Soğan", "Yumurta", "Ekmek", "Doritos", "Mevye Suyu" };
            double[] fiyatlar = { 25.9, 48.7, 50, 15, 15, 63, 90 };
            int[] stokadet = { 50, 20, 0, 200, 60, 12, 5 };

            #region Ürünleri Listeleyelim

            //Console.WriteLine("*-*-*- ERDAL BAKKAL -*-*-*");

            //for(int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine((i+1) + ") " + isimler[i] + " \t " + fiyatlar[i] + " TL");
            //}

            #endregion

            #region Stokta Bulunan Ürünleri Listeleyelim


            //Console.WriteLine("*-*-*- ERDAL BAKKAL -*-*-*");

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    if (stokadet[i] > 0)
            //    {
            //        Console.WriteLine((i + 1) + ") " + isimler[i] + " \t " + fiyatlar[i] + " TL");
            //    }
            //    else
            //    {
            //        Console.WriteLine((i + 1) + ") " + isimler[i] + " \t Stok Yok" );
            //    }
            //}

            #endregion

            #region Adet Sordurarak Ürün satın aldıralım

            //Console.Write("Kaç Adet Ürün Alacaksınız = ");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //double toplam = 0;

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.Write("Ürün Numarası Giriniz = ");
            //    int uruNo = Convert.ToInt32(Console.ReadLine());
            //    int diziIndex = uruNo - 1;

            //    toplam += fiyatlar[diziIndex];
            //}

            //Console.WriteLine("Toplam Fiyat = " + toplam + " TL");

            #endregion

            #region Adet Sormadan Ürün Satın Alma

            //double toplam = 0;
            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    Console.Write("Ürün Numarası Giriniz = ");
            //    int urunNo = Convert.ToInt32(Console.ReadLine());
            //    int index = urunNo - 1;

            //    toplam += fiyatlar[index];

            //    Console.WriteLine("Satın alma işlemine devam edilsin mi?e/h");
            //    secenek = Console.ReadLine();
            //}

            //Console.WriteLine("Toplam = " + toplam + " TL");

            #endregion

            #region Konsoldan alınan metnin sonudaki boşlukları silme

            //Console.WriteLine("Metin Giriniz");
            //string metin =  Console.ReadLine();

            //Console.WriteLine("Eleman Sayısı = " + metin.Length);

            //int kacinci = 0;

            //for (int i = metin.Length - 1; i >= 0; i--)
            //{
            //    if (metin[i] != ' ')
            //    {
            //        kacinci = i;
            //        break;
            //    }

            //}

            //string bosluksuz = "";
            //for (int i = 0; i <= kacinci; i++)
            //{
            //    bosluksuz += metin[i];
            //}
            //Console.WriteLine(bosluksuz);


            #endregion

            
        }
    }
}
