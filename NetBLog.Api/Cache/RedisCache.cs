using Microsoft.Extensions.Caching.Distributed;
using NetBLog.Common;

namespace NetBLog.Api.Cache
{
    public class RedisCache : ICacheManager
    {

        private readonly IDistributedCache _distributedCache;
        public RedisCache(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public void ClearCache()
        {
            //TODO: redis clear cache
        }

        public T Get<T>(string key)
        {
            var str = _distributedCache.GetString(key);
            if (string.IsNullOrEmpty(str))
                return default;

            return str.JsonToObject<T>();
        }

        public void Set(string key, object parameters)
        {
            _distributedCache.SetString(key, parameters.ToJson(), new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = new System.TimeSpan(60000)
            });
        }
    }
}
