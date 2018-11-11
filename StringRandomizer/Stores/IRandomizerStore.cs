using System;

namespace StringRandomizer.Stores
{
    public interface IRandomizerStore
    {
        bool TryAdd(string key);
    }
}
