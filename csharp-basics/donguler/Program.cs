//test seviye - 1

using System.Formats.Asn1;

string gizliSifre = "Archify2026";
int hak = 3;

while (hak > 0)
{
    Console.Write("Şifreyi giriniz: ");
    string? deneme = Console.ReadLine();

    if (deneme == "")
    {
        Console.WriteLine("Boş şifre girilemez");
        continue;
    }
    else if (deneme == gizliSifre)
    {
        Console.WriteLine("Sisteme girildi");
        break;
    }
    else
    {
        Console.WriteLine("Hatalı şifre!");
        hak--;
    }
}

if (hak == 0)
{
    Console.WriteLine("Hesabınız kilitlendi!");
}


//test seviye - 2

int islemSirasi = 1;

while (islemSirasi <= 5)
{
    if (islemSirasi == 3)
    {
        Console.WriteLine("3 numaralı işlem hatalı, atlanıyor");
        islemSirasi++;
        continue;
    }

    Console.WriteLine($"İşlem tamamlandı");
    islemSirasi++;

}


//test seviye - 3

int toplam = 0;
for (int i = 0; i <= 5; i++)
{
    toplam = toplam + i;
}
Console.WriteLine(toplam);


//test seviye - 4

for (int i = 10; i >= 1; i--)
{
    if (i == 5)
    {
        Console.WriteLine("Yarıya gelindi");
    }
    else if (i == 2)
    {
        Console.WriteLine("Tehlike! Sistem durduruldu.");
        break;
    }
    else
    {
        Console.WriteLine(i);
    }
}