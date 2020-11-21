using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals01
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
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (true)
            {
                //Do something here
            }
            int age = 12;
            if (age > 17)
            {
                Console.WriteLine("Youre an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("Youre still a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You are far too young to be a computer");

            }
            else
            {
                Console.WriteLine("You are not even born yet");
            }
            if (age > 65 && age < 18)
            {
                //and comparison
            }
            if (age <= 65 || age >= 18)
            {
                //or comparison
            }
            if (age == 17)
            {
                //equal to 
            }
            if (age != 19)
            {
                //not equal  //! bang operator
            }


        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    //code for if age is 18
                    break;
                case 19:
                    break;
                case 21:
                case 22:
                case 23:
                    break;
                default:
                    //catch all code
                    Console.WriteLine("You are not 18-23");
                    break;
            }

        } 

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;
            //variable bool someVariable = (boolean statement) ? Treuvalue : falseValue;

            bool isAge = (age == 24) ? true : false;
        }
        

        }
    }

