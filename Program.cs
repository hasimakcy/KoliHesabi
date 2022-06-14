using System;

namespace Koli_Hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deponuzdaki ürün adedini giriniz:
            // Bir kolinin ürün kapasitesini giriniz:

            // Bu ürünleri kargolamak için x adet koli ihtiyaciniz vardır.
            // Kullanıcıdan aldığı 2 bilgiye dayanarak yukarıdaki gibi bir sonuc cumle yazdıran programı kodlayınız.

            Console.WriteLine("Deponuzdaki ürün adedini giriniz: ");
            double urunAdedi = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Kolinin ürün kapasitesini giriniz: ");
            int kapasite = Convert.ToInt32(Console.ReadLine());

            double ihtiyac = urunAdedi / kapasite;
                        
            double r = Math.Round(ihtiyac);
            //Round = Sayıyı kontrol ederek aşağı
            //ya da yukarı yuvarlama işlemi yapar ve değeri geri döndürür.
            double f = Math.Floor(ihtiyac);
            //Floor = Sayıyı sadece asagı yuvarlar.
            double c = Math.Ceiling(ihtiyac);
            //Ceiling = Girilen sayıyı yukarı yuvarlar.

            //Burda ceiling tercih etme sebebimiz 9.1 veya 9.8 koli lazımdır gibi bir durumla karşılasırsak 
            //onu tam sayıya yuvarlayıp koli sıkıntısı çekmemek!
            //Bunlar gibi matematik işlemlerini, C# matematik sınıf metotları diye aratarak bulabilirsin.

            Console.WriteLine("Round: " + r);
            Console.WriteLine("Floor: " + f);
            Console.WriteLine("Ceiling: " + c);
     
            Console.WriteLine($"Bu ürünleri kargolamak için {c} adet koliye ihtiyacınız vardır.");
        }
    }
}
