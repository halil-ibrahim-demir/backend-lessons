using System.Linq.Expressions;

// if-else yapısı

Console.WriteLine("Rol kodunuzu giriniz");
string? rolKodu = Console.ReadLine();
int rol = Convert.ToInt32(rolKodu);


Console.WriteLine("Şifrenizi giriniz");
string? sifre = Console.ReadLine();

if (rol == 1 && sifre == "Admin123")
{
    Console.WriteLine("Sistem yöneticisi girişi başarılı.");
}

else if (rol == 2 || rol == 3)
{
    Console.WriteLine("Standrat Kullanıcı Girişi Başarılı.");
}

else
{
    Console.WriteLine("Hatalı Giriş veya Yetkisiz Erişim.");
}


//switch-case yapısı

int secim = 2;
switch (secim)
{
    case 1:
        Console.WriteLine("Siparişler");
        break;
    case 2:
        Console.WriteLine("İadeler");
        break;
    case 3:
        Console.WriteLine("Kargo Durumu");
        break;
    default:
        Console.WriteLine("Hatalı Tuşlama");
        break;
}


// nested if-else yapısı
bool isUserLoggedIn = true;
int userAge = 24;
string? accountStatus = "Suspended";


if (isUserLoggedIn)
{
    if (accountStatus == "Suspended")
    {
        Console.WriteLine("Hesabınız askıya alınmıştır, işlem yapılamaz.");
    }
    else if (accountStatus == "Unverified")
    {
        Console.WriteLine("Lütfen önce mail adresinizi onaylayınız.");
    }
    else
    {
        if (userAge < 18)
        {
            Console.WriteLine("Yaş kısıtlaması: Bu ürünü satın alamazsınız.");
        }
        else
        {
            Console.WriteLine("Sipariş başarıyla oluşturuldu");
        }
    }
    
}

else
{
    Console.WriteLine("Lütfen önce giriş yapınız.");
}