using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDeğişkenler
            //double number = 4.58;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Shopping Total ****");
            //Console.WriteLine();
            //double applePrice = 43.60 , orangePrice = 56.48 , strawberryPrice  = 84.40;
            //double appleGram = 2.355, orangeGram = 4.506, strawberryGram = 0.650;
            //double appleTotal , orangeTotal, strawberryTotal;
            //appleTotal = applePrice * appleGram;
            //orangeTotal = orangePrice * orangeGram;
            //strawberryTotal = strawberryPrice * strawberryGram;
            //Console.WriteLine("applePrice:"+ applePrice + "  appleGram:"+ appleGram +"  Total Apple:" + appleTotal);
            //Console.WriteLine() ;
            //Console.WriteLine("orangePrice:"+ orangePrice + "  orangeGram:"+ orangeGram +"  Total Orange:" + orangeTotal);
            //Console.WriteLine();
            //Console.WriteLine("strawberryPrice:"+ strawberryPrice + "  strawberryGram:"+ strawberryGram +"  Total Strawberry:" + strawberryTotal);
            //Console.WriteLine();
            //double Total = appleTotal + orangeTotal + strawberryTotal;
            //Console.WriteLine("Total: " + Total);

            #endregion

            #region charDeğişkenleri
            // tek bir karakter sakalar

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri


            //Console.WriteLine("**** yolcu listesi ****");
            //Console.WriteLine();
            //string passengerName , passengerId , passengerSurname , passengerGender , passengerAge ;
            //Console.Write("passangerName: ");
            //passengerName = Console.ReadLine();
            //Console.Write("passengerSurname: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("passangerAge: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("passangerId: ");
            //passengerId = Console.ReadLine();
            //Console.Write("passangerGander: ");
            //passengerGender = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("-------passenger bilgileri---------");
            //Console.WriteLine();
            //Console.WriteLine("Name: " + passengerName + " Surname: " + passengerSurname);   
            //Console.WriteLine("Age: " + passengerAge + " Gender: " + passengerGender);   




            #endregion

            #region Klavyeden Tam Sayı int Girişleri Ve Dönüşümler

            //int tvPrice, phonePrice, chairPrice;
            //tvPrice = 25000;
            //phonePrice = 15000;
            //chairPrice = 1000;

            //int tvCoast, phoneCoast, chairCoast;
            //Console.Write("aldığınız tv adedini giriniz: ") ;
            //tvCoast =int.Parse(Console.ReadLine());

            //Console.Write("aldığınız telefon adedini giriniz: ") ;
            //phoneCoast=int.Parse(Console.ReadLine());

            //Console.Write("aldığınız sandalye adedini giriniz: ");
            //chairCoast = int.Parse(Console.ReadLine());

            //int totalÜcret;
            //totalÜcret = tvCoast*tvPrice + phoneCoast*phonePrice + chairCoast*chairPrice;
            //Console.WriteLine("Toplam = " + totalÜcret);





            #endregion

            #region Klavyeden Ondalıklı Sayı double Girişleri Ve Dönüşümleri

            //double exam1, exam2, result;
            //Console.Write("lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2)/ 2 ;
            //Console.Write("ortalamanız: " + result);

            #endregion

            #region Klavyeden karakter char Girişleri

            // char değişkeninde girdi bir karakter uzunluğunda olmalıdır

            //char gender;
            //Console.Write("lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
