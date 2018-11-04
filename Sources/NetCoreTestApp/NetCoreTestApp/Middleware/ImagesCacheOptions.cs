using System;

namespace NetCoreTestApp.Middleware
{
    public class ImagesCacheOptions
    {
        public string CacheDirectory { get; set; }

        public int MaxCachedImagesCount { get; set; }

        public TimeSpan CahceExpirationTimeInMinutes { get; set; }
    }
}
