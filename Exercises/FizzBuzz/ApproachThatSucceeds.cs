using System;
using Exercise.Toolkit;

namespace Exercise.FizzBuzz
{
    public class ApproachThatSucceeds
    {
        private IConsole _console;
        public ApproachThatSucceeds(IConsole console = null)
        {
            if (console == null)
                _console = new SystemConsole();
            else
                _console = console;
        }
        public void DoJob()
        {
            int lineCount = int.Parse(_console.ReadLine() ?? "1");
            int startNumber = -1, fizzPos = -1, buzzPos = -1, fizz = -1, buzz = -1;
            for (int i = 0; i < lineCount; i++)
            {
                var x = _console.ReadLine() ?? "";
                if (fizz < 0 && x.Contains("Fizz"))
                    if (fizzPos < 0) fizzPos = i;
                    else fizz = i - fizzPos;
                if (buzz < 0 && x.Contains("Buzz"))
                    if (buzzPos < 0) buzzPos = i;
                    else buzz = i - buzzPos;
                if (startNumber < 0 && int.TryParse(x, out var curNumber))
                    startNumber = curNumber - i;
            }
            _console.WriteLine((fizz > 0 ? fizz : fizzPos + startNumber).ToString() + " " + (buzz > 0 ? buzz : buzzPos + startNumber).ToString());
        }
    }
}
