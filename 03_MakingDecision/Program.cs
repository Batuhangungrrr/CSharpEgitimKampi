namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital=="Ankara" & country=="Türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("Sayıyı giriniz : ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, averange;
            //string result="Hata!";
            //Console.Write("Sınav1 :  ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2 :  ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3 :  ");
            //exam3 = int.Parse(Console.ReadLine());

            //averange = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması : " + averange);

            //if (averange > 0 & averange <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (averange > 50 & averange <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (averange > 70 & averange <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (averange > 84)
            //{
            //    result = "Sonuç cok iyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lutfen şehir girişi yapınız : ");
            //city = Console.ReadLine();
            //if (city == "Adana" | city == "Ankara" |  city == "Trabzon" | city == "Bursa")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınız giriniz : ");
            //string userName=Console.ReadLine();
            //if (userName != "admin" )
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}


            #endregion

            #region  Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz :");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);


            //Console.Write("Lutfen sayıyı giriniz :");
            //int number = int.Parse(Console.ReadLine());

            //if (number%2==0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz : ");
            //team=char.Parse(Console.ReadLine());

            //if (team=='g'| team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if(team=='t'| team == 'T')
            //{
            //    Console.Write("Trabzonspor");
            //}

            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("***** C# Eğitim Kampı Restoran  *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediginiz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Ana Yemekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-----------------Ana Yemekler-----------------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Çorbalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("-----------------Çorbalar-----------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Pizzalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-----------------Pizzalar-----------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------İçecekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-----------------İçecekler-----------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Tatlılar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-----------------Tatlılar-----------------");
            //}

            #endregion

            #region  Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız : ");
            //int mouthNumber = int.Parse(Console.ReadLine());

            //switch (mouthNumber)
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

            //    default: Console.Write("Hatalı Veri Girişi"); break;

            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı Giriniz :");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı Giriniz :");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediginiz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam :" + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark :" + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma :" + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm :" + result);
            //        break;
            //}

            #endregion


        }

    }
}

