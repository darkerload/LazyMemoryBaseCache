using System;
using System.Collections.Generic;
using System.Text;

namespace LazyMemoryBaseCache.Infrastructure
{
    public interface IMemoryBaseCache
    {
        void Add<T>(string key, T value, TimeSpan? cachingInterval = null);
        void Remove(string key);
        T Get<T>(string key);
        List<string> GetAllKeys();
    }
}
