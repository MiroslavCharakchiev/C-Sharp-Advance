using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vihicles
{
    class StartUp
    {
      public static void Main()
      {
          var carInput = Console.ReadLine().Split();
          var truckInput = Console.ReadLine().Split();
          var busInput = Console.ReadLine().Split();

            var car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
            var truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));
            var bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));
          var lines = int.Parse(Console.ReadLine());

          for (int i = 0; i < lines; i++)
          {
              var line = Console.ReadLine().Split();
              var comand = line[0] + line[1];
              var kilometersOrLiters = double.Parse(line[2]);
              switch (comand)
              {
                    case "DriveCar":
                        car.Drive(kilometersOrLiters);
                        break;
                  case "RefuelCar":
                      car.Refuel(kilometersOrLiters);
                      break;
                  case "DriveTruck":
                      truck.Drive(kilometersOrLiters);
                      break;
                  case "RefuelTruck":
                      truck.Refuel(kilometersOrLiters);
                      break;
                  case "RefuelBus":
                      bus.Refuel(kilometersOrLiters);
                      break;
                  case "DriveEmptyBus":
                      bus.BusStatus(kilometersOrLiters, "empty");
                      break;
                  case "DriveBus":
                      bus.BusStatus(kilometersOrLiters, "notEmpty");
                      break;
                }
          }
          Console.WriteLine(car);
          Console.WriteLine(truck);
          Console.WriteLine(bus);
      }
    }
}
