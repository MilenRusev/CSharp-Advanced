using System;
using System.Linq;
using System.Collections.Generic;

namespace asicQueueOperations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var elementsToPush = indexes[0];
            var elementsToRemove = indexes[1];
            var elemetToSearch = (indexes[2]);

            var input = Console.ReadLine().Split();
            var queue = new Queue<string>();

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int k = 0; k < elementsToRemove; k++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(elemetToSearch.ToString()))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
            }
        }
    }
}
