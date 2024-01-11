using System;

namespace karakter_degistirme;

class Program
{
    static void Main(string[] args)
    {
        Baslangic:
        Console.Write("\n Bir değer giriniz! \n ------------------ \n");
        char[] chars = Console.ReadLine().ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine(chars);

        Secim:
        Console.Write("\n Yeni değer girmek ister misiniz? \n E: Evet \n H: Hayır \n");
        switch (Console.ReadLine().ToLower())
        {
            case "e":
                goto Baslangic;
            case "h":
                break;
            default:
                Console.WriteLine("Geçersiz seçim yaptınız, lütfen size sunulan seçeneklerin dışına çıkmayın!");
                goto Secim;
        }
    }
}
