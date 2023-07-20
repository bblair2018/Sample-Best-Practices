using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.SOLID
{
    public class ElectricEngine : IEngine
    {
        public string start()
        {
            return "Electric Engine Started.";
        }

        public string stop()
        {
            return "Electric Engine Stopped.";
        }
    }
}
