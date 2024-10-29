using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba");
            //Console.WriteLine("*********************Yemek Kategorileri*********************");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*********************Yemek Kategorileri*********************");

            #endregion

            #region String_Değişkenler 

            //String 
            // Değişken_türü Değişken_adı;

            //string name;
            //name = "Oruç";
            //Console.WriteLine(name);

            //string customerName;
            //String customerSurname;
            //String customerPhone;
            //String customerEmail, district, city;

            //customerName = "Oruç";
            //customerSurname = "Altundağ";
            //customerPhone = "05444914810";
            //customerEmail = "dadilarli85@gmail.com";
            //district = "Ortaköy";
            //city = "Aksaray";

            //Console.WriteLine("*************************Rezervasyon Kartı**************************");
            //Console.WriteLine("--------------------------------------------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+ customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------------------------");

            //customerName = "Damla";
            //customerSurname = "Kılıç";
            //customerPhone = "05357331205";
            //customerEmail = "bdamlaklc1801@gmail.com";
            //district = "Nizip";
            //city = "Gaziantep";

            //Console.WriteLine("--------------------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------------------------");


            #endregion

            #region Int_Değişkenler

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int frisepRİCE = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("************************RESTORAN MENU*************************");
            //Console.WriteLine();
            //Console.WriteLine("---- Hamburger : " + hamburgerPrice + "TL");
            //Console.WriteLine("---- Pizza : " + pizzaPrice + "TL");
            //Console.WriteLine("---- Kola : " + cokePrice + "TL");
            //Console.WriteLine("---- Limonata : " + lemonadePrice + "TL");
            //Console.WriteLine("---- Kızartma : " + frisepRİCE + "TL");
            //Console.WriteLine("---- Su : " + waterPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("***************************************************************");
            //Console.WriteLine();

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int frisepCount;
            //int pizzaCount;
            //int lemonCount;

            //int totalPrice=0;

            // hamburgerCount=3;
            // cokeCount=3;
            // waterCount=1;
            // frisepCount=1;
            // pizzaCount=0;
            // lemonCount=0;

            //totalPrice= hamburgerCount*hamburgerPrice+cokePrice*cokeCount+waterCount*waterPrice+frisepRİCE*frisepCount+pizzaCount*pizzaPrice+lemonadePrice*lemonCount;

            //Console.WriteLine("Ödenecek Tutar : " + totalPrice);




            #endregion

            #region Double_Değişkenler

            //Console.WriteLine("****************MANAV FİYAT LİSTESİ*************");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, tomatoPrice, PatatoPrice;
            //applePrice =14.85;
            //orangePrice = 20.85;
            //strawberryPrice = 45;
            //tomatoPrice = 9.74;
            //PatatoPrice = 6.88;

            //Console.WriteLine("--------------- Elma birim fiyatı: {0} ", applePrice );
            //Console.WriteLine("--------------- Portakal birim fiyatı: {0} ", orangePrice);
            //Console.WriteLine("--------------- Çilek birim fiyatı: {0} ", strawberryPrice);
            //Console.WriteLine("--------------- Domates birim fiyatı: {0} ", tomatoPrice);
            //Console.WriteLine("--------------- Patates birim fiyatı: {0} ", PatatoPrice);

            //double appleGram, orangeGram, strawberryGram, tomatoGram, PatatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.243;
            //strawberryGram = 0.759;
            //tomatoGram = 3.350;
            //PatatoGram = 3.560;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawTotalPrice = strawberryPrice * strawberryGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double patatoTotalPrice = PatatoPrice * PatatoGram;
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün : Elma /-/ " + " Birim  Fiyatı: " + applePrice + " /-/ Gramaj: "+appleGram + " /-/ Toplam tutar : " + appleTotalPrice+ "TL");
            //Console.WriteLine("Alınan ürün : Portakal /-/ " + " Birim  Fiyatı: " + orangePrice + " /-/ Gramaj: "+orangeGram + " /-/ Toplam tutar : " + orangeTotalPrice+ "TL");
            //Console.WriteLine("Alınan ürün : Çilek /-/ " + " Birim  Fiyatı: " + strawberryPrice + " /-/ Gramaj: "+strawberryGram + " /-/ Toplam tutar : " + strawTotalPrice+ "TL");
            //Console.WriteLine("Alınan ürün : Domates /-/ " + " Birim  Fiyatı: " + tomatoPrice + " /-/ Gramaj: "+tomatoGram + " /-/ Toplam tutar : " + tomatoTotalPrice+ "TL");
            //Console.WriteLine("Alınan ürün : Patates /-/ " + " Birim  Fiyatı: " + PatatoPrice + " /-/ Gramaj: "+PatatoGram + " /-/ Toplam tutar : " + patatoTotalPrice+ "TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + tomatoTotalPrice + patatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Ödeyeceğiniz Miktar KDV dahil {0} TL'dir... Güzel Günler dileriz ",shoppingTotalPrice);  




            #endregion

            #region Char_Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavye_Veri_Girişleri

            //Console.WriteLine("***********CSharp Hava Yolları Yolcu Bilgisi************");
            //Console.WriteLine();
            //string pessengerName, pessengerSurname, pessengerDistrict, pessengerCity, pessengerAge, pessengerIdentityNumber;

            //Console.WriteLine("Yolcu Adı : ");
            //pessengerName = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı : ");
            //pessengerSurname = Console.ReadLine();

            //Console.WriteLine("Yolcu İlçe : ");
            //pessengerDistrict = Console.ReadLine();

            //Console.WriteLine("Yolcu Şehir : ");
            //pessengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş : ");
            //pessengerAge= Console.ReadLine();

            //Console.WriteLine("Yolcu Tc : ");
            //pessengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();


            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine(" Yolcu TC no : {0}  Yolcu Adı Soyadı : {1} {2}  Yolcu Yaş : {3}   {4}/{5} ",pessengerIdentityNumber,pessengerName,pessengerSurname,pessengerAge,pessengerDistrict,pessengerCity);



            #endregion

            #region Klavyeden_Tam_Sayı_Girişleri_ve_Dönüşümler

            //int shoePrice, computerPrice, chairPrice, TVPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //TVPrice = 12000;

            //int shoeCount, computerCount, chairCount, TVCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount =int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount =int.Parse( Console.ReadLine());


            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount =int.Parse( Console.ReadLine());


            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //TVCount =int.Parse( Console.ReadLine());

            //int totalPrice = shoeCount*shoePrice + computerCount*computerPrice + chairCount*chairPrice + TVPrice*TVCount;

            //Console.WriteLine();

            //Console.Write("Toplam ödemeniz gereken tutar : " + totalPrice);


            #endregion

            #region Klavyeden_Ondalıklı_Sayı_işlemleri

            //double exam1, exam2,exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : {0}",result); 


            #endregion

            #region Klavyeden_Karakter_Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyetinizi seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet : {0}", gender);




            #endregion

            #region  If  Else

            //Console.WriteLine("Lütfen Şifreyi giriniz");
            //string password;
            //password = Console.ReadLine();
            //if (password == "asdf")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şİfre hatalı");
            //}
            // ******************************************************
            //string capital, country;
            //Console.WriteLine("Başkent giriniz");
            //capital = Console.ReadLine();


            //Console.WriteLine("Ülkeyi giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı veri");
            //}
            //*****************************************************************************

            //int sayi;
            //Console.WriteLine("Bir sayı giriniz");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 68)
            //{
            //    Console.WriteLine("SAyi doğru");
            //}
            //else { Console.WriteLine("Sayı yanlış"); }
            //***********************************************************************************************
            //int exam1, exam2, exam3, average;
            //string result;

            //Console.WriteLine("Sınav1:  ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav2:  ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav3:  ");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1+exam2+exam3)/3;

            //Console.WriteLine(average);

            //if (average > 50)
            //{
            //    result = "Geçti";
            //}
            //else { result = "Kaldı"; }


            //Console.WriteLine(result);

            //************************************************************************************************

            //Console.WriteLine("Lütfen şehir girişi yapınız");
            //string city = Console.ReadLine();
            //if (city == "aksaray" | city == "kırşehir" | city == "ankara" | city == "İstanbul")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else { Console.WriteLine("Şehir mevcut değil.."); }

            //**************************************************************************************************

            //Console.WriteLine("Lütfen Kullanıcı adını giriniz..");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{ Console.WriteLine("Bu kullanıcı adı kabul edilemez"); }
            //else { Console.WriteLine("Hoşgeldiniz"); }
















            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 34;

            //int result = number % 5;
            //Console.WriteLine(result);

            //*****************************************************

            //Console.WriteLine("1. Sayiyi giriniz.");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayiyi giriniz.");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number % number2;

            //Console.WriteLine("1. SAyinin 2. sayiya bölümünden kalan : {0}",result);

            //************************************************************************

            //Console.WriteLine("Bir sayi giriniz");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayi çifttir");

            //}
            //else
            //{
            //    Console.WriteLine("Sayi tektir");
            //}

            //***************************************************************************
            #endregion

            #region Char değişkeni ile karar yapıları
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");

            //team = char.Parse(Console.ReadLine());

            //if (team =='G' | team =='g')
            //{ Console.WriteLine("GALATASARAY"); }

            //if(team=='F'|team=='f')
            //{ Console.WriteLine("fenerbahçe"); }

            //if (team == 'B' | team == 'b')
            //{ Console.WriteLine("beşiktaş"); }

            //*******************************************************************************







            #endregion

            #region Örnek_Proje Uygulaması


            //Console.WriteLine("*****************C# Eğitim Kampı Restoran*****************");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine("1-Anayemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------------------------------");


            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menuyu seçiniz : ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("****************Ana Yemekler*********");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Makarna");
            //    Console.WriteLine("3-Karnıyarık");
            //    Console.WriteLine("4-Hamsi Tava");
            //    Console.WriteLine("5-Kuru Fasulye sulusu");
            //    Console.WriteLine();
            //    Console.WriteLine("****************Ana Yemekler*********");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("****************Pizzalar*********");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sucuklu");
            //    Console.WriteLine("2-Mantarlı");
            //    Console.WriteLine("3-Kaşarlı");
            //    Console.WriteLine("4-Double Karışık");
            //    Console.WriteLine("5-Akdeniz");
            //    Console.WriteLine();
            //    Console.WriteLine("****************Pizzalar*********");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("****************Çorbalar*********");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ezogelin");
            //    Console.WriteLine("2-Mercimek");
            //    Console.WriteLine("3-Kellepaça");
            //    Console.WriteLine("4-Yoğurt");
            //    Console.WriteLine("5-Sebze");
            //    Console.WriteLine();
            //    Console.WriteLine("****************Çorbalar*********");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("****************İçecekler*********");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Fanta");
            //    Console.WriteLine("4-Şalgam");
            //    Console.WriteLine("5-Limonata");
            //    Console.WriteLine();
            //    Console.WriteLine("****************İçecekler*********");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("****************Tatlılar*********");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Künefe");
            //    Console.WriteLine("3-Kemalpaşa");
            //    Console.WriteLine("4-Tremisu");
            //    Console.WriteLine("5-Sufle");
            //    Console.WriteLine();
            //    Console.WriteLine("****************Tatlılar*********");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}






            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay girişi yapılsın: ");
            //int monthnumber=int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{

            //    case 1:Console.Write("Ocak");break;
            //    case 2:Console.Write("Şubat");break;
            //    case 3:Console.Write("Mart");break;
            //    case 4:Console.Write("Nisan");break;
            //    case 5:Console.Write("Mayıs");break;
            //    case 6:Console.Write("Haziran");break;
            //    case 7:Console.Write("Temmuz");break;
            //    case 8:Console.Write("Ağustos");break;
            //    case 9:Console.Write("Eylül");break;
            //    case 10:Console.Write("Ekim");break;
            //    case 11:Console.Write("Kasım");break;
            //    case 12:Console.Write("Aralık");break;




            //    default:Console.Write($" Yanlış numara : month number: {monthnumber}");
            //        break;
            //}

            #endregion

            #region Switch Case : Hesap Makinesi

            //int number1, number2;
            //double result;
            //char symbol;

            //Console.WriteLine("1. Sayiyi giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
            //symbol=char.Parse(Console.ReadLine());



            //switch (symbol)
            //{
            //    case '+': 
            //        result = number1 + number2; Console.WriteLine(result); break;

            //    case '-':
            //        result = number1 - number2; Console.WriteLine(result); break;

            //    case '*':
            //         result = number1 * number2; Console.WriteLine(result); break;
            //    case '/':
            //         result = number1 / number2; Console.WriteLine(result); break;



            //    default: Console.WriteLine("Hatalı işlem seçimi...");
            //        break;
            //}


            #endregion

            #region For_Döngüsü

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i=1; i<=finishValue;i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET");
            //}

            #endregion

            #region For_Döngüsü_İle_Karar_Yapıları

            //for (int i = 0; i < 100; i++)   
            //{
            // if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            ////************************************

            //int TotalValue = 0;

            //for (int i = 0; i < 10; i++) { 
            //TotalValue += i;
            //}
            //Console.WriteLine(TotalValue);

            ////****************************************
            ///

            //int TotalValue = 0;

            //for (int i = 0; i < 15; i++)
            //{
            //    if (i%2==0)
            //    {
            //        TotalValue += i;
            //        Console.WriteLine(i);

            //    }


            //}
            //Console.WriteLine("||||||||||||||||||||||||||||||||||||||");
            //Console.WriteLine(TotalValue);

            ////****************************************

            //int count = 0;
            //for (int i = 0; i < 50; i++)
            //{

            //    if (i % 8 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            ////****************************************


            //Her saat başı 2 katına çıkan bir bakterinin girilen saate göre o saatte ki bakteri sayısını veren programı yapınız:
            //

            //Console.WriteLine("Kaç saat sonundaki bakteri sayısını görmek istiyorsunuz.");
            //int hour = int.Parse(Console.ReadLine());
            //int bacterıum = 1;

            //for (int i = 1; i <= hour; i++)
            //{
            //    bacterıum = bacterıum * 2;

            //}
            //Console.WriteLine("{0} Saat sonunda bakteri sayısı {1}",hour,bacterıum);











            #endregion

            #region While_Döngüsü

            //int i=0;
            //while (i<10) {
            //    Console.WriteLine(i);
            //    i++;    
            //}

            ////********************************
            ///

            //int i = 1;
            //int sum = 0;

            //while (i < 10)
            //{
            //    sum+=i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek_Sınav_Sorusu

            ////Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız
            //Console.WriteLine("3 basamaklı bir sayı giriniz");
            //int sayi=int.Parse(Console.ReadLine());

            //int birler,onlar,yuzler;

            //birler = sayi % 10;
            //onlar = (sayi % 100) / 10;
            //yuzler = sayi / 100;

            //Console.WriteLine($"yüzler: {yuzler}  onlar: {onlar}   birler: {birler}");
            //int top = onlar+birler+yuzler;

            //Console.WriteLine("Rakamlar toplamı : {0}",top);






            #endregion

            #region Yıldızlarla_İşlemler


            #region Yan_Yana_10_Tane_Yıldız_Oluşturma


            //for (int i = 0; i < 10; i++) { Console.Write("*"); }

            #endregion

            #region Alt_alta_10_tane_yıldız_oluşturma 

            //for (int i = 0; i < 10; i++) { Console.WriteLine("*"); }

            #endregion

            #region Alt_alta_10_tane_yıldız_oluşturma_Her_Satırda_10_Yıldız_Olsun 

            //for (int i = 0; i < 10; i++) { Console.WriteLine("**********"); }

            #endregion

            #region Yıldızlarla_Dik_Üçgen
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < i; j++) { Console.Write("*"); }
            //    Console.WriteLine();
            //}


            #endregion

            #region Yıldızlarla_Ters_Dik_Üçgen

            //for (int i = 10; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++) { Console.Write("*"); }
            //    Console.WriteLine();
            //}


            #endregion

            #region Dik_ve_Ters_Dİk_Üçgenin_Birleşimi

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < i; j++) { Console.Write("*"); }
            //    Console.WriteLine();
            //}


            //for (int i = 10; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++) { Console.Write("*"); }
            //    Console.WriteLine();
            //}



            #endregion

            #region Baklava_Dilimi




            //int n = 5; 

            //// Üst üçgen
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Alt üçgen
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();


            //}


            #endregion

            #region Piramit

            //int n = 5;
            //// üst üçgen
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //            Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters_Piramit

            //// Alt üçgen
            //int n = 7;
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();


            //}

            #endregion




            #endregion




            Console.Read();
        }
    }
}





//Yazdırma komutları