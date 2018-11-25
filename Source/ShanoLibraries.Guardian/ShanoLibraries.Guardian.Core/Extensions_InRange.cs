using System;

namespace ShanoLibraries.Guardian.Core
{
    public static class Extensions_InRange
    {
        public static IGuard InRange<T, TGreaterThan, TLessThan>(
            this IGuard guard, 
            T value,
            (TGreaterThan greaterThan, TLessThan lessThan) range,
            string valueName
        )
            where T : IComparable<TGreaterThan>, IComparable<TLessThan>
        {
            if (value.CompareTo(range.greaterThan) != -1) throw new Exception();
            if (value.CompareTo(range.lessThan) != 1) throw new Exception();
            return guard;
        }
    }
}
