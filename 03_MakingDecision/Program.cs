using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Şifre Giriniz: ");
            //string şifre = Console.ReadLine();
            //if (şifre == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");

            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //Console.Write("ülkeyi giriniz: ");
            //string country= Console.ReadLine();
            //Console.Write("capital giriniz:" );
            //string capital = Console.ReadLine();
            //if (capital== "ankara" && country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //     Console.WriteLine("bilgiler yanlış");
            //}


            //Console.Write("sayıyı giriniz: ");
            //int number =Convert.ToInt32(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //} 

            //Console.Write("exam1: ");
            //int exam1 = Convert.ToInt32 (Console.ReadLine());
            //Console.Write("exam2: ");
            //int exam2 = Convert.ToInt32 (Console.ReadLine());
            //Console.Write("exam3: ");
            //int exam3 = Convert.ToInt32 (Console.ReadLine());
            //int result = (exam1 + exam2 + exam3) / 3;
            //if (result>0 && result<50)
            //{
            //    Console.WriteLine("sınav başarısız");
            //}
            //if (result >= 50 && result<=70)
            //{
            //    Console.WriteLine("sınav orta");
            //}
            //if (result<100 && result > 70)
            //{
            //    Console.WriteLine("sınav başarılı");
            //}
            //Console.WriteLine(result);

            // | işareti veya anlamına gelir if else lerde
            // != değilse demektir if else lerde




            // Console.ReadLine();



            #endregion

            #region Mod İşlemleri

            //Console.Write("bir sayı giriniz: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("bir sayı giriniz: ");
            //int number= Convert.ToInt32(Console.ReadLine());
            //if (number %2 == 0)
            //{
            //    Console.WriteLine("sayı çift");
            //}
            //else
            //{ Console.WriteLine("sayı tek"); }

            #endregion

            #region Char İşlemleri

            //Console.Write("bir karakter giriniz: ");
            //char c = Convert.ToChar(Console.ReadLine());
            //if (c =='g' || c== 'G')
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //if (c == 'f' || c == 'F')
            //{
            //    Console.WriteLine("fenerbahçe");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** Yemekhane ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemek");
            //Console.WriteLine("2-Çorba");
            //Console.WriteLine("3-Tatlı");
            //Console.WriteLine();
            //Console.Write("lütfen numara seçiniz: ");
            //int number =Convert.ToInt32 (Console.ReadLine());
            //if (number == 1)
            //{
            //    Console.WriteLine("**** Ana Yemekler ****");
            //    Console.WriteLine("-------------------------");
            //    Console.WriteLine("1-Tavuk Pilav");
            //    Console.WriteLine("2-Balık Makarna");
            //    Console.WriteLine("3-fasulye pilav");
            //}
            //if (number == 2)
            //{
            //    Console.WriteLine("**** Çorbalar ****");
            //    Console.WriteLine("-------------------------");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Yayla");
            //    Console.WriteLine("3-Tarhana");
            //}
            //if (number == 3)
            //{
            //    Console.WriteLine("**** Tatlılar ****");
            //    Console.WriteLine("-------------------------");
            //    Console.WriteLine("1-Tiremisu");
            //    Console.WriteLine("2-Brownie");
            //    Console.WriteLine("3-Baklava");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Ay numarası giriniz: ");
            //int month = Convert.ToInt32(Console.ReadLine());
            //switch  (month)
            //{
            //    case 1: Console.WriteLine("Ocak");break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("MART"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("HAZİRAN"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustost"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kaım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default : Console.WriteLine("hata");break;

            //}



            #endregion

            #region Switch Case Kullanarak Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.sayıyı giriniz: ");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("işareti giriniz: ");
            //symbol = Convert.ToChar(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("sonuç: " + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("sonuç: " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("sonuç: " + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("sonuç: " + result); break;
            //}



            #endregion



            }
    }
}
