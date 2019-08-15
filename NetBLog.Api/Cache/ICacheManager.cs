namespace NetBLog.Api.Cache
{
    public interface ICacheManager
    {
        void Set(string key, object parameters);
        T Get<T>(string key);
        void ClearCache();
    }
}
