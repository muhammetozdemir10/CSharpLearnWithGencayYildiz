using Microsoft.Extensions.Primitives;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using Topics.Applications;

namespace Variables
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // MiniApplications.PrintPrimeNumbersBetweenTwoToHundred();
            RecursiveMethod();
        }

        static void RecursiveMethod()
        {
            /*
             * Recursive Method (Tekrarli metot) 
             * Bir metotun icerisinde metotu cagirabilir.
             */

            Console.WriteLine("ad");
            RecursiveMethod();
        }


        #region TEST 1

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
            byte f = 255;

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
            /*
             * Sabit degiskenler tanimladigimiz degiskenin degerini degsimesini engellemek icin const operatoru 
             * degiskenin basina ekleyerek sabit degisken tanimlamamizi olanak tanir 
             */
            const int a = 10;
            Console.WriteLine(a);
        }

        static void OneLineVariablesDefining()
        {
            /*
             * Tek satirda ayni veri tipine sahip degiskenleri tanimlama yontemi.
             * Aralarina virgul ekleyerek tanimlanir. 
             */
            int a = 2, b = 3;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void BoxingAndUnBoxingObjectType()
        {
            /*
             * Boxing herhangi bir degerin object tipli bir degiskene 
             * atamasiyla beraber oz veri tipinin ozellikleri kaybolur
             * 
             * UnBoxing boxing edilmis herhangi bir degerin oz veri tipini uygun sekilde donusumunu saglar.
             */

            // Boxing the value in object
            object age = 15;
            string name = "Muhammet";
            string surname = "Ozdemir";


            // Unboxing
            Console.WriteLine((int)age + 10);
        }

        static void VarKeywordUsage()
        {
            /*
             * Deger turune gore kendini uygu  deger turune gore adapte eden bir veri tipidir.
             */

            var name = "Muhammet";
            var _name = true;
        }

        static void ParseUsage()
        {
            /*
             * Parse fonksiyonu ile bir string degerin integer degerine cevirir.
             */

            string? input = "123";

            int x = int.Parse(input);
            Console.WriteLine(x + 5);
        }

        static void ConvertUsage()
        {
            /*
             * Convert sinifi belirli bir deger tipten baska bir 
             * veri tipini icindeki tasidigi fonksiyonlar sayesinde donusturmemize olanak saglar.
             */

            string? input = "3.14";

            double x = Convert.ToDouble(input);
            Console.WriteLine(x + 0.01);
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
            // Logical negation operator !
            bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False

            // Conditional logical AND operator &&
            Console.WriteLine(true && true);    // output: True
            Console.WriteLine(true && false);   // output: False
            Console.WriteLine(false && true);   // output: False
            Console.WriteLine(false && false);  // output: False

            // Conditional logical OR operator ||
            Console.WriteLine(true || true);    // output: True
            Console.WriteLine(true || false);   // output: True
            Console.WriteLine(false || true);   // output: True
            Console.WriteLine(false || false);  // output: False

            // Logical exclusive OR (XOR) operator ^
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
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
        #endregion

        #region TEST 2

        static void AssignmentOperators()
        {
            int z = 10;
            z *= 2;
            // z = z + 2;

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


            // <> Bu isaretler ve arasindaki temsilidir. Kod degildir.
            // (<sart>) ? <Dogru oldugunda donecek deger> : <Yanlis oldugunda donecek deger>;

            // semicolon ;

            Console.WriteLine(message);

            // -------------------------------

            bool ogrenciMi = true;
            string mesaj = (ogrenciMi)
                ? "ogrencilere A101 de okul esyalari %30 indirimli"
                : "Nike den yetiskinlere ozel ayakkkabi";
            Console.WriteLine(mesaj);
        }

        static void MultiTernaryOperators()
        {
            int yas = 15;
            // Eger 16 yasinda ise motor ehliyeti alabilir, A
            // 18 yas altinda ise araba ehliyeti alamaz, B
            // 18 yas ve ustunde ise ehliyet alabilir. C
            char sonuc = (yas == 16) ? 'A' : ((yas <= 18) ? 'B' : 'C');
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
            /*
             *  Default operatoru bir veri tipinin varsayilan degerine verir.
             */

            // default
            Console.WriteLine(default(int));
        }

        static void IsOperator()
        {
            /*
             * Is operatoru boxing edilmis bir degerin veri tipinin 
             * ne oldugunu ogerene bilmek icin kullanilir.
             */

            // is 
            object x = 12;
            Console.WriteLine(x is int);
        }

        static void IsNullOperator()
        {
            /*
             * Is Null operatoru ilgili degiskenin degeri null olup olmadigini kontrol eder.
             */

            // is null
            object? z = 0;
            Console.WriteLine(z is null);
            Console.ReadKey();
        }

        static void IsNotNullOperator()
        {
            /*
             * Is Not Null operatoru ilgili degiskenin degeri null olmadigini kontrol eder.
             */

            // is not null
            object? z = "";
            Console.WriteLine(z is not null);
            Console.ReadKey();
        }

        static void AsOperator()
        {
            /*
             * As operatoru boxing edilmis bir degerin X veri tipine olarak donusturur.
             */

            object x = "muhammet";
            string? z = x as string;
            Console.WriteLine(z);
        }

        static void NullableOperator()
        {
            /* 
             * Bir deger turlu degiskenin null deger alabilmesi icin(yani nullable olabilmesi icin)
             * ? operatoru kullanmasi gerekmektedir
             * 
             * null degersizdir.
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

        /// <summary>
        /// Buna calisma !!
        /// </summary>
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

        /// <summary>
        /// Sinavda gelmeyecek !!
        /// </summary>
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
             * Else If if ve else arasina alternatif sorgu eklememize olanak tanir.
             * 
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
        #endregion

        #region TEST 3

        /// <summary>
        /// Buna calisma !!
        /// </summary>
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

        static void ForLoopUsage()
        {
            /*
             * For loop belirli bir kod veya algoritma bir sarta bagli olarak 
             * veya bagimsiz olarak tekrarli bir sekilde calistirmayi olanak tanir.ww
             */

            for (int i = 0; i < 10; i++)
            {
                // result = result * i;
                Console.WriteLine(i);
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
             * Array Reverse fonksiyonu yazilan dizilerin icindeki degerlerin ters cevirir.
             */
            Array numbers = new int[5] { 15, 13, 14, 11, 2 };
            Array.Reverse(numbers);
            Console.WriteLine(numbers.GetValue(0));
        }

        static void ArraySortMethod()
        {
            /*
             * Array sort fonksiyonu ile dizide bulunan elemanlari kucukten 
             * buyuge siralar yada alfabetik sirlamasi yapar.
             */
            Array numbers = new int[6] { 2, 99, 8, 69, 22, 44 };
            Array names = new string[6] { "Muhammet", "Abdulrahman", "Poyraz", "Eren", "Oktay", "Deniz" };
            Array.Sort(names);
            foreach (var x in names)
            {
                Console.WriteLine(x);
            }
        }

        static void ArrayIsReadOnlyProperty()
        {
            /*
             * Array IsReadOnly ozelligi dizinin sadece okunabilirligini durumu bildirir.
             */
            Array names = new string[3] { "Muhammet", "Yusuf", "Emre" };
            Console.WriteLine(names.IsReadOnly);
        }

        static void ArrayLengthProperty()
        {
            /*
             * Array Length ozelligi bize dizi'nin icindeki eleman sayisini ekrana verir.
             */
            Array numbers = new int[3] { 12, 13, 14 };
            Console.WriteLine(numbers.Length);
        }

        static void ArrayRankProperty()
        {
            /*
             * Array Rank ozelligi dizinin boyutunu verir.
             */
            Array numbers = new int[3] { 2, 5, 10 };
            Console.WriteLine(numbers.Rank);
        }

        static void ArrayCreateInstanceMethod()
        {
            /*
             * Array CreateInstance fonksiyonu ile 
             * yeni bir Array nesnesi tanimlamamizi saglar.
             */
            int[] numbers = new int[3];
            Array numbers2 = Array.CreateInstance(typeof(int), 3);
        }

        static void ArrayReverseIndexOperator()
        {
            /*
             * ^ operatoru indexsi tersinden baslatir ve programatik olarak 1 sayisindan baslar.
             */
            int[] numbers = new int[] { 12, 35, 85, 25, 1, 78, 86, 37, 76, 34, 82, 654, 987, 582 };
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[^10]);
        }

        static void RangeOperator()
        {
            /*
             * ".." Iki nokta operatoru ile aralik belirleyip ilgili dizinin icinde bulunan elemanlari dondurur.
             */
            int[] numbers = new int[] { 2, 3, 75, 354, 13, 65, 26 };
            int[] newNumbers = numbers[1..];
            foreach (var number in newNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void InnerArrays()
        {
            /*
             * Ic ice diziler bir dizinin icinde elemanlar olarak baska diziler tasiyabilir.
             */
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 12, 13, 14 };
            numbers[1] = new int[] { 15, 16, 17 };
            numbers[2] = new int[] { 18, 19, 20 };
            Console.WriteLine(numbers[1][2]);
        }

        static void DimensionalArray()
        {
            /*
             * Cok boyutlu oyun programlamada ve yuksek istatistiksel calismalarda kullanilir.
             */

            int[,] numbers = new int[3, 3];
            numbers[0, 0] = 5;
            numbers[0, 1] = 50;
            numbers[1, 1] = 100;
            numbers[2, 1] = 150;
            numbers[2, 2] = 200;
            Console.WriteLine(numbers[2, 1]);
        }

        static void DimensionalArrayVariant1()
        {
            // Cok boyutlu array farkli tanimlama varyasyonu.
            int[,] numbers = {
                {4, 6, 8 },
                {78, 57, 23 },
                {12, 36, 93 },
            };
        }

        static void DimensionalArrayLength()
        {
            /*
             * Cok boyutlu arraylarda Length ozelligi boyutlarin eleman sayisi bir birileriyle carparak
             * uzunlugu elde edilir.
             */

            int[,] numbers = new int[3, 3];
            numbers[0, 0] = 5;
            numbers[0, 1] = 50;
            numbers[1, 1] = 100;
            numbers[2, 1] = 150;
            numbers[2, 2] = 200;
            Console.WriteLine(numbers.Length);
        }

        static void DimensionalArrayWithForLoop()
        {
            /*
            * Cok boyutlu diziler elemanlari ekrana yazdirilacagi zaman ic ice donguler kullanilir.
            */
            int[,] numbers = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }

            }
        }

        static void StringEmptyVSNull()
        {
            /*
             * NULL:
             * > Null alabilen degiskenler RAM'de alan tahsisinde bulunmaz.
             * > Null alabilen turler sadece referansli turlerdir.
             * 
             * EMPTY:
             * > Empty olan degiskenler RAM'de alan tahsisinde bulunur ama deger tasimaz yani bostur.
             */
            string name = "";
            string _name = null;
        }

        static void StringIsNullOrEmptyMethod()
        {
            /*
             * IsNullOrEmpty fonksiyonu ile degiskenin Null veya Empty ise bize true degerini dondurecektir.
             */
            string name = "";
            Console.WriteLine(string.IsNullOrEmpty(name));
        }

        static void StringIsNullOrWhiteSpaceMethod()
        {
            /*
             * IsNullOrWhiteSpace fonksiyonu degiskenin degeri 
             * Null veya Empty veya WhiteSpace(bosluk karakteri) ise True degeri verecektir.
             */
            string name = " ";
            Console.WriteLine(string.IsNullOrWhiteSpace(name));
        }

        static void ConcatenateStringOperator()
        {
            /*
             * Arti operatoru "+" stringlerle kullanildiginda metinsel ifadeleri birlestirir.
             */
            string name = "Muhammet";
            string surname = "Ozdemir";
            Console.WriteLine(name + " " + surname);
        }

        static void StringInterPolationOperator()
        {
            /*
             * String Interpolation operatoru ile degiskenleri string dergerlerin icine gomebilmemizi saglar.
             */

            string name = "Muhammet";
            string surname = "Ozdemir";
            string tcNo = "1809069478";
            int age = 13;
            string gender = "Male";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"TC No: {tcNo}");
        }

        static void SpecialCharacters()
        {
            /*
             * kacis karakterleri metinsel ifadelerde kod ifadelerinin yazmamizi saglar.
             * Cift tirnak icin \"
             * Tek tirnak icin \'
             * Yeni satira gecmek icin \n
             * Ters slash icin \\
             */

            string name = "Muhammet";
            Console.WriteLine($"Hello, \"{name}\"");
            Console.WriteLine($"Symbols = ");
        }

        static void VerbatimOperator()
        {
            /*
             * @ Verbatim operatoru ile metinsel ifadeyi birden fazla satirda yazmamizi saglar.
             */
            string paragraph = @"
Merhaba, ben muhammet 13 yasindayim 
7. sinifa gidiyorum. 
Yazilim gelistiricisiyim. boyum 1.47
                ";
            Console.WriteLine(paragraph);
        }

        static void StringContainsMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Contains fonksiyonu ile string degiskenin degerinde 
             * verilecek deger icinde olup olmadigini kontrol eder.
             */

            Console.WriteLine(text.Contains("13"));
        }

        static void StringStartsWithMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * StartsWith fonksiyonu ile string degiskenin degeri
             * belirledigimiz deger ile baslayip baslayamadigini bize True veya False olarak bildirir.
             */

            Console.WriteLine(text.StartsWith("Me"));
        }

        static void StringEndsWithMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * EndsWith fonksiyonu ile string degiskenin degeri
             * belirledigimiz deger ile bitip bitmedigini bize True veya False olarak bildirir.
             */

            Console.WriteLine(text.EndsWith("13"));
        }

        static void StringEqualsMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Equals fonksiyonu ile string degiskenin degeri
             * belirledigimiz deger ile esit olup olmadigini bize True veya False olarak bildirir.
             */

            Console.WriteLine(text.Equals("Merhaba benim adim Muhammet. Yasim 13"));
        }

        static void StringCompareMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Compare fonksiyonu metinsel ifadeleri karsilastirmamizi ve
             * sonuc olarak int turde deger dondurur.
             * 0 ise her iki degerde esittir.
             * 1 ise soldaki sagindakinden alfanumerik olarak daha buyuktur.
             * -1 ise soldaki sagindakinden alfanumerik olarak daha kucuktur.
             */

            Console.WriteLine(String.Compare(text, text));
            Console.WriteLine(String.Compare("a", "a"));
        }

        static void StringCompareToMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * CompareTo fonksiyonu metinsel ifadeleri karsilastirmamizi ve
             * sonuc olarak int turde deger dondurur.
             * 0 ise her iki degerde esittir.
             * 1 ise soldaki sagindakinden alfanumerik olarak daha buyuktur.
             * -1 ise soldaki sagindakinden alfanumerik olarak daha kucuktur.
             * NOT: CompareTo fonksiyonu ayit oldugunu degiskenin degeri ile karsilarstirir.
             */

            Console.WriteLine(text.CompareTo("xghfghxdghdxfhdxghxdrgdfhdxfyhfgnfxdyerdrbb"));
        }

        static void StringIndexOfMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * IndexOf fonksiyonu ile belirledigimiz karakterin ilk buldugu karakterin
             * index numarasini dondurur.
             */

            Console.WriteLine(text.IndexOf('a'));
        }

        static void StringInsertMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Insert fonksiyonu ile belirledigimiz pozisyonun 
             * index numarasina belirledigimiz metini olan metine dahil eder.
             */

            Console.WriteLine(text.Insert(3, "#"));
        }

        static void StringRemoveMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Remove fonksiyonu ile belirledigimiz pozisyonun 
             * index numarasindan itibaren sonrasini siler.
             */

            Console.WriteLine(text.Remove(2));
        }

        static void StringReplaceMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Replace fonksiyonu ile belirledigimiz metindeki yazinin 
             * yerine belirledigimiz yeni yaziyla degistirir.
             * 
             * NOT: Belirlenen yazi birden fazla metinin icinde bulunuyosa 
             * tum bulunanlari verilen yeni yaziyla degistirir.
             */

            Console.WriteLine(text.Replace("Merhaba", "Selam"));
        }

        static void StringSplitMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Split fonksiyonu ile belirledigimiz yaziyi 
             * bulundugu yerde metini keserek string Array dondurur.
             */

            string[] words = text.Split(" ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void StringSubstringMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * Substring fonksiyonu ile belirledigimiz 
             * index pozisyonundan sonra kalan metini geri dondurur.
             */

            Console.WriteLine(text.Substring(3));
        }

        static void StringToLowerMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * ToLower fonksiyonu ile metin icerisindeki yazilari kucultur.
             */

            Console.WriteLine(text.ToLower());
        }

        static void StringToUpperMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13";

            /*
             * ToUpper fonksiyonu ile metin icerisindeki yazilari buyutur.
             */

            Console.WriteLine(text.ToUpper());
        }

        static void StringTrimMethod()
        {
            string text = "     Merhaba benim adim Muhammet. Yasim 13   ";

            /*
             * Trim fonksiyonu ile metininin basindaki ve sonundaki fazla bosluklari siler.
             */

            Console.WriteLine(text.Trim());
        }

        static void StringTrimStartMethod()
        {
            string text = "     Merhaba benim adim Muhammet. Yasim 13";

            /*
             * TrimStart fonksiyonu ile metininin basindaki fazla bosluklari siler.
             */

            Console.WriteLine(text.TrimStart());
        }

        static void StringTrimEndMethod()
        {
            string text = "Merhaba benim adim Muhammet. Yasim 13    ";

            /*
             * TrimEnd fonksiyonu ile metininin sonundaki fazla bosluklari siler.
             */

            Console.WriteLine(text.TrimEnd());
        }

        static void StringExample1()
        {
            // Ad ve soyadin ilk iki harflerinin ekrana yazimi.
            string name = "Muhammet";
            string surname = "Ozdemir";

            // Mu Oz
            Console.WriteLine($"{name[0]}{name[1]} {surname[0]}{surname[1]}");
        }

        static void StringExample2()
        {
            // Yaptigimiz programla verdigimiz yazinin kac harfli oldugunu bize soyler.
            string? input = Console.ReadLine();
            Console.WriteLine(input?.Length);
        }

        static void StringExample3()
        {
            // Yazdigimiz program bize kactane kelime yazdiysak rakan olarak bildirir.
            string? input = Console.ReadLine();
            string[]? words = input?.Split(" ");
            Console.WriteLine(words?.Length);
        }

        #endregion

        #region TEST 4

        static void ArraySegmentDefinition()
        {
            /*
             * ArraySegment Array'inin belirli elemanlari veya tumu referansli bir sekilde 
             * uzerine islem yapmamizi saglar.
             * 
             * Normal Array'in elemanlarina kopyalamak yerine referansli bir sekilde uzerine 
             * islem yapmamizi olanak tanir.
             */

            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            // Vermis oldugumuz Array'inin tum elemanlarini ArraySegment'e
            // referansli bir sekilde teslim eder.
            // ArraySegment<int> arraySegment1 = new ArraySegment<int>(numbers);

            // Vermis oldugumuz Array'inin belirli aralikta elemanlarini ArraySegment'e
            // referansli bir sekilde teslim eder.
            ArraySegment<int> arraySegment2 = new ArraySegment<int>(numbers, 1, 2);
            arraySegment2[0] = 5;
        }

        static void ArraySegmentSliceMethod()
        {
            /*
            * ArraySegment Slice Methodu segmentin icinde bulunan 
            * elemanlari yine ayri segmentler olusturmamizi saglar
            */

            int[] numbers = new int[] { 10, 20, 30, 40, 50 };
            ArraySegment<int> segment = new ArraySegment<int>(numbers);
            ArraySegment<int> segmentSlice1 = segment.Slice(0, 3);
            segmentSlice1[0] = 15;

        }

        static void StringSegmentUsage()
        {
            /*
             * StringSegment bir metinin belirli araligini alarak RAM'de yeniden alan tahsisi etmeden
             * kullanmamizi saglar.
             * 
             * NOT: Segment uzerine degisiklik saglandigi zaman ana degiskene etki etmemektedir.
             */
            string message = "Abuzer babasinin zoruyla ekmek almaya gitti";
            StringSegment stringSegment = new StringSegment(message, 0, 6);
            stringSegment = "Muhammet";
        }

        static void StringBuilderUsage()
        {
            /*
             * StringBuilder Sinifi: arti operatoru ile birlestirilecek olan degiskenler 
             * daha az maliyetle birlestirmek icin 
             * StringSegment algoritmasini kullanarak performansi artirir.
             */
            string name = "Muhammet";
            string surname = "Ozdemir";
            int schoolNo = 610;

            StringBuilder builder = new StringBuilder();
            builder.Append(name);
            builder.Append(' ');
            builder.Append(surname);
            builder.Append(' ');
            builder.Append(schoolNo);
            Console.WriteLine(builder.ToString());
        }

        static void EvenAndOdd()
        {
            /*
             * Bu program, kullanıcının girişini daha az satırda kontrol eder. 
             * Console.WriteLine ifadesinde kullanılan üçlü operatör (ternary operator) sayesinde, 
             * tek bir satırda çift ya da tek olma durumuna göre mesaj yazdırılır.
             */

            Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı girin:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && input < 11)
            {
                Console.WriteLine(input % 2 == 0 ? "Girilen sayı çift." : "Girilen sayı tek.");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen 1 ile 10 arasında bir sayı girin.");
            }
        }

        static void Regex()
        {
            string? text = Console.ReadLine();

            /*
             * Regular Expressions: Düzenli İfadeler (Regex), metinle ilgili deseni tanımlamak 
             * veya eşleştirmek için kullanılan bir karakter dizisidir
             * 
             * Bir metinin sahip olmasi gereken deseni kuralli bir sekilde ve
             * duzenli bir ifade yazmamizi saglar.
             * 
             * KURALLAR: 
             * 1-) . : alt satir sonu disinda butun karakterleri gecerlidir.
             * 2-) ^ : Satir basinin isteninlen ifadeyle baslamasini saglar.
             */

            if (!string.IsNullOrEmpty(text))
            {
                Regex regex = new Regex("[^abc]");
                Match match = regex.Match(text);
                if (!match.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yaziniz gecerlidir.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Yaziniz gecersizdir.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Hatali giris yaptiniz");
            }
        }

        static void ArrayListUsage()
        {
            /*
             * ArrayList Array'le ayni yapida olup ancak arrayinin sinirliliklarini asan bir yapidir.
             * ArrayList bir koleksiyondur.
             * 
             */

            // ArrayList tanimlama
            ArrayList brands = new ArrayList();

            // ArrayList'te deger ekleme
            brands.Add("Zara");
            brands.Add("Puma");
            brands.Add("Nike");
            brands.Add("Adidas");
            brands.Add("Koton");

            // ArrayList'te deger silme
            brands.RemoveAt(4);

            // ArrayList'te Boxing yontemi 
            brands.Add(13);

            // ArrayList Unboxing yontemi
            Console.WriteLine((int?)brands[4] + 10);
        }

        static void ArrayListInitializerUsage()
        {
            /*
             * ArrayList'te ilklendirici (Initializer) ile deger tanimlama.
             */

            ArrayList names = new ArrayList()
            {
                "Muhammet",
                "Poyraz",
                "Ahmet",
                "ege",
                "su"
            };
        }

        static void Homework1()
        {
            /*
             * Names olan arrayinin hem forloop ile ve foreach ile icindeki ilgili degerleri ekrana yazacak.
             * Names arrayinin icindeki eleman sayisi ekrana yazdirilcak.
             * Namesin arrayinin icindeki olan  elemanlarinin en son elemanin bir oncesini ekrana yazdir.
             * 
             */

            ArrayList names = new ArrayList()
            {
                "Muhammet",
                "Eda",
                "Poyraz",
                "Melek",
                "Deniz",
                546
            };
        }

        static void MathFunctionsUsage()
        {
            double number = 16.5;

            // Round fonksiyonu vermis oldugumuz sayiyi yuvarlar.
            Console.WriteLine(Math.Round(number));

            // Sqrt fonksiyonu vermis oldugumuz sayinin karesini verir.
            Console.WriteLine(Math.Sqrt(number));

            // Abs fonksiyonun vermis oldugumuz sayinin mutlak degerini verir.
            Console.WriteLine(Math.Abs(-5));

            // Ceiling fonksiyonun vermis oldugumuz sayinin yakin oldugu rakama yukariya yuvarlar.
            Console.WriteLine(Math.Ceiling(3.01));

            // Floor fonksiyonun vermis oldugumuz sayinin yakin oldugu rakama asagiya yuvarlar.
            Console.WriteLine(Math.Floor(3.99));

            // Pow fonksiyonun vermis oldugumuz sayi x ve y sayilari x taban y kuvveti olarak hesaplar.
            Console.WriteLine(Math.Pow(3, 3));

            // Truncate fonksiyonun vermis oldugumuz ondalik sayinin tam sayisini verir.
            Console.WriteLine(Math.Truncate(3.56));
        }

        static void DateTimeUsage()
        {
            /*
             * DateTime nedir: Zamanin tarihi ve saati ile ilgili tum islemleri ve 
             * ozlellikleri barindiran bir struct'tir.
             */

            // DateTime.Now su anki tarih ve saati bize dondurur.
            Console.WriteLine(DateTime.Now);

            // DateTime.Today su anki tarih bize dondurur.
            Console.WriteLine(DateTime.Today);

            // DateTime.IsLeapYear fonksiyonu artik yil olup olmadigini bize dondurur.
            Console.WriteLine(DateTime.IsLeapYear(2023));

            /* DateTime.Compare fonksiyonu Tarih bir (t1) ile tarih iki (t2) ile  karsilastirir.
             * -1 ise t1 t2 den kucuk 
             * sifir ise t1 ve t2 esittir.
             * 1 ise t1 t2'den buyuk.
             */
            Console.WriteLine(DateTime.Compare(new DateTime(2023, 12, 10), new DateTime(2023, 12, 20)));
        }

        static void TimeSpanUsage()
        {
            /*
             * TimeSpan iki tarihin karsilastirmasi sonucunda aradaki zaman farkini temsil eder.
             */

            DateTime t1 = DateTime.Now;
            DateTime t2 = new DateTime(2023, 12, 10);
            TimeSpan timeSpan = t1 - t2;
            Console.WriteLine(timeSpan);
        }

        static void RandomUsage()
        {
            /*
             * Random rastgele bir sayi uretmek icin kullanilan bir siniftir.
             * 
             * Next fonksiyonuna max degeri vererek sifirdan 
             * max degeri arasinda bir rastgele sayi uretir.
             * Not: Uretilen sayi max degerine ulasmaz.
             */

            Random rdm = new Random();

            // Maksimum deger
            Console.WriteLine(rdm.Next(10));

            // Minimum deger ile maksimum deger
            Console.WriteLine(rdm.Next(10, 50));

            // Rastgele ondalik sayi uretir
            Console.WriteLine(rdm.NextDouble());
        }

        static void OptionalParameter(string name, string surname = "")
        {
            /*
             * İsteğe Bağlı Parametreler fonksiyonun belirli 
             * parametreleri istege bagli olarak tanimlayabiliriz.
             * 
             * İsteğe Bağlı Parametre Tanimlayabilmek icin parametre adinin 
             * yanina atama operatoru ile varsayilan degeri atamamiz gerekir.
             */
            Console.WriteLine($"Hello, {name} {surname}");
        }

        static void NonTrailingNamedArguments(int a, bool b, string c)
        {
            /*
             * Non Trailing Named Arguments ozelligi bir fonksiyonun parametrelerine verilecek olan degerlerin 
             * siralamasini verme esnadinda degistirmemizi saglar.
             */
        }

        static void NonTrailingNamedArgumentsApp()
        {
            NonTrailingNamedArguments(c: "abc", a: 672, b: false);
        }


        static void A(int a)
        {

        }

        static int B(string a)
        {
            return 0;
        }

        static bool C()
        {
            return false;
        }

        static string D(char a, string[] b, byte c)
        {
            return "";
        }

        static int[] E()
        {
            return new int[] { };
        }

        static void F(byte a = 1)
        {

        }

        static int G(int x, int y)
        {
            return x + y;
        }

        static string H(string a, string b = "")
        {
            //return $"{a}{(string.IsNullOrEmpty(b) ? "" : b)}";
            //return $"{a}{(string.IsNullOrEmpty(b) ? "" : b)}";
            //return $"{a}{(string.IsNullOrEmpty(b) ? "" : b)}";
            //return $"{a}{(string.IsNullOrEmpty(b) ? "" : b)}";
            return $"{a}{(string.IsNullOrEmpty(b) ? "" : b)}";
        }

        static void InKeywordWithParameters(in string a)
        {
            /*
             * In keywordu parametrenin basina yazildiginda ilgili parametrenin fonksiyon icerisinde
             * degerinin degismesini engeller / Salt(sadece) okunur hale getirir.
             */

            // a = "Muhammet";
            Console.WriteLine(a);
        }

        static void TheInnerLocalMethod()
        {
            /*
             * Local Method bir Methodun icerisinde yerel bir Method tanimlamamiza olanak tanir.
             */

            static string GetMessage()
            {
                return "Merhaba Ben Muhammet";
            }

            Console.WriteLine(GetMessage());
        }

        static void StaticLocalMethod()
        {
            /*
             * Static local function tanimlanmis olan yerel method bulundugu scopta diger degiskenlere 
             * performans maliyeti acisindan dolayi direkt erisimine engeller.
             */

            int x = 5;
            static void Print()
            {

                // Console.WriteLine(x);
            }
        }
        #endregion

        /*
         * Overloading(Coklu yukleme) 
         * Farkli parametre veya parametre sayisi olan method ayni adi ile 
         * farkli yeni bir method tanimlanabilir.
         */

        static void MethodA()
        {
            Console.WriteLine("Hello World!");
        }

        static void MethodA(string text)
        {
            Console.WriteLine(text);
        }

        static string MethodA(int num)
        {
            return $"{num + 5}";
        }
    }
}