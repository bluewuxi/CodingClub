using System;
using System.Net;
using Exercise.Toolkit;

namespace Exercise.ComputerProblem
{
    public class ApproachTestable
    {
        private IConsole _console;
        public ApproachTestable(IConsole console = null)
        {
            if (console == null)
                _console = new SystemConsole();
            else
                _console = console;
        }
        public void DoJob()
        {
            // TODO: Put your answer code here
            var input = _console.ReadLine();
            _console.WriteLine("");
        }
    }
}