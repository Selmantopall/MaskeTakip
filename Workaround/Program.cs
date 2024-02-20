using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    internal class Program
   {
        static void Main(string[] args)
        {

            SelamVer(isim: "Engin ");
            SelamVer(isim: "Ahmet ");
            SelamVer(isim: "Ayşe ");
            SelamVer();

            int sonuc = Topla(3, 5);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++) 
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            
            Person person1 = new Person();
            person1.FirstName = "Selman";
            person1.LastName = "TOPAL";
            person1.NationalIdentity = 123123;
            person1.DateOfBirthYear = 1999;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1 );





            Console.ReadLine();

        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc.ToString());
            return sonuc ;
        }
    } 
}