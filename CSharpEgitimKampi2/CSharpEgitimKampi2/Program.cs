using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpEgitimKampi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel_Dizi_Örnekleri

            //String[] colors = new string[4];

            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "Green";
            //colors[3] = "Blue";

            //Console.WriteLine(colors[2]);



            //string[] cities = new string[5];

            //cities[0] = "Aksaray";
            //cities[1] = "Gaziantep";
            //cities[2] = "Bolu";
            //cities[3] = "Konya";
            //cities[4] = "Ordu";

            //Console.WriteLine(cities[4]);



            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 23;
            //numbers[2] = 50;
            //numbers[3] = 678;
            //numbers[7] = 33;
            //Console.WriteLine(numbers[5]);








            #endregion

            #region Dizideki_Tüm_Elemanları_Listeleme


            //string[] colors = { "Kırmızı", "Sarı", "Yeşil", "Mor" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] sayi = {12,23,34,56,4,56,7645,32,4,3453 };

            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    if (sayi[i] %3 ==0)
            //    {
            //        Console.WriteLine(sayi[i]);
            //    }
            //}


            //char[] symbol = {'a','b','c','/','(','+' };

            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}


            //Dizideki en büyük elemanı bulma
            //

            //int[] sayılar = { 21, 43, 63, 546, 534, 2431, 253265, 765, 353142, 543676, 542365, 654352, 7658, 543 };
            //int enbuyuk;
            //enbuyuk = sayılar[0];
            //for (int i = 1; i < sayılar.Length; i++)
            //{

            //    if (sayılar[i] > enbuyuk)
            //    {
            //        enbuyuk = sayılar[i];
            //    }
            //}
            //Console.WriteLine(enbuyuk);

            //string[] persons = { "Ali", "Ayşe", "fatma", "Deniz" };

            //Console.WriteLine(persons.Length);



            //int[] numbers = { 1, 2, 34, 5, 23, 432, 43, 23, 33, 42, 32 };
            //Array.Sort(numbers); //diziyi sıralama

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 34, 5, 23, 432, 43, 23, 33, 42, 32 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers); //Tersine çevirme

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi_Metotlar

            //string[] customers = { "Ali", "Ayşe", "Damla", "Nazlı", "Fatih", "Mehmet" };
            //int index = Array.IndexOf(customers, "Fatih");

            //Console.WriteLine(index);


            //int[] sayi = {12,23,34,56,4,56,7645,32,4,3453 };

            //Console.WriteLine("Dizininin En büyük Elemanı: " + sayi.Max() + "   Dizinin en küçük elemanı : " + sayi.Min() );










            #endregion

            #region Kullanıcıdan_değer_Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri giriniz  :  ");
            //    cities[i] = Convert.ToString(Console.ReadLine());

            //}

            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"{i+1}. ");
            //    Console.WriteLine(cities[i]);
            //}




            //int[] sayi = { 12, 23, 34, 56, 4, 56, 7645, 32, 4, 3453 };
            //int sum = 0;

            //for (int i = 0; i < sayi.Length; i++) { sum += sayi[i]; }

            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //Console.WriteLine("Çift sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //   if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Tek sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}



            #endregion

            #region Foreach_Döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int [] numbers = { 1, 2, 3, 4, 5, 6 };  

            //foreach (int number in numbers)
            //{  Console.WriteLine(number); }


            // 2 ye tam bölünen sayılar

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int toplam = 0;

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    { Console.WriteLine(number); }
            //    toplam+=number;
            //}

            //// Toplamı
            //Console.WriteLine("Toplamı : {0} ",toplam);




            //List<string> list = new List<string>()
            //{
            //    "oruç","ali","hakan"
            //};

            //foreach (var item in list) 
            //{
            //Console.WriteLine(item);
            //}


            ////String değişkeni char haline göre parçalama


            //string word = "Merhaba";

            //foreach (char x in word) { Console.WriteLine(x); }



            #endregion

            #region Örnek_Sınav_Sistemi_Uygulaması

            //Console.Write("  *********C# Eğitim Kampi Sınav Uygulaması ************  ");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("--------------------------------");

            //Console.Write("Sınıfınızda kaç öğrenci var :  ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------");

            //string[] StudentNames = new string[studentCount];
            //double[] StudentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{

            //    Console.WriteLine($"{i + 1}. Öğrencinin ismini giriniz ");
            //    StudentNames[i] = Console.ReadLine();

            //    double TotalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($" {StudentNames[j]} adlı öğrencinin {j + 1}. Sınav Notunu giriniz ");
            //        double value = double.Parse(Console.ReadLine());
            //        TotalExamResult += value;
            //    }

            //    StudentExamAvg[i] = TotalExamResult / 3;

            //    for (int j = 0; j < studentCount; j++)
            //    {
            //        Console.WriteLine($"{StudentNames[i]}  adlı öğrencinin  ortalaması : {StudentExamAvg[j]}");

            //    }


            //    if (StudentExamAvg[i] > 50)
            //    {
            //        Console.WriteLine($"{StudentNames[i]} adlı öğrenci dersi geçti");

            //    }
            //    else {
            //        Console.WriteLine($"{StudentNames[i]} adlı öğrenci dersen kaldı");
            //    }




            #endregion

            #region Void_Metodlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yılmaz");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1, y = 2, z = 3;

            //    int t = x + y + z;
            //    Console.WriteLine(t);


            //}

            //sum();







            #endregion

            #region Geriye_Değer_Döndürmeyen_Parametli_Metotlar

            //void CustomerCard (string name, string Surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + Surname);

            //}

            //CustomerCard("Oruç","ALtundağ");


            #endregion

            #region Geriye_Değer_Döndürmeyen_Int_Parametreli_Metotlar

            //void sum  (int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(12, 23, 34);




            #endregion

            #region Geriye_Değer_Döndüren_Metotlar

            //string CustomerName()
            //{


            //    return "Origi" + " " + "Ben";


            //}


            //String name = CustomerName(); 

            //Console.WriteLine(name);





            #endregion

            #region Geriye_Değer_Döndüren_String_Parametreli_Metotlar

            //string  CountryCard(string CountryName, string capital, string flagColor)
            //{
            //    string Cardİnfo = "Ülke : " + CountryName + " - Başkent : " + capital + " - Bayrak Rengi : " + flagColor;
            //    return Cardİnfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz : ");
            //x = Console.ReadLine();
            //Console.WriteLine("Başkent Adını Giriniz : ");
            //y = Console.ReadLine();
            //Console.WriteLine("Bayrak Rengini Giriniz : ");
            //z = Console.ReadLine();

            //string result = CountryCard(x, y, z);

            //Console.WriteLine(result);



            #endregion


            #region Geriye_Değer_Döndüren_Int_Parametli_Metotlar

            //int sum(int number1,int number2) { 

            //    int result = number1 + number2;
            //    return result; }

            //Console.WriteLine(sum(7,2));
            //Console.WriteLine(sum(71,22));
            //Console.WriteLine(sum(347,221));
            //Console.WriteLine(sum(732,3212));

            #endregion

            #region Örnek_Sınav

            //string ExamResult(String sname, int Exam1 , int Exam2, int  Exam3 )

            //{
            //    int result = (Exam1 + Exam2 + Exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return sname + " İsimli öğrenci sınavı geçti" + "  OrtALAMA : " + result;
            //    }
            //    else
            //    {
            //        return sname + " İsimli öğrenci sınavı geçemedi" + "  OrtALAMA : " + result;
            //    }
            //}
            


            //Console.WriteLine(ExamResult("Oruç", 89, 79, 100));

            //Console.WriteLine(ExamResult("Mustafa", 19, 59, 34));

            #endregion







            Console.ReadKey();

        }
    }
}

