using LazyMemoryBaseCache.Infrastructure;
using System;

namespace LazyMemoryBaseCache
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryBaseCache.Instance.Add("testKey", 5);
            var value1 = MemoryBaseCache.Instance.Get<int>("testKey");

            MemoryBaseCache.Instance.Add("testKey2", "testValue", new TimeSpan(0, 2, 0));
            var value2 = MemoryBaseCache.Instance.Get<string>("testKey2");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.Read();
        }
    }
}
