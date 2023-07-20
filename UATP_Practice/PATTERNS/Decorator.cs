using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ------------------------------------------------------------------------------------
    // First, we define the Pizza interface that represents the basic pizza:
    // ------------------------------------------------------------------------------------

    public interface IPizza
    {
        string GetDescription();
        decimal GetCost();
    }

    // ------------------------------------------------------------------------------------
    // Next, we implement the Pizza class that represents the basic pizza without any
    // additional toppings (Cheese is the default topping):
    // ------------------------------------------------------------------------------------
    public class BasicPizza : IPizza
    {
        public string GetDescription()
        {
            return "Basic Pizza (Cheese)";
        }

        public decimal GetCost()
        {
            return 10.0m;
        }
    }

    // ------------------------------------------------------------------------------------
    // Now, we create the PizzaDecorator class, which serves as the base decorator for
    // adding toppings to the pizza:
    // ------------------------------------------------------------------------------------

    /// <summary>
    /// PizzaDecorator is an abstract class implementing IPizza.It acts as a base decorator, holding a reference to the wrapped pizza object. 
    /// It provides methods to retrieve the description and cost by delegating the calls to the wrapped pizza.Derived classes can override 
    /// these methods to add custom behavior.
    /// </summary>
    public abstract class PizzaDecorator : IPizza
    {
        //The protected IPizza pizza field is declared to hold a reference to the pizza being decorated. This field allows the decorator to interact with the wrapped pizza object.
        protected IPizza pizza;

        /// <summary>
        /// Defined to initialize the pizza field. It takes an IPizza parameter, representing the pizza object being decorated, and assigns it to the pizza field.
        /// </summary>
        /// <param name="pizza"></param>
        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        /// <summary>
        /// The GetDescription() method is implemented with the virtual keyword, allowing it to be overridden in derived classes. It delegates the call to 
        /// the wrapped pizza object's GetDescription() method, returning its description.
        /// </summary>
        /// <returns></returns>
        public virtual string GetDescription()
        {
            return pizza.GetDescription();
        }

        /// <summary>
        /// The GetCost() method is also implemented as virtual. Similarly, it delegates the call to the wrapped pizza object's GetCost() method and returns its cost.
        /// </summary>
        /// <returns></returns>
        public virtual decimal GetCost()
        {
            return pizza.GetCost();
        }
    }

    // ------------------------------------------------------------------------------------
    // Next, we implement concrete decorators by extending the PizzaDecorator class.
    // For example, let's create a MushroomDecorator  to add mushrooms to the pizza:
    // For example, let's create a SausageDecorator   to add sausage   to the pizza:
    // For example, let's create a PepperoniDecorator to add peperoni  to the pizza:
    // ------------------------------------------------------------------------------------

    public class MushroomDecorator : PizzaDecorator
    {
        public MushroomDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Mushroom";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 2.0m;
        }
    }

    public class SausageDecorator : PizzaDecorator
    {
        public SausageDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sausage";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 3.0m;
        }
    }

    public class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Pepperoni";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 3.5m;
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // By utilizing decorators, you can dynamically add toppings to a pizza without modifying the core pizza classes. You can combine
    // multiple decorators to create pizzas with various combinations of toppings. The decorators adhere to the IPizza interface, so
    // they can be used interchangeably with the basic pizza or other decorators. This approach allows for flexible and extensible
    // customization of pizzas while keeping the code modular and adhering to the open-closed principle.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
