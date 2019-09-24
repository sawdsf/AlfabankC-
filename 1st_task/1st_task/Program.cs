using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_task
{
    class Program
    {
        static int[] M = { 15, 14, 13, 12, 11, 10 };
        static void Main(string[] args)
        {
            _1st_task a = new _1st_task();
            Console.WriteLine(a.Bsearch(M,13));
        }
    }
}
