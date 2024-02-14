using System;
using System.Collections.Generic;

namespace Task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task3 task = new Task3();
            task.RequestNumbers();
        }
    }

    class Task3
    {
        private HashSet<int> _testHash;

        public Task3()
        {
            _testHash =new HashSet<int>();
        }

        ~Task3()
        {
            
        }

        public void RequestNumbers()
        {
            int number;
            for (;;) {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if(!_testHash.Add(number))
                        Console.WriteLine("Number is already.");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}