using System;
using System.Collections.Generic;
using System.Linq;

class DiziBirlestir
{
    static void Main(string[] args)
    {
        // Kullanıcıdan girişi oku ve '|' karakterine göre böl
        string[] girdi = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

        // Sonucu saklamak için bir liste oluştur
        List<int> sonuc = new List<int>();

        // Dizileri sağdan sola doğru dolaş
        for (int i = girdi.Length - 1; i >= 0; i--)
        {
            // Her bir kısmı boşluklara göre böl, boş girişleri temizle ve sayılara dönüştür
            int[] sayilar = girdi[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            // Sayıları sonuç listesine ekle
            sonuc.AddRange(sayilar);
        }

        // Sonucu ekrana yazdır (boşlukla ayrılmış şekilde)
        Console.WriteLine(string.Join(" ", sonuc));
    }
}