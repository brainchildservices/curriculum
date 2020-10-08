using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test13
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void IntStack()
        {
            StackPushPop<int> myStack = new StackPushPop<int>();
            myStack.Push(5);
            myStack.Push(10);
            myStack.Push(15);
            myStack.Push(20);
            int lastValue = myStack.Pop();
            Assert.AreEqual(lastValue, 20);
            int[] expected = new int[1000];
            expected[0] = 5;
            expected[1] = 10;
            expected[2] = 15;
            int[] result = myStack.PrintStack();
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void StringStack()
        {
            StackPushPop<string> myStack = new StackPushPop<string>();
            myStack.Push("Aneesh");
            myStack.Push("Sreerag");
            myStack.Push("Rohith");
            myStack.Push("Ardra");
            string lastValue = myStack.Pop();
            lastValue = myStack.Pop();
            Assert.AreEqual(lastValue, "Rohith");
            string[] expected = new string[1000];
            expected[0] = "Aneesh";
            expected[1] = "Sreerag";
            // expected[2]="Rohith";
            string[] result = myStack.PrintStack();
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void FloatStack()
        {
            StackPushPop<float> myStack = new StackPushPop<float>();
            myStack.Push(5.0f);
            myStack.Push(10.1f);
            myStack.Push(15.5f);
            myStack.Push(20.7f);
            float lastValue = myStack.Pop();
            lastValue = myStack.Pop();
            //lastValue = myStack.Pop();
            Assert.AreEqual(lastValue, 15.5f);
            float[] expected = new float[1000];
            expected[0] = 5.0f;
            expected[1] = 10.1f;
            float[] result = myStack.PrintStack();
            Assert.AreEqual(result, expected);
        }
    }
}