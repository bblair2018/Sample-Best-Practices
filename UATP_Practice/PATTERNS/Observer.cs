using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Let's consider a stock market scenario where we have multiple investors who want to be notified about the price changes of a
    // specific stock. The Observer Pattern can be used to implement this scenario.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // First, define an interface that represents the observers (investors) and their common
    // operations:
    // ------------------------------------------------------------------------------------

    public interface IInvestor
    {
        void Update(string stockName, decimal price);
    }

    // ------------------------------------------------------------------------------------
    // Next, implement the concrete observer classes:
    // ------------------------------------------------------------------------------------

    public class Investor : IInvestor
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(string stockName, decimal price)
        {
            Console.WriteLine($"Investor {_name} received an update for stock {stockName}. New price: {price}");
        }
    }

    // ------------------------------------------------------------------------------------
    // Next, define the subject (stock) that the observers will be observing:
    // ------------------------------------------------------------------------------------

    public class Stock
    {
        private string _name;
        private decimal _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        public Stock(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void SetPrice(decimal price)
        {
            _price = price;
            Notify();
        }

        private void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(_name, _price);
            }
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // In the example above, we have a Stock class that represents the subject being observed. It maintains a list of investors and
    // provides methods to attach, detach, and set the price of the stock. When the price is updated, the Notify method is called to
    // notify all the registered investors.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
