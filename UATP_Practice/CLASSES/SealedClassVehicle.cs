using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UATP_Practice.SOLID;

namespace UATP_Practice.CLASSES
{
    public class SealedClassVehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
    }

    public sealed class SealedCar : SealedClassVehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car started.");
        }
    }
}
