using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_task
{
    class _1st_task
    {
        public int Bsearch(int[] Mass, int x)
        {
            int i = 0;
            while (Mass[i] >= x)
            { i++; }
            return i;
        }
    }
}
