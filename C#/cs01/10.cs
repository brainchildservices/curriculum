using System;
namespace Brainchild.Curriculum.Solutions
{
// Bicycle class with pedal and backpedal
// Pedal program 
// write test
// call pedal and check the value
// call pedal call again in test
// another method backpedal
// another class DoubleSpeededBicycle uses bicycle class
// speed should be double
    public class Bicycle
    {
        public double speed=0;
        public virtual double Pedal()
        {
            speed+=1;

            return speed;
        }
        public virtual double BackPedal()
        {
            speed-=1;
            return speed;
        }
    }
    public class DoubleSpeededBicycle:Bicycle
    {
        public override double Pedal()
        {
            if(speed==0)
            {
                speed=2*base.Pedal();
            } else 
            {
            speed=2*(base.Pedal()-1);
            }
            return speed;
        }
        public override double BackPedal()
        {
            
            speed=base.BackPedal()-1;
            return speed;
        }
    }
}