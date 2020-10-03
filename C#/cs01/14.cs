using System;
namespace Brainchild.Curriculum.Solutions
{
    // In a restaurant we have to bill. And we have happy hour billing and normal billing.
    // In happy hour, they get 20% discount. Print will print the final bill. 
    // There should be a common  interface for both strategy classes .e.g IStrategy
    // Then you can expose an internal field like IStrategy strategy; inside the CustomerBill class
    // Now strategy variable can be assigned from constructor.
    // Now Print() method can use this strategy class to do billing calculation
    // you can create a function or constructor with an argument as IStrategy , 
    // then pass the actual object derived from the interface when calling the constructor
    public interface IBillingStrategy
    {
        double Print(double price);
    }
    public class NormalStrategy : IBillingStrategy
    {
        public double Print(double price)
        {
            return price;
        }
    }
    public class HappyHourStrategy : IBillingStrategy
    {
        public double Print(double price)
        {
            return price * .8;
        }
    }
    public class CustomerBill
    {
        public IBillingStrategy Strategy { get; set; }
        public CustomerBill(IBillingStrategy strategy)
        {
            this.Strategy = strategy;
        }
        public double Add(double maxprice, int quantity)
        {
            return this.Strategy.Print(maxprice * quantity);
        }
    }

}