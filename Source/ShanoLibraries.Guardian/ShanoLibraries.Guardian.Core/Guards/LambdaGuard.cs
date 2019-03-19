using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShanoLibraries.Guardian.Core.Guards
{
    public static class LambdaGuard
    {
        public static Guard Lambda<TValue>(
            this Guard guard,
            TValue value,
            Func<TValue, bool> lambda,
            string valueName=null
        )
        {
            if (!lambda.Invoke(value)) throw new ArgumentException(valueName);
            return guard;
        }
    }
}
