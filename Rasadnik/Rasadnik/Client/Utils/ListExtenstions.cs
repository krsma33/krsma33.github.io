using System;
using System.Collections.Generic;

namespace Rasadnik.Client
{
    public static class ListExtenstions
    {
        public static IEnumerable<List<T>> Split<T>(this List<T> collection, int nSize = 5)
        {
            int count = collection.Count;

            for (int i = 0; i < count; i += nSize)
            {
                yield return collection.GetRange(i, Math.Min(nSize, count - i));
            }
        }

        public static IEnumerable<List<T>> SplitIntoVariableChunks<T>(this List<T> collection, int chunkOne = 3, int chunkTwo = 2)
        {
            int count = collection.Count;

            int total = chunkOne + chunkTwo;
            int current = 1;

            for (int i = 0; i < count; )
            {
                if (current <= chunkOne)
                {
                    yield return collection.GetRange(i, Math.Min(chunkOne, count - i));
                    i += chunkOne;
                    current += chunkOne;
                }
                else
                {
                    yield return collection.GetRange(i, Math.Min(chunkTwo, count - i));
                    i += chunkTwo;
                    current += chunkTwo;
                }

                if (current > total)
                {
                    current = 1;
                }
            }
        }
    }
}
