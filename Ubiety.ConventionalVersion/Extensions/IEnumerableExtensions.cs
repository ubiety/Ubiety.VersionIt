﻿using System.Collections.Generic;
using System.Linq;

namespace Ubiety.ConventionalVersion.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool IsAny<T>(this IEnumerable<T> data)
        {
            return data != null && data.Any();
        }
    }
}
