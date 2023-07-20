using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.SOLID
{
    public class GasEngine : IEngine
    {
        public string start()
        {
            return "Gas Egnine Started.";
        }

        public string stop()
        {
            return "Gas Engine Stopped.";
        }
    }
}
