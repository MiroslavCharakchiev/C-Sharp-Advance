namespace RecyclingStation.Layer.Contracts.IO
{
    public interface IWriter
    {
        void GatherOutput(string outputGather);

        void WriteGatherOutput();

    }
}