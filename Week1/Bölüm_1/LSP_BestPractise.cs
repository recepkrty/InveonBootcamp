using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class LSP_BestPractise
    {
        internal abstract class Ticket
        {
            public void SeatSelect()
            {
                Console.WriteLine("Koltuk Seçimi Yapıldı.");
            }
        }

        internal interface IExtraBaggage
        {
            void ExtraBaggage();
        }

        internal class EconomyTicket : Ticket
        {

        }

        internal class BusinessTicket : Ticket, IExtraBaggage
        {
            public void ExtraBaggage()
            {
                Console.WriteLine("Ekstra Bagaj Alındı.");
            }
        }
    }
}
