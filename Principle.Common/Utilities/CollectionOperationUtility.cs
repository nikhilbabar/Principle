using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Common.Utilities
{
    public static class CollectionOperationUtility
    {
        public static IEnumerable<T> TraverseIntersect<T>(this IEnumerable<T> source, IEnumerable<T> target, IEqualityComparer<T> comparer = null)
        {
            // argument checking, optimizations etc. removed for brevity
            var dictionary = new Dictionary<T, int>(comparer);

            foreach (T item in target)
            {
                int hits;
                dictionary.TryGetValue(item, out hits);
                dictionary[item] = hits + 1;
            }

            foreach (T item in source)
            {
                int hits;
                dictionary.TryGetValue(item, out hits);
                if (hits > 0)
                {
                    yield return item;
                    dictionary[item] = hits - 1;
                }
            }
        }
    }
}
