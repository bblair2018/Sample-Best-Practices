using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // In this example, we'll define a CoffeeMaker class that represents the template with a predefined process for making coffee.
    // The template method, MakeCoffee(), will define the overall algorithm for making coffee, while specific steps can be customized by
    // subclasses
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // The CoffeeMaker class represents the template with a predefined process for making
    // coffee. It defines the template method MakeCoffee(), which represents the overall
    // algorithm for making coffee. The template method is composed of several steps (methods)
    // that are implemented as abstract methods or concrete methods.
    // ------------------------------------------------------------------------------------

    public abstract class CoffeeMaker
    {
        /// <summary>
        /// The MakeCoffee method in the CoffeeMaker class serves as the template method. 
        /// It defines the sequence of steps to make coffee using the predefined algorithm. 
        /// The steps include boiling water, brewing coffee (which is left abstract), pouring 
        /// the coffee into a cup, adding condiments (which is also left abstract), and indicating 
        /// that the coffee is ready.
        /// </summary>
        public void MakeCoffee()
        {
            BoilWater();
            BrewCoffee();
            PourIntoCup();
            AddCondiments();
            Console.WriteLine("Coffee is ready!");
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void BrewCoffee();

        protected void PourIntoCup()
        {
            Console.WriteLine("Pouring coffee into cup");
        }

        protected abstract void AddCondiments();
    }

    // ------------------------------------------------------------------------------------
    // The concrete subclasses (CappuccinoMaker and AmericanoMaker) inherit from the
    // CoffeeMaker base class and provide concrete implementations for the abstract methods
    // (BrewCoffee and AddCondiments). These subclasses customize specific steps of the
    // coffee-making process.
    // ------------------------------------------------------------------------------------

    public class CappuccinoMaker : CoffeeMaker
    {
        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing Cappuccino espresso");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk foam and chocolate powder");
        }
    }

    public class AmericanoMaker : CoffeeMaker
    {
        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing Americno espresso");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding hot water");
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // By using the template method pattern, we can define the overall process for making coffee in the base class while allowing
    // subclasses to customize specific steps as needed. This provides a flexible and extensible way to handle variations in the
    // coffee-making process.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The code above implements the Template Method design pattern to support the process of making different types of coffee
    // (e.g., Cappuccino and Americano) while defining an overall algorithm in the base class (CoffeeMaker). The Template Method
    // pattern allows the base class to define the steps of the algorithm while allowing subclasses to customize specific steps as needed.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
