using System;
using System.Collections.Generic;

namespace StringRandomizer.Stores
{
    /// <summary>
    /// Default randomizer store.
    /// </summary>
    public class DefaultRandomizerStore : IRandomizerStore
    {
        HashSet<string> _store;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringRandomizer.Stores.DefaultRandomizerStore"/> class.
        /// </summary>
        public DefaultRandomizerStore()
        {
            _store = new HashSet<string>();
        }

        /// <summary>
        /// Checks if key exisit in store, if not adds it 
        /// </summary>
        /// <returns><c>true</c>, if add was tryed, <c>false</c> otherwise.</returns>
        /// <param name="key">Key.</param>
        public bool TryAdd(string key)
        {
            lock (_store)
            {
               return _store.Add(key);
            }
        }
    }
}
