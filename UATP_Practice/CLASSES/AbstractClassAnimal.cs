using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.CLASSES
{
    public abstract class AbstractClassAnimal
    {
        // Abstract method
        public abstract void MakeSound();

        // Concrete method
        public void Sleep()
        {
            Console.WriteLine("Zzzz... Animal is sleeping.");
        }
    }

    public class Dog : AbstractClassAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    public class Cat : AbstractClassAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
