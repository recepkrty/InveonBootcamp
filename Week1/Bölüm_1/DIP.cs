using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Bölüm_1
{
    internal class DIP
    {

        //high level class low level bir classa bağımlı olmamalıdır, class içinde örneğini oluşturmamalıdır.
        internal class HighLevelClass
        {
            LowLevelClass lowLevelClass = new LowLevelClass();
        }

        internal class LowLevelClass
        {

        }
    }
}
