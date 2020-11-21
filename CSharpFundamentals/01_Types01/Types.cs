using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types01
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            //Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            //Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.237909d;
            decimal decimalExample = 1.77000m;

            char letter = 'j';

            //Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            int prd = numOne * numTwo;
            int quot = numOne / numTwo;
            int remainder = numOne % numTwo;

            Console.WriteLine("Hello");

        }
        [TestMethod]
        public void ReferenceTypes()
        {
            char cpace = ' ';
            //Strings
            string stringExample = "This is a string";
            string name = "John";

            string declared;
            declared = "Now it's initialized.";
            //formatting strings
            string concatenate = stringExample + name; // This string.John

            string interpolate = $"{name}. Here is the string: {stringExample}";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);


        }
    }
}
