using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado. Net 
            string tablenumber;

            Console.WriteLine("********* C# Veri Tabanlı Ürün Bilgi Sistemi**********");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Getirmek istediğiniz Tablo numarasını giriniz");
            tablenumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");

            SqlConnection baglanti = new SqlConnection("Data Source=ORIGI\\SQLEXPRESS;Initial Catalog=EgitimKampiDp;Integrated Security=True");
            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * from TBL_Category",baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            baglanti.Close();


            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
              
            }






            Console.ReadKey();
        }
    }
}
