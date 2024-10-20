namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //1.Degişken Türü
            //2.Degişken Adı
            //3.In
            //4.Liste , Koleksiyon, Dizi

            //string[] cities = { "Milona", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(var number  in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (var number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach (var number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Kullancıdan Sınıftaki öğrenci sayısını alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç Ögrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");


            ////Ögrenci isimlerini not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. ögrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her ögrenci için 3 sınav girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //Notları topluyoruz
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınav Ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");
            //    //Öğrencilerin ortalaması ve geçip kalma durumları

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı ögrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("----------------------------------------");
            //}




            #endregion

            Console.Read();

        }
    }
}
