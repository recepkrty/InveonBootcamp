using System;

namespace Week1.Bölüm_1
{
    internal class SRP_BestPractise
    {
        internal class Account
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Balance { get; set; }

            public Account(int id, string name, double balance) { 
                Id = id;
                Name = name;
                Balance = balance;
            }

        }

        internal interface INotificationService
        {
            void NotifyCustomer(string message);
        }

        internal class NotificationService : INotificationService
        {
            public void NotifyCustomer(string message)
            {
                Console.WriteLine("Notification sent: " + message);
            }
        }
        internal interface IAccountService
        {
            void BalanceInquiry(Account account);
        }

        internal class AccountManager : IAccountService
        {
            private INotificationService notificationService;

            public AccountManager(INotificationService notificationService)
            {
                this.notificationService = notificationService;
            }

            public void BalanceInquiry(Account account)
            {
                Console.WriteLine("Balance for account " +account.Name + "  " + account.Balance);
                notificationService.NotifyCustomer("Bakiye Görüntülendi");
            }
        }
    }
}
