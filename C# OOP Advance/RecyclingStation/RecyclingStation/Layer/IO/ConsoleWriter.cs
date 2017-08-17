using System;
using System.Text;
using RecyclingStation.Layer.Contracts.IO;

namespace RecyclingStation.Layer.IO
{
    public class ConsoleWriter : IWriter
    {
        private StringBuilder outputGatherer;

        public ConsoleWriter()
            : this(new StringBuilder())
        {
        }

        public StringBuilder OutputGatherer {
            get { return this.outputGatherer; }
            set { this.outputGatherer = value; }
        }

        public ConsoleWriter(StringBuilder outputGatherer)
        {
            this.outputGatherer = outputGatherer;
        }

        public void GatherOutput(string outputGather)
        {
            OutputGatherer.AppendLine(outputGather);
        }

        public void WriteGatherOutput()
        {
            Console.Write(this.OutputGatherer);
        }
    }
}