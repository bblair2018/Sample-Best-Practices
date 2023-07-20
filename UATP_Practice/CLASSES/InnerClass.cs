using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.CLASSES
{
    public class OuterClass
    {
        public void OuterMethod()
        {
            Console.WriteLine("OuterMethod");
        }

        public class InnerClass
        {
            public void InnerMethod()
            {
                Console.WriteLine("InnerMethod");
            }
        }
    }

}
