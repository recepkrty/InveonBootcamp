using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class OCP_BestPractise
    {
        internal interface IKey
        {
            void Move();
        }

        //Yeni bir tuş ataması geldiğinde var olan kodun değiştirilmesi gerekmez ve geliştirilebilir.
        internal class Jump : IKey
        {
            public void Move()
            {
                Console.WriteLine("Jumped.");
            }
        }
        internal class MoveForward : IKey
        {
            public void Move()
            {
                Console.WriteLine("Moved Forward");
            }
        }
        internal class MoveBack : IKey
        {
            public void Move()
            {
                Console.WriteLine("Moved Back.");
            }
        }
        internal class TurnRight : IKey
        {
            public void Move()
            {
                Console.WriteLine("Turned Right"); ;
            }
        }
        internal class TurnLeft : IKey
        {
            public void Move()
            {
                Console.WriteLine("Turned Left");
            }
        }

    }
}
