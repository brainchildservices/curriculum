using System;
namespace Brainchild.Curriculum.Solutions
{
    // In a restaurant we have to bill. And we have happy hour billing and normal billing.
    // In happy hour, they get 20% discount. Print will print the final bill. 
    // There should be a common  interface for both strategy classes .e.g IStrategy
    // Then you can expose an internal field like IStrategy strategy; inside hte CustomerBill class
    // Now strategy variable can be assigned from constructor.
    // Now Print() method can use this strategy class to do billing calculation
    // you can create a function or constructor with an argument as IStrategy , 
    // then pass the actual object derived from the interface when calling the constructor

    public interface IStrategy
    {
        double FinalBill(double price);
    }
    public class CustomerBill
    {
        //Creating a variable of type IStrategy interface
        public IStrategy Strategy { get; set; }
        //Creating a constructor that receives the variable of type IStrategy 
        public CustomerBill(IStrategy selectedStrategy)
        {
            this.Strategy = selectedStrategy;  //received strategy type is passed on to created variable
        }
        public double Amount(double mrp, int count)
        {
            double originalPrice = mrp * count;
            return this.Strategy.FinalBill(originalPrice);
        }
    }
    public class NormalStrategy : IStrategy
    {
        public double FinalBill(double amount)
        {
            return amount;
        }
    }
    public class HappyHourStrategy : IStrategy
    {
        public double FinalBill(double amount)
        {
            return amount * 0.8;
        }
    }
}
