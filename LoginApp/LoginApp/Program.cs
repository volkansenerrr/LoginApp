using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi, girilenKullaniciAdi;
            int kullaniciSifre, girilenSifre, girisHakki;

            #region Kayıtlı Kullanıcı Bilgileri
            kullaniciAdi = "Volkan";
            kullaniciSifre = 2468;
            #endregion

            girisHakki = 3;

            while (true)
            {
                Console.Write("Kullanıcı adı : ");
                girilenKullaniciAdi = Console.ReadLine();

                Console.Write("Şifre : ");
                bool sifreGecerliMi = int.TryParse(Console.ReadLine(), out girilenSifre);

                Console.Clear();

                if (!sifreGecerliMi)
                {
                    Console.WriteLine("Şifre geçerli bir sayı olmalıdır. Lütfen tekrar deneyin.");
                    continue;
                }

                if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == kullaniciSifre)
                {
                    Console.WriteLine("Tebrikler, başarılı bir şekilde giriş yaptınız.");
                    break;
                }
                else
                {
                    if (girilenKullaniciAdi != kullaniciAdi && girilenSifre != kullaniciSifre)
                    {
                        Console.WriteLine("Kullanıcı adı ve şifreniz yanlış, lütfen tekrar deneyiniz.");
                    }
                    else if (girilenKullaniciAdi != kullaniciAdi)
                    {
                        Console.WriteLine("Kullanıcı adınızı yanlış girdiniz, lütfen tekrar deneyiniz.");
                    }
                    else if (girilenSifre != kullaniciSifre)
                    {
                        Console.WriteLine("Şifrenizi yanlış girdiniz, lütfen tekrar deneyiniz.");
                    }

                    girisHakki -= 1;
                    if (girisHakki > 0)
                    {
                        Console.WriteLine($"Kullanıcı adı veya şifrenizi yanlış girdiniz, lütfen tekrar deneyiniz. Kalan hakkınız: {girisHakki}");
                    }
                    else
                    {
                        Console.WriteLine("Giriş hakkınız dolmuştur, tekrar giriş yapamazsınız.");
                        Console.WriteLine("Konuyla ilgili müşteri hizmetlerimizle iletişime geçebilirsiniz.");
                        break;
                    }
                }
            }
        }
    }
}
