using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;

        }
        [TestMethod]
        public void IfElseStatement()
        {
            bool isTrue = false;
            if (true)
            {
                //Do something here
            }
            int age = 24;
            if ( age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid");
            }
            else
            {
                Console.WriteLine("You're not even born yet");
            }

            if (age > 65 && age < 18)
            {

            }
            if (age <= || age >= 18)
            {

            }
            if (age == 17)
            {

            }
            if (age != 19)
            {

            }

        }
    }
}
