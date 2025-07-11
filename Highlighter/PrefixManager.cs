using System;
using System.Collections.Generic;

namespace Highlighter
{
    internal static class PrefixManager
    {
        private static readonly List<string> _prefixes = new List<string>();

        static PrefixManager() => InitDefaults();

        public static void Add(params string[] prefixes)
        {
            foreach (var prefix in prefixes)
            {
                if (Contains(prefix)) continue;

                _prefixes.Add(prefix);
            }
        }

        public static int Count => _prefixes.Count;

        public static string GetPrefix(int index) => _prefixes[index];

        public static bool Contains(string prefix) => _prefixes.Contains(prefix);

        private static void InitDefaults() => Add(Enum.GetNames(typeof(Consts.ColorKeyword)));
    }
}
