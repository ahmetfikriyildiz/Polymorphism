using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Bu uygulamada nesne yönelimli programlamanın çok biçimlilik özelliğini örnek ile anlatımını gerçekleştirdim.
    public class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
    public class Kare : BaseGeometrikSekil
    {
        public Kare(double  kenar) 
        {
            Genislik = kenar;
            Yukseklik = kenar;
        }
    }
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik,double yukseklik) 
        {
            Genislik= genislik;
            Yukseklik= yukseklik;   
        }
    }
    public class DikUcgen : BaseGeometrikSekil 
    {
        public DikUcgen(double taban,double yukseklik)
        {
            Genislik = taban;
            Yukseklik = yukseklik;
        }
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(10);
            Console.WriteLine($"Karenin alanı :{kare.AlanHesapla()}");

            Dikdortgen dikdortgen = new Dikdortgen(3,4);
            Console.WriteLine($"Dikdörtgenin alanı : {dikdortgen.AlanHesapla()}");

            DikUcgen dikUcgen= new DikUcgen(3,6);
            Console.WriteLine($"DikÜçgenin alanı : {dikUcgen.AlanHesapla()}");
            Console.ReadKey();
        }
    }
}
