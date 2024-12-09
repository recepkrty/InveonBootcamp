using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week1.Bölüm_2
{
    internal class Sync_Async
    {
        // Eşzamanlı Metot
        public static void SyncMethod()
        {
            Console.WriteLine("Starting a long-running task...");
            Thread.Sleep(3000); 
            Console.WriteLine("Task completed.");
        }

        // Asenkron Metot
        public static async Task AsyncMethod()
        {
            Console.WriteLine("Starting a long-running task...");
            await Task.Delay(3000);
            Console.WriteLine("Task completed.");
        }
    }
}
