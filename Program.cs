
using Metotlar;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //dont repeat your self
            
            //prodcut classının içine tanımladıgımız nesneleri burada prodcut classını newleyerek ürün1 ref uzerınden erıstık.
            //sonra urun1. dıyerek degerleri girdik uru2 ıcınde aynısını yaptık ve bu ürün referanslarını ürünler dizisine parametre
            //olarak verdık ve ürünleri foreachle bastırdık.


            Product ürün1 = new Product();
           
            ürün1.Adi = "elma";
            ürün1.Fiyati = 10;
            ürün1.Acıklama = "güzel bir elma";

            Product ürün2 = new Product();
            ürün2.Adi = "armut";
            ürün2.Fiyati = 15;
            ürün2.Acıklama = "güzel bir armuttur.";

            Product[] ürünler = new Product[] {ürün1,ürün2};

            foreach (var product in ürünler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Acıklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("************************************");

            }

            Console.WriteLine("***********METOTLAR*************");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(ürün1);
            sepetManager.Ekle(ürün2);



            Console.ReadLine();



        }
    }
}
