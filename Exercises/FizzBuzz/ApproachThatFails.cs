using System;
using Exercise.Toolkit;

namespace Exercise.FizzBuzz
{
    public class ApproachThatFails
    {
        private IConsole _console;
        public ApproachThatFails(IConsole console = null)
        {
            if (console == null)
                _console = new SystemConsole();
            else
                _console = console;
        }
        public void DoJob()
        {
            // Copy script in this method to main function of program class:
            int FizzCount = 0;
            int BuzzCount = 0;
            bool FirstFizz = false;
            bool FirstBuzz = false;
            bool FinishedFizz = false;
            bool FinishedBuzz = false;
            int Fizz = 0;
            int Buzz = 0;

            int lineCount = int.Parse(_console.ReadLine());
            for (int i = 1; i <= lineCount; i++)
            {
                var input = _console.ReadLine();
                if (input.Contains("Fizz"))
                {
                    if (FirstFizz && !FinishedFizz)
                    {
                        Fizz = FizzCount + 1;
                        FizzCount = 0;
                        FinishedFizz = true;
                    }
                    else
                    {
                        FirstFizz = true;
                    }
                }
                else
                {
                    FizzCount++;
                }
                if (input.Contains("Buzz"))
                {
                    if (FirstBuzz && !FinishedBuzz)
                    {
                        Buzz = BuzzCount + 1;
                        BuzzCount = 0;
                        FinishedBuzz = true;
                    }
                    else
                    {
                        FirstBuzz = true;
                    }
                }
                else
                {
                    BuzzCount++;
                }
            }
            _console.WriteLine(Fizz.ToString() + " " + Buzz.ToString());
        }
    }
}