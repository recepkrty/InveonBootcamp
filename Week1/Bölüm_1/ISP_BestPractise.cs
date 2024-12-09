using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class ISP_BestPractise
    {
        internal interface IDriverLicenceClassA : IDriverLicenceClassM
        {
            void DriveableClassA();
        }
        internal interface IDriverLicenceClassB : IDriverLicenceClassM, IDriverLicenceClassF
        {
            void DriveableClassB();
        }
        internal interface IDriverLicenceClassM 
        {
            void DriveableClassM();
        }
        internal interface IDriverLicenceClassC : IDriverLicenceClassB
        {
            void DriveableClassC();
        }
        internal interface IDriverLicenceClassD : IDriverLicenceClassB
        {
            void DriveableClassD();
        }
        internal interface IDriverLicenceClassF
        {
            void DriveableClassF();
        }

        //B sınıfı ehliyete sahip sürücü sadece ihtiyacı olan interface'i implement eder.
        internal class Driver : IDriverLicenceClassB
        {
            public void DriveableClassB()
            {
                Console.WriteLine("B sınıfı araç kullanabilir.");
            }

            public void DriveableClassF()
            {
                Console.WriteLine("F sınıfı araç kullanabilir.");
            }

            public void DriveableClassM()
            {
                Console.WriteLine("M sınıfı araç kullanabilir.");
            }
        }
    }
}
