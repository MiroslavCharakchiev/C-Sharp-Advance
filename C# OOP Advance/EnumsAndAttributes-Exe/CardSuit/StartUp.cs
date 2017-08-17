using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services.Description;

namespace CardSuit
{
    public class StartUp
    {
        public static void Main()
        {
            Task8();
        }

        private static void Task8()
        {
            var firstPlayer = Console.ReadLine();
            var secondPlayer = Console.ReadLine();

            var deck = new List<Card>();
            var firstDeck = new List<Card>();
            var secondDeck = new List<Card>();
            

            while (firstDeck.Count < 5 || secondDeck.Count < 5)
            {
                var input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var card = new Card(input[0], input[2]);
                    if (!deck.Contains(card))
                    {
                        deck.Add(card);
                        if (firstDeck.Count < 5)
                        {
                            firstDeck.Add(card);
                        }
                        else
                        {
                            secondDeck.Add(card);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("No such card exists.");
                }
               
            }
            var firstMaxCard = firstDeck.Max();
            var secondMaxCard = secondDeck.Max();
            if (firstMaxCard.Power >= secondMaxCard.Power)
            {
                Console.WriteLine($"{firstPlayer} wins with {firstMaxCard}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer} wins with {secondMaxCard}.");
            }


        }

        private static void Task7()
        {
            var input = Console.ReadLine();
           var deck = new List<Card>();
            foreach (var suit in Enum.GetNames(typeof(Suits)))
            {
                foreach (var rank in Enum.GetNames(typeof(Deck)))
                {
                    deck.Add(new Card(rank , suit));
                }
            }

            foreach (var card in deck)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }

        private static void Task6()
        {
            var input = Console.ReadLine();
            if (input == "Rank")
            {
                Task6(typeof(Deck));
            }
            else
            {
                Task6(typeof(Suits));
            }
        }

        private static void Task6(Type type)
        {
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }

        private static void Task5()
        {
            var listOfCards = new List<Card>();

            for (int index = 0; index < 2; index++)
            {
                var rank = Console.ReadLine();
                var suit = Console.ReadLine();

                var card = new Card(rank, suit);

                listOfCards.Add(card);
            }
            if (listOfCards[0].CompareTo(listOfCards[1]) > 0)
            {
                Console.WriteLine(listOfCards[0]);
            }
            else
            {
                Console.WriteLine(listOfCards[1]);
            }
        }

        private static void Task3and4()
        {
            var rank = Console.ReadLine();
            var suit = Console.ReadLine();

            var card = new Card(rank, suit);

            Console.WriteLine(card);
        }

        private static void Task2()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input + ":");
            foreach (var value in Enum.GetValues(typeof(Deck)))
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }

        private static void Task1()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input + ":");
            foreach (var value in Enum.GetValues(typeof(Suits)))
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}