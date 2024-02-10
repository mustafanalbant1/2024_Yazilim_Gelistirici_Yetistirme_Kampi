using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.NotionalIdentity = 11111;
person1.FirstName = "Abdulkadir";
person1.LastName = "Motcu";
person1.DateOfBrithyear = 2001;



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



SelamVer("Kadir");
SelamVer();

int sonuc = Topla(3,5);

Console.WriteLine(sonuc);


//Diziler-Array

string ogrenci1 = "Kadir";
string ogrenci2 = "Damla";


string[] ogrenciler = new string[3];
ogrenciler[0] = "Kadir";
ogrenciler[1] = "Damla";
ogrenciler[2] = "Ümmühan";


//ogrenciler = new string[4];


for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] {"istanbul", "İzmir","Ankara"};
string[] sehirler2 = new[] { "Bursa", "Çorum", "Antalya" };

            //alians
foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}


List<string> yeniSehiler = new List<string> {"İstanbul 1", "Ankara 1","İzmir 1"};

yeniSehiler.Add("Antalya 1");

foreach (var sehir in yeniSehiler)
{
    Console.WriteLine(sehir);
}





static int Topla(int sayi1,int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}



static void SelamVer(string isim = "Kullanıcı")
{
    Console.WriteLine("Merhaba" + " " + isim);
}



//pascal casing 
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set;}
    public long TcNo { get; set; }

}



