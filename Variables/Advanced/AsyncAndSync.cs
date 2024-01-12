using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Advanced
{
    internal class AsyncAndSync
    {


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
    }
}
