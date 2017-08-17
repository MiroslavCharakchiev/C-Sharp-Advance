using _01.Stream_Progress.Interfaces;

namespace _01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private ICustomStream file;

        public StreamProgressInfo(ICustomStream file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Lenght;
        }
    }
}