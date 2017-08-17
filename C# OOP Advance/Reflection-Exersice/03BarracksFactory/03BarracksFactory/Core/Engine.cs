using _03BarracksFactory.Core.Commands;

namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private CommandInterpreter interpreter;

        public Engine(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string result = this.interpreter.InputSplit(input);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
