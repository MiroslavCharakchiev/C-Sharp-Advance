using System;
using System.Collections.Generic;
using RecyclingStation.Layer.Core;
using RecyclingStation.Layer.Factories;
using RecyclingStation.Layer.IO;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation
{
    public class RecyclingStationMain
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var strategyHolder = new StrategyHolder(new Dictionary<Type, IGarbageDisposalStrategy>());
            var garbageProcesor = new GarbageProcessor(strategyHolder);
            var wasteFactory = new WasteFactory();
            var station = new RecyclingStattion(garbageProcesor,wasteFactory);

            var engine = new Engine(reader, writer, station);
            engine.Run();

        }
    }
}
