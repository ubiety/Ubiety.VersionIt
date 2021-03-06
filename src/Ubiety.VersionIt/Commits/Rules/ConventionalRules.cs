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

namespace Ubiety.VersionIt.Commits.Rules
{
    /// <summary>
    ///     Conventional commit types.
    /// </summary>
    public enum ConventionalTypes
    {
        /// <summary>
        ///     A bug fix
        /// </summary>
        Fix,

        /// <summary>
        ///     A new feature
        /// </summary>
        Feat,

        /// <summary>
        ///     Documentation update
        /// </summary>
        Docs,

        /// <summary>
        ///     Continuous Integration
        /// </summary>
        Ci,

        /// <summary>
        ///     Build system changes
        /// </summary>
        Build,

        /// <summary>
        ///     General changes
        /// </summary>
        Chore,

        /// <summary>
        ///     Performance enhancements
        /// </summary>
        Perf,

        /// <summary>
        ///     Code change that is not a bug fix or new feature
        /// </summary>
        Refactor,

        /// <summary>
        ///     Code reversion
        /// </summary>
        Revert,

        /// <summary>
        ///     Changes that do not affect the meaning of the code
        /// </summary>
        Style,

        /// <summary>
        ///     Changes to the test framework
        /// </summary>
        Test,
    }

    /// <summary>
    ///     Conventional commit rules.
    /// </summary>
    public static class ConventionalRules
    {
        /// <summary>
        ///     Gets a value for the rules.
        /// </summary>
        public static Dictionary<ConventionalTypes, (string Type, string Header)> Rules => new Dictionary<ConventionalTypes, (string, string)>
        {
            { ConventionalTypes.Feat, ("feat", "Features") },
            { ConventionalTypes.Fix, ("fix", "Bug Fixes") },
            { ConventionalTypes.Chore, ("chore", "Chores") },
            { ConventionalTypes.Ci, ("ci", "Continuous Integration") },
            { ConventionalTypes.Docs, ("docs", "Documentation") },
            { ConventionalTypes.Build, ("build", "Build") },
            { ConventionalTypes.Perf, ("perf", "Performance") },
            { ConventionalTypes.Style, ("style", "Style") },
            { ConventionalTypes.Test, ("test", "Tests") },
            { ConventionalTypes.Revert, ("revert", "Reversions") },
            { ConventionalTypes.Refactor, ("refactor", "Refactors") },
        };
    }
}
