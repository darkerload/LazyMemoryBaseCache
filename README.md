## Lazy MemoryBase Cache

Quickly keeping via memory cache and provide lazy.

### Example :

```csharp
 //Default add way and keep until cache lifetime
 MemoryBaseCache.Instance.Add("testKey", 5);
 // You can pass parameter of timespan to keep limited
 MemoryBaseCache.Instance.Add("testKey2", "testValue", new TimeSpan(0, 2, 0));
 // For get
 var val = MemoryBaseCache.Instance.Get<string>("testKey2");
 ```
