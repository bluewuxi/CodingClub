using System;

namespace Exercise.Toolkit
{
    public interface IConsole {
        string ReadLine();
        void WriteLine(string output);
    }

    public interface IDoJob {
        void DoJob();
    }

    public class TestableConsole: IConsole {
        public string output = "";
        private string[] _input;
        private int _cursor=0;

        // initInput string is a comma seperated text, e.g. "5,1,2,Fizz,Fuzz,5"
        public TestableConsole(string initInput)
        {
            _input = initInput.Split(",");
        }
        public void WriteLine(string line){
            output += line;
        }
        public string ReadLine(){
            if (_cursor>=_input.Length) return null; 
            return _input[_cursor++];
        }
    }

    public class SystemConsole: IConsole {

        public SystemConsole()
        {
        }
        public void WriteLine(string line){
            Console.Write(line);
        }
        public string ReadLine(){
            return Console.ReadLine();
        }
    }


}