using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class DIP_BestPractise
    {
        internal class HighLevelClass
        {
            private ILevelClass _levelclass;

            public HighLevelClass(ILevelClass levelclass)
            {
                _levelclass = levelclass;
            }
        }

        internal interface ILevelClass
        {

        }
        internal class LowLevelClass : ILevelClass
        {

        }
    }
}
