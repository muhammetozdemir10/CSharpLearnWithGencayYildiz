using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Applications
{
    internal class MiniApplications
    {
        public static void LastWord()
        {
            string text = "Merhaba ben Muhammet Bursada yasiyorum.";

            // Bir metinin en son kelimesini ekrana yazdiran program.

            string[] words = text.Split(' ');

            Console.WriteLine(words[0]);


        }

        public static void FirstAndLastCharacters()
        {
            // Bir metinin ilk harfini ve son harfini yazdiran program.

            string text = "Benim adim Muhammet";

            Console.WriteLine(text[0].ToString() + text[text.Length - 1].ToString());
        }

        public static void NumberCountToTen()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintPrimeNumbersBetweenTwoToHundred()
        {

            for (int i = 2; i <= 1000; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                    Console.WriteLine(i);
            }            
        }

        static bool IsPrimeNumber(int num)
        {            
            bool result = true;
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
