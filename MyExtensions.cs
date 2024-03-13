using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_005_Delegate
{
    public static class MyExtensions
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> collection, Predicate<T> predicat)
        {
            foreach (var item in collection)
            {
                if (predicat(item))
                {
                    yield return item;
                }
            }
        }
    }
}
