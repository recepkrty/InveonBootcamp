using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class OCP
    {
        /* Tuş ataması arttıkça if blokları artacak, kod okunurluğu, kohezyon azalacak ve yazılan kodu değiştirilmesi
         gerekecek bu yüzden OCP' yi ihlal ediyor. */
        public void Move(string key)
        {
            if (key == "w")
            {
                Console.WriteLine("Move Forward");
            }
            else if (key == "a")
            {
                Console.WriteLine("Turn Left");
            }
            else if (key == "s")
            {
                Console.WriteLine("Move Back");
            }
            else if (key == "d")
            {
                Console.WriteLine("Turn Right");
            }
            else
            {
                throw new InvalidOperationException("Unknown key.");
            }
        }
    }
}
