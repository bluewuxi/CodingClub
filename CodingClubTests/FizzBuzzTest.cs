using System;
using Exercies;
using Exercise.Toolkit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Reference the namespace of the to-be-tested Class
using Exercise.FizzBuzz;

namespace CodingClub.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        // Test the given example
        public void TestApproachThatFailsGivenExample()
        {
            var expected = "3 5";
            var testConsole = new TestableConsole("15,1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz");
            var worker = new ApproachThatFails(testConsole);
            worker.DoJob();
            Assert.AreEqual(expected, testConsole.output);
         }

        [DataTestMethod]
        // Important: testConsole split the inputed string using "," to mock multiple line feeding for console.ReadLine
        // If your input include "," as content, you may need to give a spliter string to the TestableConsole constructor.
        // Given example
        [DataRow("15,1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz", "3 5")]
        // Not start with 1
        [DataRow("15,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16", "3 5")]
        // Buzz appears only once
        [DataRow("15,2,Fizz,4,5,Fizz,7,8,Fizz,10,11,Fizz,13,14,FizzBuzz,16", "3 15")]

        public void TestApproachThatFailsUsingDataSet(string input, string expected)
        {
            var testConsole = new TestableConsole(input);
            var worker = new ApproachThatFails(testConsole);
            worker.DoJob();
            Assert.AreEqual(expected, testConsole.output);
        }
        [TestMethod]
        public void TestApproachThatSucceedsGivenExample()
        {
            var expected = "3 5";
            var testConsole = new TestableConsole("15,1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz");
            var worker = new ApproachThatSucceeds(testConsole);
            worker.DoJob();
            Assert.AreEqual(expected, testConsole.output );
        }

        [DataTestMethod]
        // Given example
        [DataRow("15,1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz", "3 5")]
        // Not start with 1
        [DataRow("15,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16", "3 5")]
        // Buzz appears only once
        [DataRow("15,2,Fizz,4,5,Fizz,7,8,Fizz,10,11,Fizz,13,14,FizzBuzz,16", "3 15")]

        public void TestApproachThatSucceedsUsingDataSet(string input, string expected)
        {
            var testConsole = new TestableConsole(input);
            var worker = new ApproachThatSucceeds(testConsole);
            worker.DoJob();
            Assert.AreEqual(expected, testConsole.output );
        }
    }
}
