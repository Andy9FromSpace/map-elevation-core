﻿using System;

namespace Santolibre.Map.Elevation.Lib
{
    public interface IDemFileCache
    {
        object GetValue(string key);
        bool Add(string key, object value, DateTimeOffset absExpiration);
        void Delete(string key);
    }
}
