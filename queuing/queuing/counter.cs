using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuing
{
    class counter
    {
        static public int RemainNum = 0;
        static public int callNum = 1;
        public int ShowRemainedNumber()
        {
            return RemainNum;
        }

        public void CallNext()
        {
            RemainNum--;
        }
    }
}
