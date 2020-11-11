using System;
using System.Collections.Generic;

namespace RasadnikUi
{
    public static class ListExtenstions
    {
        public static IEnumerable<List<T>> Split<T>(this List<T> locations, int nSize = 5)
        {
            int count = locations.Count;

            for (int i = 0; i < count; i += nSize)
            {
                yield return locations.GetRange(i, Math.Min(nSize, count - i));
            }
        }

        public static IEnumerable<List<T>> SplitIntoVariableChunks<T>(this List<T> locations, int chunkOne = 3, int chunkTwo = 2)
        {
            int count = locations.Count;

            int total = chunkOne + chunkTwo;
            int current = 1;

            for (int i = 0; i < count; )
            {
                if (current <= chunkOne)
                {
                    yield return locations.GetRange(i, Math.Min(chunkOne, count - i));
                    i += chunkOne;
                    current += chunkOne;
                }
                else
                {
                    yield return locations.GetRange(i, Math.Min(chunkTwo, count - i));
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
