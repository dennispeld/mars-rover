using System;

namespace MarsRover
{
    internal static class Program
    {
        private const string Input = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

        private static void Main()
        {
            var reader = new InputReader(Input);

            Console.ReadLine();
        }
    }
}