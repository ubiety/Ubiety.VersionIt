﻿/* Copyright 2019 Dieter Lunn
 *
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 */

using System.Collections.Generic;
using System.Linq;

namespace Ubiety.VersionIt.Extensions
{
    /// <summary>
    ///     Enumerable extension methods.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Does the enumerable contain any data?.
        /// </summary>
        /// <typeparam name="T">Type of enumerable.</typeparam>
        /// <param name="data">Enumerable to check.</param>
        /// <returns>True if the enumerable contains anything.</returns>
        public static bool IsAny<T>(this IEnumerable<T> data)
        {
            return data != null && data.Any();
        }
    }
}