using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuing
{
    class mainserver
    {
        public List<int> wait = new List<int>();
        public void save()
        {
            wait.Add(counter.callNum);
        }
        public void delete()
        {
            wait.RemoveAt(0);
        }
    }
}
