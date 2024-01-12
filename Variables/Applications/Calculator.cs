using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Applications
{
    internal class Calculator
    {
        static void Start()
        {

        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void MultiplyApp()
        {
            // İki sayıyı kullanıcıdan alalım
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // Çarpma işlemi için fonksiyonları çağırıp sonuçları ekrana yazdıralım
            int sonuc1 = Multiply(sayi1, sayi2);
            Console.WriteLine($"Carpma Sonuc: {sonuc1}");

        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void SumApp()
        {
            // İki sayıyı kullanıcıdan alalım
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // Toplama işlemi için fonksiyonları çağırıp sonuçları ekrana yazdıralım
            int sonuc1 = Sum(sayi1, sayi2);
            Console.WriteLine($"Toplama Sonuc: {sonuc1}");

        }

        static int Divide(int x, int y)
        {
            return x / y;
        }

        static void DivideApp()
        {
            // İki sayıyı kullanıcıdan alalım
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // Çarpma işlemi için fonksiyonları çağırıp sonuçları ekrana yazdıralım
            int sonuc1 = Divide(sayi1, sayi2);
            Console.WriteLine($"Bolme Sonuc: {sonuc1}");

        }

        static int Extraction(int x, int y)
        {
            return x - y;
        }

        static void ExtractionApp()
        {
            // İki sayıyı kullanıcıdan alalım
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // Çarpma işlemi için fonksiyonları çağırıp sonuçları ekrana yazdıralım
            int sonuc1 = Extraction(sayi1, sayi2);
            Console.WriteLine($"Cikarma Sonuc: {sonuc1}");

        }

        static void CalculatorApp()
        {
            Console.WriteLine("Birinci sayiyi giriniz");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci sayiyi giriniz");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lutfen turunu sec");
            Console.WriteLine("Islem turleri: + , - , * , /");
            string? islemTuru = Console.ReadLine();

            Console.Write("Sonuc:");
            switch (islemTuru)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    break;

                default:
                    Console.WriteLine("Efendim dogru islemi secmeniz gerek");
                    break;
            }
        }
    }
}
