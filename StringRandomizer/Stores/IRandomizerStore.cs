using System;

namespace StringRandomizer.Stores
{
    /// <summary>
    /// Randomizer store.
    /// </summary>
    public interface IRandomizerStore
    {
        /// <summary>
        /// Checks if key exisit in store, if not adds it 
        /// </summary>
        /// <returns><c>true</c>, if add was tryed, <c>false</c> otherwise.</returns>
        /// <param name="key">Key.</param>
        bool TryAdd(string key);
    }
}
