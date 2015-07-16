using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuing
{
    public class device
    {
        public int show()
        {
            return counter.RemainNum;
        }
        public void pull()
        {
            counter.RemainNum++;
        }

    }
}
