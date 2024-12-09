using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class ISP
    {
        internal interface IDriverLicences
        {
            void ClassM();
            void ClassA();
            void ClassB();
            void ClassC();
            void ClassD();
            void ClassF();
        }

        /*Burada B sınıfı ehliyet sahip araç sürücüsü sadece M, B ve F 
         sınıfını kullanabildiği halde tüm metotları implement etmek zorunda kalıyor.*/
        internal class DriverA : IDriverLicences
        {
            public void ClassA()
            {
                throw new NotImplementedException();
            }

            public void ClassB()
            {
                Console.WriteLine("B sınıfı araç kullanabilir.");
            }

            public void ClassC()
            {
                throw new NotImplementedException();
            }

            public void ClassD()
            {
                throw new NotImplementedException();
            }

            public void ClassF()
            {
                Console.WriteLine("F sınıfı araç kullanabilir.");
            }

            public void ClassM()
            {
                Console.WriteLine("M sınıfı araç kullanabilir.");
            }
        }
    }
}
