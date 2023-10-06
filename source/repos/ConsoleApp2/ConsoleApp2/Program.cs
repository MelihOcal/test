using System;

class Program
{
    static void Main()
    {
        // Erzurum'dan alınacak çimento bilgileri
        int erzurumPaketAgirlik = 50;
        int erzurumPaketFiyat = 12;
        int erzurumNakliyeUcreti = 1200;

        // Rize'den alınacak çimento bilgileri
        int rizePaketAgirlik = 25;
        int rizePaketFiyat = 7;
        int rizeNakliyeUcreti = 700;

        // Toplam ödenecek ücretin eşit olması durumunda çimento miktarını bulmak için denklem
        // 12X + 1200 = 7Y + 700
        // 12X - 7Y = 500

        int X, Y;

        for (X = 1; X <= 500; X++)
        {
            Y = (12 * X - 500) / 7;

            // Y'nin bir pozitif tam sayı olduğunu kontrol edelim
            if (Y > 0 && (12 * X + erzurumNakliyeUcreti == 7 * Y + rizeNakliyeUcreti))
            {
                break;
            }
        }

        int toplamCimento = X * erzurumPaketAgirlik + Y * rizePaketAgirlik;

        Console.WriteLine("İnşaat firmasının almayı düşündüğü çimento miktarı: " + toplamCimento + " kilogramdır.");
    }
}
