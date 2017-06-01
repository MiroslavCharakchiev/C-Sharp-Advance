
namespace task13
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class SrubskoUnleash
    {
       public static void Main()
        {
            string line = Console.ReadLine();
            var concertsInfo = new Dictionary<string, Dictionary<string, long>>();

            long sum = 0;

            while (line != "End")
            {
                if (line.Contains("@"))
                {
                    string[] inputArgs = line.Split('@');

                    if (inputArgs[0].Last() == ' ')
                    {
                        string singer = inputArgs[0].Trim();
                        string venue = string.Empty;
                        string[] venueAndPrices = inputArgs[1].Split(' ');

                        if (venueAndPrices.Length >= 3)
                        {
                            if (venueAndPrices.Length == 3)
                            {
                                venue = venueAndPrices[0];
                            }
                            else if (venueAndPrices.Length == 4)
                            {
                                venue = venueAndPrices[0] + " " + venueAndPrices[1];
                            }
                            else if (venueAndPrices.Length > 4)
                            {
                                venue = venueAndPrices[0] + " " + venueAndPrices[1] + " " + venueAndPrices[2];
                            }

                            long ticketPrice;
                            long ticketCount;

                            bool isPriceDigit = long.TryParse(venueAndPrices[venueAndPrices.Length - 2], out ticketPrice);
                            bool isCountDigit = long.TryParse(venueAndPrices.Last(), out ticketCount);

                            if (isCountDigit && isPriceDigit)
                            {
                                sum = ticketCount * ticketPrice;

                                if (!concertsInfo.ContainsKey(venue))
                                {
                                    concertsInfo.Add(venue, new Dictionary<string, long>());
                                }

                                if (!concertsInfo[venue].ContainsKey(singer))
                                {
                                    concertsInfo[venue].Add(singer, 0);
                                }

                                concertsInfo[venue][singer] += sum;
                            }
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var item in concertsInfo)
            {
                Console.WriteLine(item.Key);

                foreach (var singer in item.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
