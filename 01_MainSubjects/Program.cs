﻿namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya ");
            //Console.Write("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soguk Başlangıclar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            //Degisker_türü değişken_adi;
            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine(
            //    );

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gamil.com";
            //district = "Sapanca";
            //city ="Sakarya";

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine("----------------------------------------");



            #endregion

            #region Int Değişkenler
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---Hamburger Fiyatı : " + hamburgerPrice + " TL");
            Console.WriteLine("---Kola Fiyatı : " + cokePrice + " TL");
            Console.WriteLine("---Su Fiyatı : " + waterPrice + " TL");
            Console.WriteLine("---Patates Kızartması Fiyatı : " + friesPrice + " TL");
            Console.WriteLine("---Pizza Fiyatı : " + pizzaPrice + " TL");
            Console.WriteLine("---Limonata Fiyatı : " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + " TL ");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + " TL ");
            Console.WriteLine("Patates Kızartması Tutarı : " + totalFriesPrice + " TL ");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + " TL ");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + " TL ");

            Console.WriteLine();
            int totalPrice = totalCokePrice + totalFriesPrice + totalHamburgerPrice +
                totalLemonadePrice + totalWaterPrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice + " TL ");



            #endregion

            Console.Read();
        }
    }
}
