using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 10 10 10 10
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                actions.Add(() => Console.WriteLine(count));

            }
            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
