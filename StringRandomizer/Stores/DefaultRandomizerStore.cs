using System;
using System.Collections.Generic;

namespace StringRandomizer.Stores
{
    public class DefaultRandomizerStore : IRandomizerStore
    {
        List<string> _store;

        public DefaultRandomizerStore()
        {
            _store = new List<string>();
        }

        public bool TryAdd(string key)
        {
            lock (_store)
            {
                if (_store.Contains(key))
                    return false;

                _store.Add(key);
                return true;
            }
        }
    }
}
