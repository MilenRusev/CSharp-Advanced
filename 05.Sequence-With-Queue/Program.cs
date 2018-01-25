using System;
using System.Collections.Generic;

namespace SequenceWithQueue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var resultQueue = new Queue<long>();

            Console.Write($"{n} ");
            resultQueue.Enqueue(n);

            var count = 1;

            while (count < 50)
            {
                n = resultQueue.Dequeue();
                Console.Write($"{n + 1} ");
                resultQueue.Enqueue(n+1);
                count++;
                if (count < 50)
                {
                    Console.Write($"{2*n + 1} ");
                    resultQueue.Enqueue(2 * n + 1);
                    count++;
                }
                else
                {
                    break;
                }
                if (count < 50)
                {
                    Console.Write($"{n + 2} ");
                    resultQueue.Enqueue(n + 2);
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
