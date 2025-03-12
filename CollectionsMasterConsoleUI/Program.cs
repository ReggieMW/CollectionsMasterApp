using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            //TODO: Create an integer Array of size 50

            int[] players = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(players);

            //TODO: Print the first number of the array
            Console.WriteLine($"{players[0]}");

            //TODO: Print the last number of the array
            Console.WriteLine($"{players.Length - 1}");

            Console.WriteLine("All Numbers Original");
            NumberPrinter(players);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____();
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Array.Reverse(players);
            foreach (int player in players)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(players);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(players);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            Console.WriteLine("Sorted numbers:");
            Array.Sort(players);
            NumberPrinter(players);

            Console.WriteLine("\n************End Arrays*************** \n");

            #endregion

            #region Lists

            Console.WriteLine("************Start Lists**************");

            //TODO: Create an integer List
            List<int> retiredPlayers = new List<int>(8);

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(retiredPlayers.Count);


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(retiredPlayers);
            NumberPrinter(retiredPlayers);

            //TODO: Print the new capacity
            Console.WriteLine(retiredPlayers.Count);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int userInput = int.Parse(Console.ReadLine());
            NumberChecker(retiredPlayers, userInput);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(retiredPlayers);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(retiredPlayers);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            retiredPlayers.Sort();
            for (int i = 0; i < retiredPlayers.Count; i++)
            {
                if (i % 2 != 0)
                    retiredPlayers.Remove(retiredPlayers[i]);
            }
            NumberPrinter(retiredPlayers);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            retiredPlayers.ToArray();
            

            //TODO: Clear the list
            retiredPlayers.Clear();
            
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (int number in numbers)
            {
                int threeDividend = 0;
                if (number % 3 == 0)
                {
                    threeDividend = 0;
                }
                else
                {
                    threeDividend = number;
                }

                Console.WriteLine(threeDividend);
            }
        }


        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 != 0)
                {
                    numberList.Remove(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if ((numberList.Contains(searchNumber)))
            {
                Console.WriteLine($"{searchNumber} is retired");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not a retired number.");
            }
        }

        private static void Populater(List<int> numberList)
            {
                Random rng = new Random();
                int newPlayer = 0;
                for (int i = 1; i < 51; i++)
                {
                    newPlayer = rng.Next(0, 50);
                    numberList.Add(newPlayer);
                }
            }

            private static void Populater(int[] numbers)
            {
                Random rng = new Random();
                for (int number = 0; number < numbers.Length; number++)
                {
                    numbers[number] = rng.Next(50);
                }

                NumberPrinter(numbers);
            }

            private static void ReverseArray(int[] array)
            {
                for (int player = 50; player >= 0; player--)
                {
                    Console.WriteLine(player);
                }
            }

            /// <summary>
            /// Generic print method will iterate over any collection that implements IEnumerable<T>
            /// </summary>
            /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
            /// <param name="collection"></param>
            private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
            {
                //STAY OUT DO NOT MODIFY!!
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }