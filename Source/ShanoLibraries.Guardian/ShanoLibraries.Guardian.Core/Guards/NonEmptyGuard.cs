using System;
using System.Collections;
using System.Collections.Generic;

namespace ShanoLibraries.Guardian.Core.Guards
{
    public static class NonEmptyGuard
    {
        public static Guard NotEmpty<T>(this Guard guard, ICollection<T> collection, string collectionName = null)
        {
            if (collection is null) throw ExceptNull(collectionName);
            if (collection.Count == 0) ExceptEmpty(collectionName);
            return guard;
        }

        public static Guard NotEmpty<T>(this Guard guard, IReadOnlyCollection<T> collection, string collectionName = null)
        {
            if (collection is null) throw ExceptNull(collectionName);
            if (collection.Count == 0) ExceptEmpty(collectionName);
            return guard;
        }

        public static Guard NotEmpty(this Guard guard, IEnumerable collection, string collectionName = null)
        {
            if (collection is null) throw ExceptNull(collectionName);
            if (!collection.GetEnumerator().MoveNext()) ExceptEmpty(collectionName);
            return guard;
        }

        public static Guard NotEmpty<T>(this Guard guard, T[] collection, string collectionName = null)
        {
            if (collection is null) throw ExceptNull(collectionName);
            if (collection.Length == 0) ExceptEmpty(collectionName);
            return guard;
        }
        private static void ExceptEmpty(string collectionName) => throw new ArgumentException($"collection '{collectionName}' is empty.");
        static Exception ExceptNull(string collectionName)=>
            new ArgumentNullException(collectionName);
    }
}
