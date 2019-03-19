using System;
using System.Collections.Generic;
using System.Text;

namespace ShanoLibraries.Guardian.Core.Guards
{
    public static class NotZeroGuard
    {
        public static Guard NotZero(this Guard guard, long value, string valueName = null)
        {
            if (value == 0) throw Except(valueName);
            return guard;
        }

        public static Guard NotZero(this Guard guard, double value, string valueName = null)
        {
            if (value == 0) throw Except(valueName);
            return guard;
        }

        public static Guard NotZero(this Guard guard, decimal value, string valueName = null)
        {
            if (value == 0) throw new ArgumentException($"Value '{valueName}' is zero!");
            return guard;
        }
        private static ArgumentException Except(string valueName) => 
            new ArgumentException($"Value '{valueName}' is zero!");
    }
}
