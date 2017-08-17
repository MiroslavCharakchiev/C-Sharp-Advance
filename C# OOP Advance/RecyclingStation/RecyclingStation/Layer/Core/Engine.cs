using System;
using System.Linq;
using System.Reflection;
using RecyclingStation.Layer.Contracts.Core;
using RecyclingStation.Layer.Contracts.IO;

namespace RecyclingStation.Layer.Core
{
    public class Engine : IEngine
    {
        private const string TerminateCommand = "TimeToRecycle";

        private readonly MethodInfo[] RecyclingStationMethods;
        private IReader reader;
        private IWriter writer;

        private IRecyclingStattion recyclingStation;

        public Engine(IReader reader, IWriter writer, IRecyclingStattion recyclingStation)
        {
            this.reader = reader;
            this.writer = writer;
            this.recyclingStation = recyclingStation;
            this.RecyclingStationMethods = this.recyclingStation.GetType().GetMethods();
        }

        public void Run()
        {
            string input;
            while ((input = this.reader.ReadLine()) != TerminateCommand)
            {
                var commandArgs = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var methodName = commandArgs[0];
                string[] methodNonParcedParams = null;
                if (commandArgs.Length > 1)
                {
                    methodNonParcedParams = commandArgs[1]
                        .Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                }

                MethodInfo methodToInvoke = this.RecyclingStationMethods.FirstOrDefault(m => m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase));

                ParameterInfo[] methodsParams = methodToInvoke.GetParameters();
                Object[] parsedParams = new object[methodsParams.Length];
                for (int i = 0; i < methodsParams.Length; i++)
                {
                    Type paramType = methodsParams[i].ParameterType;

                    parsedParams[i] = Convert.ChangeType(methodNonParcedParams[i], paramType);
                }
                object result = methodToInvoke.Invoke(this.recyclingStation, parsedParams);
                this.writer.GatherOutput(result.ToString());
            }
            this.writer.WriteGatherOutput();
        }
    }
}
