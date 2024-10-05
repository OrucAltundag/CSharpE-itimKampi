﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects { 

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


            Console.Read();
        }
    }
}





//Yazdırma komutları