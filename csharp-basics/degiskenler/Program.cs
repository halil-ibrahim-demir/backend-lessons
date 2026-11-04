Console.Write("İsminizi Giriniz: ");
string? isim = Console.ReadLine();

Console.Write("Karakterinizin seviyesini giriniz: ");
int seviye = Convert.ToInt32(Console.ReadLine());

Console.Write("Altın seviyenizi belirtiniz: ");
double bakiye = Convert.ToDouble(Console.ReadLine());

Console.Write("Premium oyuncu musunuz(True, False): ");
string? ispremium = Console.ReadLine();
bool premium = bool.Parse(ispremium);

int yeniSeviye;

if (premium == true)
{    
    yeniSeviye = seviye + 5;
}
else
{
    yeniSeviye = seviye;
}


Console.WriteLine($"İsim: {isim} \nSeviye: {yeniSeviye}. Premium bonusu sayesinde seviyeniz arttırılmıştır.\nBakiye: {bakiye}\nPremium Durumu: {ispremium}");
