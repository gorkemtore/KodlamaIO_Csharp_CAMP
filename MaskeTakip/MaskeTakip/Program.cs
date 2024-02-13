using MaskeTakip.Business.Concrete;
using MaskeTakip.Entities.Concrete;
using System;

class Program
{
    static void Main(string[] args)
    {

        SelamVer(isim:"Engin");
        SelamVer(isim:"Ahmet");
        SelamVer();
        int sonuc = Topla(5,3);

        string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };


        Person person1 = new Person();
        person1.FirstName = "Görkem";
        person1.LastName = "TÖRE";
        person1.NationalIdentity = 123;
        person1.DateOfBirthYear = 2002;

        Person person2 = new Person();
        person2.FirstName = "Murat";

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string> {"Ankara 1", "İstanbul 1","İzmir 1" };
        yeniSehirler1.Add("İzmir");

        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();

    }

    static void SelamVer(string isim="noname")
    {
        Console.WriteLine("Merhaba");
    }

    static int Topla(int sayi1, int sayi2)
    {
        Console.WriteLine("Toplam : " + (sayi1 + sayi2).ToString());
        return sayi1 + sayi2;
    }


}


