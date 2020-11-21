using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types01
{
    [TestClass]
    public class inclassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            int age = 32;

            byte someByte = 23;

            int anotherNumer = 23;

            anotherNumer = 256;

            double someDouble = 23.32164d;
            float someFloat = 23.3422222f;
            decimal someDecimal = 23.4522211m;

            char letter = 'm';
            bool trueOrFalseValue = true;

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string randomCharacters = "alkd jfgh455#$%";
            string specialCharacters = "\"Michael\"";
            string otherSpecialCharacters = "\n"; //line return
            Console.WriteLine("specialCharacters");

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            DateTime today = DateTime.Today;
            Console.WriteLine(rightNow);

            TimeSpan age = DateTime.Now - new DateTime(1988, 04, 11);
            Console.WriteLine(age);

            string[] names = { "Casey"," Michael", "Simon" };
            List<string> fruits = new List<string>();

            fruits.Add("grape");
            fruits.Add("apple");

            Dictionary<char, double> dictionary = new Dictionary<char, double>();
            dictionary.Add('x', 3.1459);
            dictionary['x'] = 32422.23; //changes the value in the key value pair


            Console.WriteLine(fruits[1]);
            Console.WriteLine(dictionary['x']);
            
        }
    }
}
