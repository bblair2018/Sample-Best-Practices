using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.CLASSES
{
    public class refOutExample
    {
        public int x;

        public void AddOne(ref int number)
        {
            number += 1;
        }

        public void MultiplyByTwo(out int number)
        {
            number = 10;
            number *= 2;
        }
    }
}
