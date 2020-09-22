using System;
namespace Brainchild.Curriculum.Solutions
{
// Bicycle class with pedal and backpedal
// Pedal program 
// write test
// call pedal and check the value
// call pedal call again in test
// another method backpedal
// another class speedbicycle uses bicycle class
// speed should be double
    public class Bicycle
    {
        public int distance=0;
        public int Pedal()
        {
            distance+=1;
            return distance;
        }
        public int BackPedal()
        {
            distance-=1;
            return distance;
        }
    }
    public class SpeedBicycle:Bicycle
    {
        public int DoubleSpeedPedal()
        {
            distance=Pedal()+1;
            return distance;
        }
        public int DoubleSpeedBackPedal()
        {
            distance=BackPedal()-1;
            return distance;
        }
    }
}