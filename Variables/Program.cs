using System.Diagnostics;

namespace Variables
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // 268

            
            //
        }

        static void AsyncFunction()
        {
            var t = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Current index: {i}");
                    Thread.Sleep(1000);
                }
            });
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Aslan: {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Merhaba ben kodun son mesajiyim.");
        }

        static void SyncFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current index: {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Merhaba ben kodun son mesajiyim.");
        }


        static void DefineVariables()
        {

            string name = "Muhammmet";
            string surname = "Ozdemir";
            int age = 13;
            bool married = false;
            string[] favoriteGames;
            favoriteGames = new string[4];
            favoriteGames[0] = "Craftrise";
            favoriteGames[1] = "Minecraft";

            name = "Enes";
            float pi = 3.14f;
            decimal x = 4.72M;
            double y = 2.90;
        }

        static void TupleVariables()
        {
            (char a, bool b) myCabbar = ('a', true);
            (byte a, long b) myData = (255, 211111111111);

            myCabbar.b = false;
            myData.a = 5;

            Console.WriteLine(myCabbar.b);
        }

        static void ReadVariablesValues()
        {
            int a = 5;
            int b = 10;
            int c = 25;
            int d = 50;

            int x = a;
            int y = c;
            c = a;
            x = d;
            b = y;

            /*
             * a = 5
             * b = 25
             * c = 5
             * d = 50
             * x = 50
             * y = 25
             */
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static void ConstantVariables()
        {
            const int a = 10;
            Console.WriteLine(a);
        }

        static void OneLineVariablesDefining()
        {
            int a = 2, b = 3;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void UnboxingObjectType()
        {
            object age = 15;

            Console.WriteLine((string)age);
        }

        static void VarKeywordUsage()
        {
            string name = "Muhammet";
            var _name = "Muhammet";
        }

        static void ParseUsage()
        {
            string? input = "123";

            int x = int.Parse(input);
            Console.WriteLine(x);
        }

        static void ConvertUsage()
        {
            string? input = "3.14";

            double x = Convert.ToDouble(input);
            Console.WriteLine(x);
        }

        static void AritmaticOperetors()
        {

            Console.WriteLine(2 + 2);
            Console.WriteLine(34 - 13);
            Console.WriteLine(8 * 2);
            Console.WriteLine(32 / 2);
            Console.WriteLine(6 % 3);
        }

        static void CompareOperators()
        {
            // false
            Console.WriteLine(true && false);

            // false
            Console.WriteLine(false ^ false);

            // true
            Console.WriteLine((true || false) ^ (true && false));

            // false
            Console.WriteLine((true || true) && (true && false));

            // true
            Console.WriteLine((true ^ false) || (false && false));
        }

        static void IncrementAndDecrementOperators()
        {
            int x = 8;

            // 8
            Console.WriteLine(x++);

            // 10
            Console.WriteLine(++x);

            // 10
            Console.WriteLine(x--);

            // 
            Console.WriteLine(--x);
        }


        static void HeapOperators()
        {
            int z = 10;
            z += 2;

            // (+=) operatoru degiskenin olan digerin uzerine verilen degeri ekler.
            // (-=) operatoru degiskenin olan digerden eksitir.
            // (*=) operatoru degiskende olan degeri verilen degerle carpar.
            // (/=) operatoru degiskende olan degeri verilen degerle boler.
            // (%=) operatoru degiskende olan degeri verilen degerle mod alir.
            Console.WriteLine(z);
        }

        static void TernaryOperator()
        {
            bool evliMi = false;
            string message = (evliMi)
                ? "yeni evlilere muhtesem kampanya"
                : "gamerlere migrostan %20 indirimli kasa";



            Console.WriteLine(message);


            // -------------------------------

            bool ogrenciMi = true;
            string mesaj = (ogrenciMi)
                ? "ogrencilere A101 de okul esyalari %30 indirimli"
                : "Nike den yetiskinlere ozel ayakkkabi";
            Console.WriteLine();
        }

        static void MultiTernaryOperators()
        {
            int yas = 15;
            // Eger 16 yasinda ise motor ehliyeti alabilir, A
            // 18 yas altinda ise araba ehliyeti alamaz, B
            // 18 yas ve ustunde ise ehliyet alabilir. C
            char sonuc = (yas == 16) ? 'A' : (yas <= 18) ? 'B' : 'C';
        }

        static void TernaryHardExample()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            /*
             * Eger 1 ise A, 
             * 2 ise B, 
             * 3 ise C
             * Eger 10 ise D, 
             * 10 dan kucuk ise E,
             * eger 50 den kucuk ise F, 
             * 50 den buyuk ise G
             */

            char mesaj = (x == 1)
                ? 'A'
                : (x == 2) ? 'B' : (x == 3) ? 'C' : (x == 10) ? 'D' : (x < 10) ? 'E' : (x < 50) ? 'F' : 'G';
            Console.WriteLine(mesaj);
        }

        static void DefaultOperator()
        {
            // default
            Console.WriteLine(default(int));
        }

        static void IsOperator()
        {
            // is 
            object x = 12;
            Console.WriteLine(x is int);
        }

        static void IsNullOperator()
        {
            // is null
            object? z = 0;
            Console.WriteLine(z is null);
            Console.ReadKey();
        }

        static void IsNotNullOperator()
        {
            // is not null
            object? z = "";
            Console.WriteLine(z is null);
            Console.ReadKey();
        }

        static void AsOperator()
        {
            object x = "muhammet";
            string? z = x as string;
            Console.WriteLine(z);
        }

        static void NullableOperator()
        {
            /* 
             * Bir deger turlu degiskenin null deger alabilmesi icin(yani nullable olabilmesi icin)
             * ? operatoru kullanmasi gerekmektedir
            */
            int? x = 34;
            Console.WriteLine(x);
            x = null;
            Console.WriteLine(x);
        }

        static void NullCoalescingOperator()
        {
            /*
             * (??) Null Coalescing Operatörü
             * Elimizdeki degiskenin degerinin null olma durumuna istinaden farkli bir degeri
             * saglayan operatordur.
             */

            string? x = "hjughul";
            Console.WriteLine(x ?? "Deger yoktur");
        }

        static void NullCoalescingAssignmentOperator()
        {
            /*
             * (??=) Null Coalescing Assignment
             * Degiskenin degeri null ise verilen alternatif degeri ekrana yazar 
             * ve ilgili degiskene atama yapar.
             */

            string? x = null;
            Console.WriteLine(x ??= "Deger yoktur");
            Console.WriteLine(x);
        }

        static void SwitchCase()
        {
            /*
             * Switch case, kodun aksinda belirli bir sarta gore 
             * yonlendirme yapmamizi (farkli algoritma calistirmamizi/farkli 
             * operasyon gerceklestirmemizi/ tetiklememizi)
             * saglayan yapilanmadir.
             * 
             * Switch case yapilanmasi sadece bir degiskenin degerine sadece esitlik durumunu 
             * kontrol ederken kullanilabilir.
             * 
             * NOT: Sadece esitlik durumu check edilirse ozaman switch kullanilabilir.
             * 
             */

            string? z = Console.ReadLine();
            switch (z)
            {
                case "Abuzer":
                    Console.WriteLine("Abuzer yazdim");
                    break;

                case "Muhammet":
                    Console.WriteLine("Muhammet yazdim");
                    break;

                case "Abdulrahman":
                    Console.WriteLine("Abdulrahman yazdim");
                    break;

                default:
                    Console.WriteLine("Bilmiyorum ne yazdiniz?");
                    break;
            }
        }

        static void SwitchCaseWhen()
        {
            /*
             * Switch case de case deki olan degerin dogru olmasinin yani 
             * sira extra bir sart eklemek istiyorsak when keywordu kullanarak yanina parantez icinde
             * sartimizi yazarak sartimizin true degeri dondugunde olan case uyguluyacaktir.
             */

            string? x = Console.ReadLine();
            switch (x)
            {
                case "Muhammet":
                    Console.WriteLine("a");
                    break;

                case "Mustafa":
                    Console.WriteLine("b");
                    break;

                case "Musab" when (1 == 1.0):
                    Console.WriteLine("c");
                    break;

                default:
                    Console.WriteLine("Bos bir sey");
                    break;
            }
        }

        static void GotoKeyword()
        {
            /*
             * Switch casedeki olan caselerin iclerinde bulunan kodlar birebir ayni ise bir swtich de
             * ilgili kodlari yazip ayni kodlara sahip olan caselere "goto" ozelligi ile yazmis oldugunuz 
             * koda sahip olan caseyi ve degeri yanina yazarak kod akisini 
             * igili caseye yonlendire bilirsiniz.
             * 
             * (goto)
             * Programın belirli bir etiket veya etiketin yanına atlamasına olanak tanır.
             */

            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine(2 * 1);
                    break;

                case 2:
                    Console.WriteLine(2 * 2);
                    Console.WriteLine("Cikolatali sogan");
                    break;

                case 3:
                    Console.WriteLine(2 * 3);
                    break;

                case 4:
                    goto case 2;

                default:
                    Console.WriteLine("Durum tanimli degil!");
                    break;
            }
        }

        static void SwitchExpression()
        {
            /*
             * Switch ifadesi ile  tek satrilik switch yapmamizi saglar.
             */
            string mesaj = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Sunday => "Bu gun pazar",
                DayOfWeek.Monday => "Bu gun pazartesi",
                DayOfWeek.Tuesday => "Bu gun sali",
                DayOfWeek.Wednesday => "Bu gun carsamba",
                DayOfWeek.Thursday => "Bu gun persembe",
                DayOfWeek.Friday => "Bu gun cuma",
                DayOfWeek.Saturday => "Bu gun cumartesi",
                _ => throw new NotImplementedException()
            };
            Console.WriteLine(mesaj);
        }

        static void TuplePatterns()
        {
            /*
             * Tuple Patterns teknigini kullanarak switch expression ile 
             * birden fazla degiskeni ayni anda kontrol etmemizi saglar.
             * 
             * NOT: Casedeki girilen degerlerin verilen degiskenlerin degerleri ile hepsi esit olmali.
             * Aksi taktirle case calimicaktir.
             * 
             */

            int z = Convert.ToInt32(Console.ReadLine());
            string? _name = Console.ReadLine();
            string? surname = Console.ReadLine();
            switch (z, _name, surname)
            {
                case (16, "EkinNaz", "Dus"):

                    Console.WriteLine("Hos geldiniz EkinNaz hanim");
                    break;
                case (16, "Ekin", "Naz"):
                    Console.WriteLine("Hos geldiniz Ekin hanim");
                    break;

                default:
                    Console.WriteLine("Ilgili kisi bulunamadi");
                    break;
            }
        }

        static void PositionalPatterns()
        {
            // Switch Expressions - Positional Patterns
        }

        static void PropertyPatterns()
        {
            // Switch Expressions - Positional Patterns
        }

        static void IfElseStatement()
        {
            string x = "Alil";

            if (x == "Ali")
            {
                Console.WriteLine("Dogru mesaj");
            }
            else
            {
                Console.WriteLine("yanlis mesaj");
            }

            Console.WriteLine("end.");
        }

        static void ElseIf()
        {
            /*
             * If yapisinda bir sart gerceklestiginde deger bagli olan sartlar gerceklesmez.
             */

            int ogrenciNo = 620;
            if (ogrenciNo >= 620)
            {
                Console.WriteLine("Muhammet");
            }
            else if (ogrenciNo < 700)
            {
                Console.WriteLine("Enes");
            }
            else
            {
                Console.WriteLine("Ogrenci bulunmadi");
            }


        }

        static void ElseIfYapisi()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Girilen sayı pozitif.");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Girilen sayı negatif.");
            }
            else
            {
                Console.WriteLine("Girilen sayı sıfır.");
            }
        }

        static void ScopesuzIf()
        {
            /*
             * If yapilanmasi tek bir satirlik islem gerceklestriyorsa
             * bunu scope icine almak zorunda degilsin.
             */

            string x = "Muhammet";
            if (x == "Muhammet")
                Console.WriteLine("Evet");
        }

        static void IfExample1()
        {
            // 2.i urunuz fiyatindan yuzde 25 indirim yapan uygulama

            Console.WriteLine("Birinci urunun fiyatini giriniz:");
            int urun1Fiyati = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci urunun fiyatini giriniz:");
            int urun2Fiyati = Convert.ToInt32(Console.ReadLine());

            if ((urun1Fiyati + urun2Fiyati) > 200)
            {
                Console.WriteLine(urun1Fiyati + (urun2Fiyati * 0.75));
            }
        }

        static void LoginSystem()
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

        static void Calculator()
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

        static void IfElse()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 10)
            {
                Console.WriteLine("Evet");
            }
            else
            {
                Console.WriteLine("Hayir");
            }
        }

        static void PatternMatching()
        {
            /*
             * Type Pattern
             * TODO: 158 - 172 Izlenecek
             */

            object x = "Mami";
            if (x is string z)
            {

                Console.WriteLine("Evet string");

            }
            else
            {
                Console.WriteLine("Hayir baska bir tip");
            }
        }

        static void TryCatch()
        {
            try
            {
                Console.Write("Bir sayı girin: ");
                int sayi = int.Parse(Console.ReadLine());

                int kare = sayi * sayi;
                Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen bir sayı girin.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }

            Console.WriteLine("Program sonlandı.");
        }

        static void TryCatchFinally()
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            }
            catch (FormatException)
            {
                Console.WriteLine("Yanlis deger girdiniz lutfen sayi giriniz");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Girdiginiz sayi sinir otesinde");
            }
            finally
            {
                Console.WriteLine("Son");
            }
        }

        static void TryCatchWhen()
        {
            string name = "Ayse";
            string gender = "female";

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception) when (gender == "male")
            {
                Console.WriteLine("Yanlis islem yaptiniz bey efendi");
            }
            catch (Exception) when (gender == "female")
            {
                Console.WriteLine("Yanlis islem yaptiniz hanim efendi");
            }
        }

        static void ForLoopFactorialExample()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            int result = 1;
            for (int i = input; i > 0; i--)
            {
                // result = result * i;
                result *= i;
            }

            Console.WriteLine($"Sonuc: {result}");
        }

        static void WhileLoop()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 10)
            {
                Console.WriteLine("Merhaba");

            }
        }

        static void PrintMessage10TimesWithWhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Naber");
                i++;
            }
        }

        static void WhileLoopExample3()
        {
            int i = 0;
            int result = 0;

            while (i <= 100)
            {
                if (i % 2 != 0)
                {
                    result += i;
                }
                i++;
            }

            Console.WriteLine(result);
        }

        static void DOWhileVsWhile()
        {
            bool run = false;

            do
            {
                Console.WriteLine("kirmizi");
            } while (run);

            while (run)
            {
                Console.WriteLine("Mavi");
            }
        }

        static void InterTwinedForLoop()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("*");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("++");
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("---");
                    }
                }
            }
        }

        static void InterTwinedForLoopExample()
        {
            string name = "Muhammet";
            for (int i = 1; i < 9; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(name[j]);
                }

                Console.WriteLine("");
            }
        }

        static void ForEach()
        {
            string[] brands = { "Gucci", "Zara", "Prada", "Ekler" };

            foreach (string brand in brands)
            {
                Console.WriteLine(brand);
            }
        }

        static void BreakKeyword()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);

            }
        }

        static void ContinueKeyword()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }

        static void ReturnKeyword()
        {
            Console.WriteLine("Muhammet");
            return;
            Console.WriteLine("Ozdemir");
        }

        static int ReturnKeywordSample2()
        {
            int x = 5, z = 4;
            return x + z;
        }

        static void ArrayWithForEach()
        {
            /*
             * Buraya 3 tane array tanimla icersinde her biri icin 5 eleman olacak.
             * Tanimladigin arraylerdeki elemanlari ekrana yazdir (donguler kullanarak).
             */


            //Tanimlar buraya
            string[] names = { "Eda", "Poyraz", "Deniz", "Oktay", "Huseyin" };
            string[] surnames = { "koru", "gulec", "obi", "ozcivelek", "Uyu" };
            int[] numbers = { 12, 13, 14, 15, 16 };


            // Donguler buraya
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            foreach (string surname in surnames)
            {
                Console.WriteLine(surname);
            }
            Console.WriteLine();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void DefineArray()
        {
            // eski usul
            // Array eski yontemiyle tanimlarken yeni array nesnesi ve eleman sayisi belirlenmesi zorunludur
            string[] names = new string[6] { "ahmet", "Mehmet", "ali", "Veysel", "murat", "yusuf" };

            // yeni yontem
            string[] surnames = { "gulec", "taskiran", "saritas", "dus", "yilmaz" };
        }

        static void ArrayLengthProperty()
        {
            string[] names = new string[3];
            names[0] = "Muhammet";
            names[1] = "Melek";
            names[2] = "Murat";



            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        static void ArrayConstraints()
        {
            /*
             *                      ARRAY SINIRLILIKLARI
             * 1 = Dizilerde tanimlama yaparken eleman sayisi belirlemek zorunludur.
             * 
             * 2 = Dizinin eleman sayisi belirlendiginde kulanilsada kullanilmasada
             * bellekte alan tahsisinde bulunur.
             * 
             * 3 = Dizilerde eleman sayisi tanimlandikdan sonra dizi uzerine 
             * yeni bir eleman alani tanimlanamaz silinmez.
             * 
             * 4 = Dizilerde elemanlara deger atarken indexer operatoruyle atamak zorunludur.
             */
        }

        static void ArrayVariants()
        {
            // Variant 1 The base 
            int[] ages = new int[3];
            ages[0] = 12;
            ages[1] = 13;
            ages[2] = 14;

            // Variant 2 
            string[] names = { "Muhammet", "Ahmet", "Emir", "Seda", "Mehmet" };

            // Variant 3
            string[] items = new string[] { "Masa", "Sandalye", "Dolap", "Canta", "Kapi" };

            // Variant 4
            char[] characters = new char[3] { 'M', 'N', 'E' };

            // Variant 5 
            var heroes = new[] { "Spiderman", "Batman", "Deathpool", "Dexter" };
            string[] brands = new[] { "Microsoft", "Gucci", "Nike", "Puma" };
        }

        static void DefineArrayWithArrayClass()
        {
            // x[] == Array

            /*
             * Dizi olarak tanimlanan degiskenler otomatik Array sinifindan turetilmektedir.
             */
            Array names = new string[5];
            names.SetValue("Muhammet", 0);
            names.SetValue("Eda", 1);
            names.SetValue("Osman", 2);
            names.SetValue("Melek", 3);
            names.SetValue("Nimet", 4);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names.GetValue(i));
            }
        }

        static void ArrayClearMethod()
        {
            Array names = new string[5];
            names.SetValue("Muhammet", 0);
            names.SetValue("Poyraz", 1);
            names.SetValue("Oktay", 2);
            names.SetValue("Ege", 3);
            names.SetValue("Ogus", 4);

            Array.Clear(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names.GetValue(i));
            }
        }

        static void ArrayIndexOfMethod()
        {
            /*
             * Array classinda bulunan IndexOf metodu sayedinde herhangi bir array icinde 
             * olan bir degerin indexsini bulur ve bize doner.
             */
            Array numbers = new int[5] { 12, 13, 14, 15, 16 };
            int index = Array.IndexOf(numbers, 15);
            Console.WriteLine(index);
        }

        static void ArrayReverseMethod()
        {
            /*
             * Array Reverse fonksiyonu yazilna dizilerin icindeki degerlerin ters cevirir.
             */
            Array numbers = new int[5] { 15, 13, 14, 11, 2 };
            Array.Reverse(numbers);
            Console.WriteLine(numbers.GetValue(0));
        }
    }
}