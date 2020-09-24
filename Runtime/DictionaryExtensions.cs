using System.Collections.Generic;

namespace Runtime
{
    public static class DictionaryExtensions
    {
        public static void Set<TK, TV>(this Dictionary<TK, TV> dict, TK key, TV value)
        {
            if (dict == null)
            {
                return;
            }

            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
            }
            else
            {
                dict[key] = value;
            }
        }

        public static bool TryGet<TK, TV>(this Dictionary<TK, TV> dict, TK key, out TV value)
        {
            value = default;
            if (dict == null || !dict.ContainsKey(key))
            {
                return false;
            }

            value = dict[key];

            return true;
        }
    }
}