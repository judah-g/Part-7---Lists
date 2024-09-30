using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part_7___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jman

            bool done = false, intDone = false, stringDone = false;
            string answer, intAnswer = null, stringAnswer;
            Random random = new Random();

            List<int> ints = new List<int>();

            while (!done)
            {
                Console.WriteLine("(I)ntegers or (S)trings?");
                answer = Console.ReadLine().ToLower();
                Console.Clear();

                if (answer == "i")
                {
                    for (int i = 0; i < 25; i++)
                    {
                        ints.Add(random.Next(10, 21));
                        if (i < 24)
                            Console.Write($"{ints[i]}, ");
                        else
                            Console.Write($"{ints[i]}\n");
                    }

                    while (!intDone)
                    {
                        if (intAnswer != null)
                        {
                            for (int i = 0; i < 25; i++)
                            {
                                if (i < 24)
                                    Console.Write($"{ints[i]}, ");
                                else
                                    Console.Write($"{ints[i]}\n");
                            }
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
                    }
                    ints.Clear();
                    intAnswer = null;
                }

                else if (answer == "s")
                {
                     
                }
            }
            Console.ReadLine();
        }
    }
}
