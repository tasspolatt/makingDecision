using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01derskonuları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            // Console.WriteLine("Merhaba");
            // Console.Write("selam");
            //    Console.WriteLine("***** Yemek Kategorileri *****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Çorbalar");
            //    Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine ("3-soguk yemekler");
            //    Console.WriteLine("4-Salatalar");
            //    Console.WriteLine("5-Tatlılar");
            //    Console.WriteLine("6-icecekler");
            //    Console.WriteLine();
            //    Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            //string
            //Değişkenin_türü değişken_adı;
            //string name;
            //name = "Polat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "00000000";
            //customerEmail = "deneme@gmail.com";
            //district = "Silifke";
            //city = "Mersin";
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------");

            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);

            //Console.WriteLine("İletişim:"+ customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail ) ;
            //Console.WriteLine("Adres: " + district + "/" + city );

            //Console.WriteLine();





            //customerName = "Ayşe";
            //customerSurname = "Atar";
            //customerPhone = "00000000";
            //customerEmail = "deneme2@gmail.com";
            //district = "Erdemli";
            //city = "Mersin";
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------");

            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);

            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);












            #endregion

            #region Int Değişkenler
            //int
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokeprice = 35;
            int waterprice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            int toplam = hamburgerPrice + cokeprice + waterprice + friesPrice + pizzaPrice + lemonadePrice;


            Console.WriteLine("****** Restoran Menü Fiyatı *****");
            Console.WriteLine("------Hamburger Fiyatı : " + hamburgerPrice + "TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("------Kola: " + cokeprice + " TL");
            Console.WriteLine("------Limonate: " + lemonadePrice + " TL");
            Console.WriteLine("------Kızartma: " + friesPrice + " TL");
            Console.WriteLine("------Su: " + waterprice + " TL");
            Console.WriteLine("------Toplam ücret " + toplam );


            int hamburgerCount;
            int cokeCount;
            int waterCount; 
            int friesCount; 
            int pizzaCount; 
            int lemonadeCount;

            int totalHamburgerPrice = 0;


            int totalCokePrice;
            int totalWaterprice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 3;
            pizzaCount = 3;
            lemonadeCount = 3;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokeprice;
            totalWaterprice = waterCount * waterprice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalPizzaPrice = pizzaCount * pizzaPrice;


            Console.WriteLine("------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterprice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");


            int totalPrice = totalCokePrice + totalWaterprice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar " + totalPrice + "TL");
            


            #endregion

            Console.Read();

        }
    }
}




//Yazdırma Komutları
