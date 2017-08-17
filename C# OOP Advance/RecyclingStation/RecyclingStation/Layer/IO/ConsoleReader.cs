using System;
using RecyclingStation.Layer.Contracts.IO;

namespace RecyclingStation.Layer.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}