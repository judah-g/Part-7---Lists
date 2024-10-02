using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part_7___Lists
{
    internal class Program
    {
        public static int MaxIndex(List<int> list)
        {
            //didn't know how to do this and this is what google gave me
            int indexMax
            = !list.Any() ? -1 :
            list
            .Select((value, index) => new { Value = value, Index = index })
            .Aggregate((a, b) => (a.Value > b.Value) ? a : b)
            .Index;
            return indexMax;
        }

        static void Main(string[] args)
        {
            //jman

            bool done = false, intDone = false, stringDone = false;
            string answer, intAnswer = null, stringAnswer;
            Random random = new Random();

            int numberHelper, counter;
            List<int> ints = new List<int>(), dupeCount = new List<int>(), dupeCountHelper = new List<int>();

            List<string> vegetables = new List<string>();

            while (!done)
            {
                Console.WriteLine("(I)ntegers, (S)trings or (Q)uit?");
                answer = Console.ReadLine().ToLower();
                Console.Clear();

                if (answer == "i")
                {
                    for (int i = 0; i < 25; i++)
                    {
                        ints.Add(random.Next(10, 21));
                    }

                    while (!intDone)
                    {
                        for (int i = 0; i < ints.Count; i++)
                        {
                            if (i < (ints.Count - 1))
                                Console.Write($"{ints[i]}, ");
                            else
                                Console.Write($"{ints[i]}\n");
                        }
                        Console.WriteLine();
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1 - Sort the list\n2 - Make a new list\n3 - Remove a number\n4 - Add a value" +
                            "\n5 - Count the occurances\n6 - Print the largest value\n7 - Print the smallest value\n" +
                            "8 - Print sum and average\n9 - Most frequent number\n10 - Quit");

                        intAnswer = Console.ReadLine();
                        Console.Clear();

                        if (intAnswer == "1")
                        { ints.Sort(); }

                        else if (intAnswer == "2")
                        {
                            ints.Clear();
                            for (int i = 0; i < 25; i++)
                                ints.Add(random.Next(10, 21));
                        }

                        else if (intAnswer == "3")
                        {
                            Console.WriteLine("What number would you like to remove?");
                            while (!int.TryParse(Console.ReadLine(), out numberHelper) && !ints.Contains(numberHelper))
                                Console.WriteLine("Your list does not have that");
                            Console.Clear();


                            for (int i = 0; i < ints.Count(); i++)
                                if (ints[i] == numberHelper)
                                { ints.RemoveAt(i); i--; }
                        }

                        else if (intAnswer == "4")
                        {
                            Console.WriteLine("What number would you like to add?");
                            while (!int.TryParse(Console.ReadLine(), out numberHelper))
                                Console.WriteLine("You can't add that");
                            Console.Clear();

                            ints.Add((int)numberHelper);
                        }

                        else if (intAnswer == "5")
                        {
                            Console.WriteLine("What number would you like to count?");
                            while (!int.TryParse(Console.ReadLine(), out numberHelper) && !ints.Contains(numberHelper))
                                Console.WriteLine("Your list does not have that");
                            Console.Clear();

                            counter = 0;
                            for (int i = 0; i < ints.Count(); i++)
                                if (ints[i] == numberHelper)
                                { counter++; }

                            Console.WriteLine($"There are {counter} {numberHelper}'s in your list.\n");
                        }

                        else if (intAnswer == "6")
                        {
                            Console.WriteLine($"Your highest number is {ints.Max()}.\n");
                        }

                        else if (intAnswer == "7")
                        {
                            Console.WriteLine($"Your lowest number is {ints.Min()}.\n");
                        }

                        else if (intAnswer == "8")
                        {
                            numberHelper = 0;
                            for (int i = 0; i < ints.Count; i++)
                                numberHelper += ints[i];

                            Console.WriteLine($"The sum is {numberHelper} and the average is {ints.Average()}.\n");
                        }

                        else if (intAnswer == "9")
                        {

                            for (int j = ints.Min(); j < ints.Max(); j++)
                            {
                                if (ints.Contains(j))
                                {
                                    counter = 0;
                                    for (int i = 0; i < ints.Count(); i++)
                                        if (ints[i] == j)
                                            counter++;
                                    dupeCount.Add(counter);
                                    dupeCountHelper.Add(j);
                                }

                            }

                            Console.WriteLine($"Your most frequently occuring numbers are your " +
                                $"{dupeCount[MaxIndex(dupeCount)]} {dupeCountHelper[MaxIndex(dupeCount)]}'s.\n");

                        }

                        else if (intAnswer == "10")
                            intDone = true;

                    }
                    ints.Clear();
                    intAnswer = null;
                }

                else if (answer == "s")
                {
                    vegetables.Add("BROCCOLI"); vegetables.Add("BEET"); vegetables.Add("CARROT"); vegetables.Add("RADISH"); vegetables.Add("CABBAGE");
                    while (!stringDone)
                    {
                        Console.WriteLine("Vegetables\n");
                        for (int i = 0; i < vegetables.Count; i++)
                            Console.WriteLine($"{i} - {vegetables[i]}");

                        Console.WriteLine();
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1 - Remove by index\n2 - Remove by value\n3 - Search for a veggie\n" +
                            "4 - Add a veggie\n5 - Sort list\n6 - Quit");

                        stringAnswer = Console.ReadLine();
                        Console.Clear();


                    }
                }

                else if (answer == "q")
                    done = true;
            }
            Console.ReadLine();
        }
    }
}
