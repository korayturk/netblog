using Microsoft.Extensions.Caching.Memory;

namespace NetBLog.Api.Cache
{
    public class MemoryCache : ICacheManager
    {
        private readonly IMemoryCache _memoryCache;
        public MemoryCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void ClearCache()
        {
            _memoryCache.Dispose();
        }

        public T Get<T>(string key)
        {
            if (_memoryCache.TryGetValue(key, out object value))
                return (T)value;
            else
                return default;
        }

        public void Set(string key, object obj)
        {
            _ = _memoryCache.Set(key, obj);
        }
    }
}
