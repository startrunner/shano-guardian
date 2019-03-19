using System;

namespace ShanoLibraries.Guardian.Core.Guards
{
    public static partial class NotNullGuard
    {
        public static Guard NotNull<TValue>(this Guard guard, TValue? value, string valueName = null)
            where TValue : struct
        {
            if (value is null) throw Except(valueName);
            return guard;
        }

        public static Guard NotNull<TValue>(this Guard guard, TValue value, string valueName = null)
            where TValue : class
        {
            if (value is null) throw Except(valueName);
            return guard;
        }

        static Exception Except(string valueName) =>
            new NullReferenceException($"value '{valueName}' is null");
    }
}
