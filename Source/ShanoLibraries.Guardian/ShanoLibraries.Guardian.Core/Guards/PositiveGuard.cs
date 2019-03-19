using System;

namespace ShanoLibraries.Guardian.Core.Guards
{
    public static class PositiveGuard
    {
        public static Guard Positive(this Guard guard, ulong value, string valueName = null)
        {
            if (!(value > 0)) throw Except(valueName);
            return guard;
        }

        public static Guard Positive(this Guard guard, long value, string valueName = null)
        {
            if (!(value > 0)) throw Except(valueName);
            return guard;
        }

        public static Guard Positive(this Guard guard, double value, string valueName = null)
        {
            if (!(value > 0)) throw Except(valueName);
            return guard;
        }
        public static Guard Positive(this Guard guard, decimal value, string valueName = null)
        {
            if (!(value > 0)) throw Except(valueName);
            return guard;
        }

        static Exception Except(string valueName) =>
            new ArgumentException($"Value '{valueName} is not positive!'");
    }
}
