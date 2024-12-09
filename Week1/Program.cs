using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Week1.Bölüm_1;
using Week1.Bölüm_2;



namespace Week1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            #region Single Responsibility
            Console.WriteLine("Single Responsibility Outputs: ");
            SRP_BestPractise.Account account = new SRP_BestPractise.Account(1, "Recep", 2500);
            SRP_BestPractise.NotificationService notificationService = new SRP_BestPractise.NotificationService();
            SRP_BestPractise.AccountManager accountManager = new SRP_BestPractise.AccountManager(notificationService);
            accountManager.BalanceInquiry(account);
            #endregion

            #region Open/Closed
            Console.WriteLine("\nOpen/Closed Outputs: ");
            OCP_BestPractise.TurnRight turnRight = new OCP_BestPractise.TurnRight();
            OCP_BestPractise.Jump jump = new OCP_BestPractise.Jump();
            jump.Move();
            turnRight.Move();
            #endregion

            #region Liskov Substitution
            Console.WriteLine("\nLiskov Substitution Outputs: ");
            LSP_BestPractise.Ticket ticket = new LSP_BestPractise.BusinessTicket();
            if(ticket is LSP_BestPractise.IExtraBaggage tickettype)
            {
                tickettype.ExtraBaggage();
            }
            ticket = new LSP_BestPractise.EconomyTicket();
            if (ticket is LSP_BestPractise.IExtraBaggage tickettype2)
            {
                tickettype2.ExtraBaggage();
            }
            #endregion

            #region Interface Segregation
            Console.WriteLine("\nInterface Segregation Outputs: ");
            ISP_BestPractise.Driver driverLicenceClassB = new ISP_BestPractise.Driver();
            driverLicenceClassB.DriveableClassM();
            driverLicenceClassB.DriveableClassB();
            driverLicenceClassB.DriveableClassF();
            #endregion

            #region Dependency Inversion
            Console.WriteLine();
            DIP_BestPractise.LowLevelClass lowLevelClass = new DIP_BestPractise.LowLevelClass();
            DIP_BestPractise.HighLevelClass highLevelClass = new DIP_BestPractise.HighLevelClass(lowLevelClass);
            #endregion

            #region Asenkron - Senkron Metot Yazımı
            Console.WriteLine("Synchronous Method:");
            var stopwatch = Stopwatch.StartNew();
            Sync_Async.SyncMethod();
            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms\n");

            Console.WriteLine("Asynchronous Method:");
            stopwatch.Restart();
            Sync_Async.AsyncMethod().Wait();
            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            #endregion

            #region Task Sınıfının Static Methodları  
            Console.WriteLine("1. Task.Run:");
            await TaskStaticMethods.RunExample();

            Console.WriteLine("\n2. Task.Delay:");
            await TaskStaticMethods.DelayExample();

            Console.WriteLine("\n3. Task.WhenAll:");
            await TaskStaticMethods.WhenAllExample();

            Console.WriteLine("\n4. Task.WhenAny:");
            await TaskStaticMethods.WhenAnyExample();

            Console.WriteLine("\n5. Task.FromResult:");
            TaskStaticMethods.FromResultExample();

            Console.WriteLine("\n6. Task.CompletedTask:");
            await TaskStaticMethods.CompletedTaskExample();

            Console.WriteLine("\n7. Task.FromException:");
            TaskStaticMethods.FromExceptionExample();

            Console.WriteLine("\n8. Task.FromCanceled:");
            TaskStaticMethods.FromCanceledExample();
            #endregion

        }
    }
}
