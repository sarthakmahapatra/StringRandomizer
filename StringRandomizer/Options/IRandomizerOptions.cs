using System;
namespace StringRandomizer.Options
{
    public interface IRandomizerOptions
    {
        bool HasNumbers { get; }

        bool HasLowerAlphabets { get; }

        bool HasUpperAlphabets { get; }
    }
}
