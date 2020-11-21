using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditions
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
            bool isTrue = true;
            if (isTrue)
            {
                //--Do Something here
            }
            int age = 24;

            if ( age > 17)
            {
                Console.WriteLine("You're and adult");
            }
            else if (age >6)
            {
                Console.WriteLine("You're a kid");
            }
            else
            {
                Console.WriteLine("You're still a kid");
            }

            if (age > 65 && age < 18)
            {
                //-- and
            }
            if (age <= 65 || age >= 18)
            {
                //-- or
            }


           
        }
        [TestMethod]
        public void SwitchCases()
        {
            let age = 42;
            switch (age)
            {
                case 18:
                    //==code for if age is 
                    break;
                case 19:
                    break;
                case 21:
                case 22:
                case 22:
                    break; //--evaluates all 3

                default:
                    //--catch all code
                    Console.WriteLine("You are not 18-23");
                    break;
            }
        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 37;
            //--variable = (boolean statement) ? trueValue : falseValue;
            bool isAge = (age == 24) ? true : false;
        }
    }
}
