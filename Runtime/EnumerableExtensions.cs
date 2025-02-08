using System;
using System.Collections.Generic;
using System.Linq;

namespace SweetAlgy.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> self) 
            => self is null || !self.Any();
        
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> self) 
            => !self.IsNullOrEmpty();
        
        public static IEnumerable<T> GetDuplicateItems<T>(this IEnumerable<T> self)
            => self
               .GroupBy(item => item)
               .Where(group => group.Count() > 1)
               .Select(group => group.Key);

        public static IEnumerable<TResult> GetDuplicateItems<TSource, TKey, TResult>(
            this IEnumerable<TSource> self,
            Func<TSource, TKey> keySelector,
            Func<IGrouping<TKey,TSource>, TResult> resultSelector)
            => self
               .GroupBy(keySelector)
               .Where(group => group.Count() > 1)
               .Select(resultSelector);
        
        public static int FindNullItems<T>(this IEnumerable<T> self)
            => self.Count(item => item is null);
    }
}