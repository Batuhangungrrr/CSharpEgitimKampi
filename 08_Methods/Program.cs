namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Metotlar

            //()
            //Geriye deger  döndürmeyen metotlar (Void)
            //

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();



            #endregion

            #region Geriye değer Döndürmeyen string parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.Write($"Müşteri Adı: {name} " +
            //        $"Müşteri Soyadı: {surname} ");
            //}
            //CustomerCard("Mehmet ","Yıldız");
            //CustomerCard("Ayşegül  ","kaya");

            #endregion

            #region Geriye değer Döndürmeyen int parametreli Metotlar

            //void  Sum(int number1,int number2,int number3)
            //{
            //    int result=number1 + number2+number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geri Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geri Değer Döndüren String Parametreli  Metotlar

            //string CountryCard(string countryName, string capital, string flgColor)
            //{
            //    string cardInfo = "\nÜlke : " + countryName + " " + "\nBaşkent : " + capital + " " + "\nBayrak Rengi :" + flgColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankra","Kırmızı - Beyaz"));

            #endregion

            #region Geri Değer Döndüren Int Parametreli  Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " İsimli Ögrenci Sınavı Geçti" + "Ortalama :" + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli Ögrenci başarısız oldu" + " Ortalama :" + result;
            //    }
            //}


            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Ayşe", 36, 45, 33));

            #endregion 


            Console.Read();
        }
    }
}
