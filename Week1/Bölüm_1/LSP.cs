using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class LSP
    {
        internal abstract class Ticket
        {
            public void SeatSelect()
            {
                Console.WriteLine("Koltuk Seçimi Yapıldı.");
            }
            public abstract void ExtraBaggage();

        }

        /* Burada her iki bilet tipi yer değiştirdiği zaman kod hata verir. Bu yüzden LSP' ye aykırıdır.
         Ticket ticket = new EconomyTicket();
         ticket.ExtraBaggage();
         Ticket ticket = new BusinessTicket();
         ticket.ExtraBaggage(); */
        internal class EconomyTicket : Ticket
        {
            public override void ExtraBaggage()
            {
                throw new NotImplementedException();
            }

        }

        internal class BusinessTicket : Ticket
        {
            public override void ExtraBaggage()
            {
                Console.WriteLine("Ekstra Bagaj Alındı.");
            }
        }

    }
}
