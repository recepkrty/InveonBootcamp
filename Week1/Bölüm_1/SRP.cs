using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class SRP
    {
        internal class Account
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Balance { get; set; }


            /*Burada Account sınıfı bakiye sorgulama, müşteri bilgilendirme gibi işlemleri de bulundurduğundan ve metot içinde başka 
            bir sınıfa bağımlılığı bulunduğundan dolayı SRP'ye uymamaktadır. Bağımlı olduğu sınıfta yapılan değişikliklerden etkilenir. */
            public void BalanceInquiry() 
            {
                NotificationService notificationService = new NotificationService();
                Console.WriteLine("Balance : " + Balance);
                notificationService.NotifyCustomer("Bakiye Görüntülendi");
            }


        }

        internal class NotificationService
        {
            public void NotifyCustomer(string message)
            {
                Console.WriteLine("Notification sent: " + message);
            }
        }

    }
}
