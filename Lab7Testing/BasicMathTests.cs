using Lab7;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Lab7Testing
{
    public class Tests
    {
        private BasicMath MathTest;
        [SetUp]
        //create new instance of the class
        public void Setup()
        {
            MathTest = new BasicMath();
        }

        [Test]
        //to check the addition method
        public void AdditionTest()
        {
            //Assign
            double a = 5;
            double b = 10;
            double expected = 15;
            //Act
            double result = MathTest.Addition(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        //check the subtracrtion method 
        public void SubtractionTest()
        {
            //Assign
            double a = 20;
            double b = 5;
            double expected = 15;
            //Act
            double result = MathTest.Subtraction(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        //check the multiplication method
        public void MultiplicationTest()
        {
            //Assign
            double a = 2;
            double b = 5;
            double expected = 10;
            //Act
            double result = MathTest.Multiplication(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        //check the division method
        public void DivisionTest()
        {
            //Assign
            double a = 20;
            double b = 10;
            double expected = 2;
            //Act
            double result = MathTest.Division(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        //test to see if the right exception is thrown when dividing by 0
        public void ZeroDivionTest()
        {
            //Assign
            double a = 20;
            double b = 0;
            //Act
            //Assert
            Assert.Throws<ArgumentException>(()=>MathTest.Division(a,b));
        }
    }
}