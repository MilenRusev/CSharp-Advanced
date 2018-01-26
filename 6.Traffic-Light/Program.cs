using System;
using System.Collections.Generic;

namespace TrafficLight
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var carsCanPass = int.Parse(Console.ReadLine());
            var cars = Console.ReadLine();
            var queue = new Queue<string>();
            int counter = 0;
            while (cars != "end")
            {
               
                if (cars == "green")
                {
                    for (int i = 0; i < carsCanPass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
					queue.Enqueue(cars);
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
