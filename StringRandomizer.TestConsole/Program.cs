using System;
using StringRandomizer.Options;
using StringRandomizer.Stores;

namespace StringRandomizer.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomizer = new Randomizer(4, new DefaultRandomizerOptions(hasNumbers: true, hasLowerAlphabets: true, hasUpperAlphabets: false),  new DefaultRandomizerStore());

            int i = 0;

            while (i < 10000)
            {
                Console.WriteLine(randomizer.Next());  
                i++;
            }

            Console.Read();
        }
    }
}
