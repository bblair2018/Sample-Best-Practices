using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.SOLID
{
    public class Car : IVehicle
    {
        private readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public string start()
        {
            return _engine.start();
        }

        public string stop()
        {
            return _engine.stop();
        }
    }
}
