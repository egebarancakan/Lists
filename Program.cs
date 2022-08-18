internal class Program
{
    private static void Main(string[] args)
    {
        List<int> sayiListesi=new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi=new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);
        
        foreach(var item in sayiListesi)
        {
            Console.WriteLine(item);
        }
        foreach (var items in renkListesi)
        {
            Console.WriteLine(items);
        }
        sayiListesi.ForEach(item=>Console.WriteLine(item));
        renkListesi.ForEach(items=>Console.WriteLine(items));

        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");
        Console.WriteLine(sayiListesi);
        Console.WriteLine(renkListesi);
        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);
        Console.WriteLine(sayiListesi);
        Console.WriteLine(renkListesi);

        //Liste içerisinde arama
        if(sayiListesi.Contains(10))
        {
            Console.WriteLine("Liste içerisinde bulundu");
        }

        //Eleman ile indexe erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        //Diziyi listeye çevirme
        string[] Hayvanlar={"kedi","köpek","kuş"};
        List<string> hayvanListesi=new List<string>(Hayvanlar);

        //Listeyi nasıl temizleriz
        hayvanListesi.Clear();

        //Liste içerisinde nrsne tutmak
        List<Kullanıcılar> kullanıcıListesi=new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1=new Kullanıcılar();
        Kullanıcılar kullanıcı2=new Kullanıcılar();
        kullanıcı1.Isim="Ege Baran";
        kullanıcı1.SoyIsim="Çakan";
        kullanıcı1.Yas=22;
        kullanıcıListesi.Add(kullanıcı1);
        kullanıcı2.Isim="Beyza";
        kullanıcı2.SoyIsim="Çağ";
        kullanıcı2.Yas=22;
        kullanıcıListesi.Add(kullanıcı2);
        
    }
}

public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;
    public string Isim{get=>isim; set=>isim=value;}
    public string SoyIsim{get=>soyisim; set=>soyisim=value;}
    public int Yas{get=>yas; set=>yas=value;}
}