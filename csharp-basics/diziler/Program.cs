//test - kolay

string[] envanter = new string[3];

envanter[0] = "Kılıç";
envanter[1] = "Kalkan";
envanter[2] = "İyileştirme İksiri";

Console.Write("Çantada hangi göze bakacaksın? ");
int ekipman = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Çantanı karıştırdın çıkan eşya {envanter[ekipman - 1]}");
Console.WriteLine($"Çantanın büyüklüğü: {envanter.Length}.");


//test - orta

string[] uyeler = {"Halil", "Aden", "Savaş", "Fatih", "Gözde"};
Console.Write("Aranacak üyeyi giriniz: ");
string? kontrol = Console.ReadLine();

bool bulunduMu = false;

for (int i = 0; i < uyeler.Length; i++)
{
    if (uyeler[i] == kontrol)
    {
        Console.WriteLine($"Kişi bulundu. İndeks numarası {i}");
        bulunduMu = true;
        break;
    }
}

if (bulunduMu == false)
{
    Console.WriteLine("Kişi bulunamadı");
}


//test - zor

int mutfak = 1;
int salon = 2;

int [,] arsa = new int[5, 5];
arsa [2, 3] = mutfak;
arsa [4, 1] = salon;

for (int i = 0; i < arsa.GetLength(0); i++)
{

    for (int j = 0; j < arsa.GetLength(1); j++)
    {
        Console.Write(arsa[i, j]);
    }

    Console.WriteLine();
}


// son aşama

int [,] arsalar = new int[5, 5];
int hedefX = 2;
int hedefY = 2;

if (hedefX - 1 >= 0)
{
    Console.WriteLine($"Yukarıda gidilecek yer var.\nÜst komşu koordinatı: {hedefX - 1}, {hedefY}");
}
else
{
    Console.WriteLine("Alan dışında kaldı");
}
if (hedefX + 1 <= arsalar.GetLength(0))
{
    Console.WriteLine($"Aşağıda gidilecek yer var.\nAlt komşu koordinatı: {hedefX + 1}, {hedefY}");
}
else
{
    Console.WriteLine("Alan dışında kaldı");
}
if (hedefY + 1 <= arsalar.GetLength(1))
{
    Console.WriteLine($"Sağda gidilecek yer var.\nSağ komşu koordinatı: {hedefX}, {hedefY + 1}");
}
else
{
    Console.WriteLine("Alan dışında kaldı");
}
if (hedefY - 1 >= 0)
{
    Console.WriteLine($"Solda gidilecek yer var.\nSol komşu koordinatı: {hedefX}, {hedefY - 1}");
}

else
{
    Console.WriteLine("Alan dışında kaldı");
}

//Final aşama sorusu

int[] sayilar = {4, 1, 9, -2, 7};

int enBuyuk = sayilar[0];
int enBuyukIndeks = 0;
for (int i = 0; i < sayilar.Length; i++)
{
    if (enBuyuk < sayilar[i])
    {
        enBuyuk = sayilar[i];
        enBuyukIndeks = i;
    }
}
    Console.WriteLine($"Listedeki en büyük sayı: {enBuyuk}. i değeri ise: {enBuyukIndeks} ");