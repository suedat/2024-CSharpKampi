using System;
using Business.Concreate;
using Entities.Concreate;


namespace Workaround;
class Program
{
    static void Main(string[] args)
    {
        NewMethod();

        SelamVer("Engin");
        SelamVer("Ahmet");
        SelamVer("Ayşe");
        SelamVer();

        int sonuc = Topla(3, 5);

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";
        //sadece İlkeri çıktı olarak verir (new) bunun nedeni stack ve heapteki hafıza yönetimindendir. Önceki öğrenciler Garbage Collector ile silinir.
        ogrenciler = new string[4];
        ogrenciler[3] = "Ilker";

        //int,double,bool'de olay değer seviyesinde olur. değer ve referans tipleri farklıdır. bunlarda olay hep stackte döner.
        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        //sayi2 = ?; 10 olur

        for (int i = 0; i < ogrenciler.Length; i++) // i++ = i=i+1
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);
             //her bir elemanı gezerken verdiğimiz takma isim
        foreach (var sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
        yeniSehirler1.Add("Adana 1");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }


        PttManager pttManager = new PttManager(new ForeignManager());
        PttManager.GiveMask(person1);

        Console.ReadLine();
    }

    static void SelamVer(string isim="isimsiz") //default parametre
    {
        Console.WriteLine("Merhaba" + isim);
    }

    static int Topla(int sayi1 = 5,int sayi2 = 10) //default parametre en sona yazılır
    {
        int sonuc = sayi1 + sayi2; //breakpoint ekleyince kod bu kısma gelince durdu f5 ile devam etip bu satırın çıktısını da verdi
        Console.WriteLine("Toplam : "+ sonuc);
        return sonuc;
    }
    private static void NewMethod()
    {
        string x = "deneme";
    }


    //pascalcasing -> Classlar, methodlar, propertiler PascalCasede ile yazılır
    public class Vatandad
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

}

