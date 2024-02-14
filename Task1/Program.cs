using System;
using System.Collections.Generic;

namespace Work8_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task1 test = new Task1();
            test.StartTask();
        }
    }

    class Task1
    {
        private List<int> _integersList;

        public Task1()
        {
        }

        ~Task1()
        {
        }

        public void StartTask()
        {
            CreateRandomIntegersList(100, 0,100);
            ShowList();
            RemoveValuesBetween(50, 25);
            ShowList();
        }

        private void CreateRandomIntegersList(uint length, int minValue, int maxValue)
        {
            _integersList = new List<int>();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            for (int  i = 0; i < length; i++)
            {
                _integersList.Add(rand.Next(minValue, maxValue + 1));
            }
        }

        private void ShowList()
        {
            _integersList.ForEach(value => Console.Write($" {value}"));
            Console.Write("\n");
        }

        private void RemoveValuesBetween(int minValue, int maxValue)
        {
            _integersList.RemoveAll(value => (value > minValue && value < maxValue));
        }
    }
}