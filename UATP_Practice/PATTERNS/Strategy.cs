using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Let's consider a payment processing system that supports different payment methods such as credit card, PayPal, and bank transfer.
    // Each payment method requires different validation and processing logic. The Strategy Pattern can be used to implement this scenario.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // First, define an interface that represents the payment strategy:
    // ------------------------------------------------------------------------------------
    // The IPaymentStrategy interface defines the contract for different payment strategies.
    // Each concrete strategy class (CreditCardPaymentStrategy, PayPalPaymentStrategy, and BankTransferPaymentStrategy)
    // implements this interface and provides its own implementation of the ProcessPayment method.
    // ------------------------------------------------------------------------------------

    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }

    // ------------------------------------------------------------------------------------
    // Next, implement concrete strategy classes for each payment method:
    // ------------------------------------------------------------------------------------
    // The concrete strategy classes represent different payment methods. Each class
    // (CreditCardPaymentStrategy, PayPalPaymentStrategy, and BankTransferPaymentStrategy)
    // implements the IPaymentStrategy interface and defines its unique logic for processing
    // the respective payment method.
    // ------------------------------------------------------------------------------------

    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private string _cardNumber;
        private string _expiryDate;
        private string _cvv;

        public CreditCardPaymentStrategy(string cardNumber, string expiryDate, string cvv)
        {
            _cardNumber = cardNumber;
            _expiryDate = expiryDate;
            _cvv = cvv;
        }

        public void ProcessPayment(decimal amount)
        {
            // Logic for processing credit card payment
            Console.WriteLine($"Processing credit card payment of amount {amount} using card number {_cardNumber}");
        }
    }

    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        private string _email;
        private string _password;

        public PayPalPaymentStrategy(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void ProcessPayment(decimal amount)
        {
            // Logic for processing PayPal payment
            Console.WriteLine($"Processing PayPal payment of amount {amount} using email {_email}");
        }
    }

    public class BankTransferPaymentStrategy : IPaymentStrategy
    {
        private string _accountNumber;
        private string _bankCode;

        public BankTransferPaymentStrategy(string accountNumber, string bankCode)
        {
            _accountNumber = accountNumber;
            _bankCode = bankCode;
        }

        public void ProcessPayment(decimal amount)
        {
            // Logic for processing bank transfer payment
            Console.WriteLine($"Processing bank transfer payment of amount {amount} to account {_accountNumber}");
        }
    }

    // ------------------------------------------------------------------------------------
    // Next, define a context class that uses the payment strategy:
    // ------------------------------------------------------------------------------------
    // The PaymentProcessor class acts as the context in the Strategy pattern. It maintains
    // a reference to the current payment strategy (_paymentStrategy) and has a method (SetPaymentStrategy)
    // to set the payment strategy dynamically at runtime. The ProcessPayment method
    // delegates the payment processing task to the current payment strategy.
    // ------------------------------------------------------------------------------------

    public class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // The code above implements the Strategy design pattern to support different payment methods (credit card, PayPal, and bank transfer)
    // in a payment processing system. The Strategy pattern allows the payment processing system to switch between different payment
    // strategies (algorithms) at runtime, enabling flexibility and extensibility in handling various payment methods
    // ----------------------------------------------------------------------------------------------------------------------------------
    // In this example, the payment processing system uses different payment strategies (CreditCardPaymentStrategy, PayPalPaymentStrategy,
    // and BankTransferPaymentStrategy) to process payments. The PaymentProcessor class can switch between these strategies dynamically by
    // calling the SetPaymentStrategy method.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Strategy pattern allows for easy addition of new payment methods by implementing additional concrete strategy classes without
    // modifying the existing code. It promotes better code organization, maintainability, and the ability to extend the payment system
    // with new strategies in the future.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
