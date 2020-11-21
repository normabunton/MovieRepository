using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopsExamples
    {
        [TestMethod]
        public void ForLoops()
        {

            int studentCount = 15;
            //Starting Point fires off only once
            //Condition that while true, keeps the loop running
            //What happens after each loop
            //Body of the loop, what happens each iteration
            //for //1          //2           //3
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
