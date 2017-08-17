using System.Runtime.InteropServices.ComTypes;
using _01.Stream_Progress.Interfaces;

namespace _01.Stream_Progress
{
    public abstract class CustomStream : ICustomStream
    {
        protected CustomStream(int lenght, int bytesSent)
        {
            this.Lenght = lenght;
            this.BytesSent = bytesSent;
        }
        public int Lenght { get; }
        public int BytesSent { get; }
    }
}