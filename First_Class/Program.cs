using System;

namespace First_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ogrenci1 = new Person();

            ogrenci1.Ad = "Sibel";
            ogrenci1.Soyad = "Doğru";
            ogrenci1.DogumGunu = new DateTime(1987, 08, 18);


            Person ogrenci2 = new Person();

            ogrenci2.Ad = "Ali";
            ogrenci2.Soyad = "Yılmaz";
            ogrenci2.DogumGunu = new DateTime(1991, 03, 12);


            Person ogretmen = new Person();
            ogretmen.Ad = "Mehmet";
            ogretmen.Soyad = "Soytürk";
            ogretmen.DogumGunu = new DateTime(1973, 01, 15);

            Console.WriteLine("ÖĞRENCİ BİLGİLERİ");
            Console.WriteLine("Öğrencinin Adı: " + ogrenci1.Ad);
            Console.WriteLine("Öğrencinin Soyadı: " + ogrenci1.Soyad);
            Console.WriteLine("Öğrencinin Doğum Tarihi: " + ogrenci1.DogumGunu.ToShortDateString());
            Console.WriteLine();


            Console.WriteLine("ÖĞRENCİ BİLGİLERİ");
            Console.WriteLine("Öğrencinin Adı: " + ogrenci2.Ad);
            Console.WriteLine("Öğrencinin Soyadı: " + ogrenci2.Soyad);
            Console.WriteLine("Öğrencinin Doğum Tarihi: " + ogrenci2.DogumGunu.ToShortDateString());
            Console.WriteLine();

            Console.WriteLine("ÖĞRETMEN BİLGİLERİ");
            Console.WriteLine("Öğretmenin Adı: " + ogretmen.Ad);
            Console.WriteLine("Öğrencinin Soyadı: " + ogretmen.Soyad);
            Console.WriteLine("Öğrencinin Doğum Tarihi: " + ogretmen.DogumGunu.ToShortDateString());


        }
    }
}