﻿namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Degişkenler
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL ");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL ");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double aplleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("\nAlınan Ürün : Elma -" + "Birim Fiyat : " + applePrice + " - Gramaj : " + appleGram + " - Toplam Tutar : " + aplleTotalPrice);
            //Console.WriteLine("\nAlınan Ürün : Portakal -" + "Birim Fiyat : " + orangePrice + " - Gramaj : " + orangeGram + " - Toplam Tutar : " + orangeTotalPrice);
            //Console.WriteLine("\nAlınan Ürün : Çilek -" + "Birim Fiyat : " + strawberryPrice + " - Gramaj : " + strawberryGram + " - Toplam Tutar : " + strawberryTotalPrice);
            //Console.WriteLine("\nAlınan Ürün : Patates -" + "Birim Fiyat : " + potatoPrice + " - Gramaj : " + potatoGram + " - Toplam Tutar : " + potatoTotalPrice);
            //Console.WriteLine("\nAlınan Ürün : Domates -" + "Birim Fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice);


            //double shoppingTotalPrice = aplleTotalPrice + strawberryTotalPrice + tomatoTotalPrice + orangeTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("\nAlışveriş Toplam Tutar : " + shoppingTotalPrice + " TL ");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region  Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** C# Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No :" + passengerIdentityNumber + " - Yolcu Ad Soyad : " + 
            //    passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldıgınız Ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + tvCount * tvPrice + chairCount * chairPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar : " + totalPrice);


            #endregion

            #region  Klavyeden Ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunu giriniz:  ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz:  ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz:  ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalama sınav ortalamanız:  " + result);


            #endregion

            #region Klavyeden karakter girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiginiz cinsiyet : " + gender);


            #endregion

            Console.Read();
        }
    }
}
