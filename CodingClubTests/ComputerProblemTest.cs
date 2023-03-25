using System;
using Exercies;
using Exercise.Toolkit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Reference the namespace of the to-be-tested Class
using Exercise.ComputerProblem;

namespace CodingClub.Tests
{
    [TestClass]
    public class ComputerProblemTest
    {

        [DataTestMethod]
        // Important: testConsole split the inputed string using "," to mock multiple line feeding for console.ReadLine
        // If your input include "," as content, you may need to give a spliter string to the TestableConsole constructor.
         // Given example 1
        [DataRow("3 100000007", "6")]
        // Given example 2
        [DataRow("4 100000007", "20")]
        // Given example 3
        [DataRow("400 234567899", "20914007")]
        public void Test1DataSet(string input, string expected)
        {
            var testConsole = new TestableConsole(input);
            var worker = new ApproachTestable(testConsole);

            worker.DoJob();

            Assert.AreEqual(expected, testConsole.output);
        }
    }
}
