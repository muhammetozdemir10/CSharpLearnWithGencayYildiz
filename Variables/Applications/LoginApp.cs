using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Applications
{
    internal class LoginApp
    {
        static void Start()
        {
            Console.WriteLine("Kullanici adini giriniz");
            string? userName = Console.ReadLine();

            Console.WriteLine("Sifrenizi giriniz");
            string? userPassword = Console.ReadLine();
            if (userName == "Wizee" && userPassword == "123")
            {
                Console.WriteLine("Giris basarili");
            }
            else
            {
                Console.WriteLine("Girdiginiz kullani adi veya sifre yanlis ");
            }
        }
    }
}
