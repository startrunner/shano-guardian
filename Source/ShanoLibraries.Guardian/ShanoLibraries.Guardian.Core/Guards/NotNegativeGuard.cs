using System;

namespace ShanoLibraries.Guardian.Core.Guards
{
    public static class NotNegativeGuard
    {
        public static Guard NonNegative(this Guard guard, long value, string valueName = null)
        {
            if (value < 0) throw Except(valueName);
            return guard;
        }

        public static Guard NonNegative(this Guard guard, double value, string valueName = null)
        {
            if (value < 0.00) throw Except(valueName);
            return guard;
        }

        public static Guard NonNegative(this Guard guard, decimal value, string valueName = null)
        {
            if (value < 0) throw Except(valueName);
            return guard;
        }

        static ArgumentException Except(string valueName) =>
                new ArgumentException($"value '{valueName}' is negative");
    }
}
