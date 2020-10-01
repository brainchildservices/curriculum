using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
using System;
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
        public void CheckingGenericClassStringStack()
        {
            Stack<string> stringstack = new Stack<string>();
            stringstack.Push("abc");
            stringstack.Push("abcd");
            stringstack.Push("abcde");
            string popped = stringstack.Pop();
            string[] actual = stringstack.Output();
            string[] expecting = new string[1000];
            expecting[0] = "abc";
            expecting[1] = "abcd";
            Assert.AreEqual(actual, expecting);
            Assert.AreEqual(popped, "abcde");
        }
        [Test]
        public void CheckingGenericClassIntStack()
        {
            Stack<int> intstack = new Stack<int>();
            intstack.Push(5);
            intstack.Push(7);
            intstack.Push(88);
            int popped = intstack.Pop();
            int[] actual = intstack.Output();
            int[] expecting = new int[1000];
            expecting[0] = 5;
            expecting[1] = 7;
            Assert.AreEqual(actual, expecting);
            Assert.AreEqual(popped, 88);

        }
        [Test]
        public void CheckingGenericClassDoubleStack()
        {
            Stack<double> doublestack = new Stack<double>();
            doublestack.Push(5.8);
            doublestack.Push(9.6);
            doublestack.Push(88.55);
            double popped = doublestack.Pop();
            double[] actual = doublestack.Output();
            double[] expecting = new double[1000];
            expecting[0] = 5.8;
            expecting[1] = 9.6;
            Assert.AreEqual(actual, expecting);
            Assert.AreEqual(popped, 88.55);
        }


    }
}