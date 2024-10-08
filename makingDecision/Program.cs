using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else





            //Console.Write("Lütfen Şifreyi giriniz:  ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")

            //{


            //    Console.WriteLine("Şifre Doğru");


            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");



            //}

            //Console.ReadKey();


            //string capital, country;
            //Console.Write("Başkenti Giriniz");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz");

            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");


            //}
            //else
            //{
            //    Console.WriteLine("Veriler Doğrulanamadı");
            //}

            // Console.ReadKey(); 

            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");

            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayi Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi yanlıs");
            //}



            //    Console.ReadKey();


            //double exam1, exam2, exam3, average;
            //string result;
            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average=(exam1+exam2 + exam3)/3;
            //Console.Write("Sınavların Ortalaması:"+ average);
            //if (average > 0 & average <=50)
            //{
            //    result = "sonuc vasat";


            //}
            //if(average>50 & average <=70)
            //{
            //    result = " Sonuc Orta";

            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok iyi";
            //}

            // string city;
            // Console.Write("Lütfen şehir girişi yapınız");
            // city = Console.ReadLine();
            // if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            // {       Console.WriteLine("şehir mevcut");
            //}

            //else

            // { 

            //     Console.WriteLine("şehir mevcut degıl");
            // }

            //        Console.Write("Lütfen kullanıcı adı giriniz");
            //        string username = Console.ReadLine();
            //        if (username != "admin") 
            //        {
            //            Console.Write("Bu Kullanıcı Adı Kabul Edilemez");
            //                }
            //        else
            //        {
            //            Console.Write("Hoş Geldiniz");
            //        }







            //Console.ReadKey();






            #endregion
            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int sonuc = number % 5;
            //Console.WriteLine(sonuc);
            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sayıyı giriniz");
            //int number2=int.Parse(Console.ReadLine());

            //int sonuc = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölumunden kalan" + sonuc);


            //Console.Write("Lütfen Sayıyı giriniz ");
            //int number=int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.Write("Sayi Cifttir");
            //        }
            //else
            //{
            //    Console.Write("Sayi Tektir");

            //        }

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz");
            //team=char.Parse(Console.ReadLine());
            //if(team=='g' | team=='G')
            //{ Console.Write("Galatasaray");
            //}
            //if (team == 'F' | team =='f')
            //{
            //    Console.Write("Fenerbahce");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}






            //Console.ReadKey();









            #endregion
            #region Örnek Proje uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.Write(" Detayını Görmek İstediğiniz menü seçimi");
            //menuItem= Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------Ana Yemekler--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Köri Soslu Tavuk");
            //    Console.WriteLine("Kızartma Tabağı");
            //    Console.WriteLine("Karnıyarık");
            //    Console.WriteLine("Lahmacun");
            //    Console.WriteLine("Fırında Levrek");
            //    Console.WriteLine("--------------------Ana Yemekler--------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------ÇORBALAR--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Mercimek Çorbası");
            //    Console.WriteLine("Paça Çorbası");

            //    Console.WriteLine("--------------------ÇORBALAR--------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------Pizzalar--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Sucuklu Pizza");
            //    Console.WriteLine("Karışık Pizza");

            //    Console.WriteLine("--------------------Pizzalar--------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------İçecekler--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Kola");
            //    Console.WriteLine("Sprite");

            //    Console.WriteLine("--------------------İçecekler--------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------Tatlılar--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("İrmik Tatlısı");
            //    Console.WriteLine("Triliçe");

            //    Console.WriteLine("--------------------Tatlılar--------------------");
            //    Console.WriteLine();
            //}





            Console.ReadKey();



            #endregion

            #region Switch Case



            //Console.Write("Lütfen Ay girişi Yapınız");
            //int monthNumber=int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;

            //        default:Console.Write("Hatalı Veri Girişi");break;
            //}





            #endregion
            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.Sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediginiz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case  '-':
            //            result= number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölü: " + result);
            //        break;



            //}






            //switch (symbol)
            
            //{

            //}







            #endregion






            Console.Read();
        }
    }
    }
