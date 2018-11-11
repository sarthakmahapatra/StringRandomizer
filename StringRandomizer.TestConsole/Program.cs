using System;

namespace StringRandomizer.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();

            int i = 0;

            while (i < 10000)
            {
                var time = DateTime.Now;

                Console.WriteLine(randomizer.Next());

                Console.WriteLine(DateTime.Now.Subtract(time).Milliseconds + " ms");
                Console.WriteLine();
                i++;
            }

            Console.Read();
        }
    }
}
