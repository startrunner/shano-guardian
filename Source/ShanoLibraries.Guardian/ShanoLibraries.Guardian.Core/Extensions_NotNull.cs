namespace ShanoLibraries.Guardian.Core
{
    public static class Extensions_NotNull
    {
        public static IGuard NotNull<T>(this IGuard guard, T value, string argumentName) where T: class
        {
            if (value is null) throw guard.CreateNullException(argumentName);
            return guard;
        }

        public static T NotNull<T>(this IReturningGuard guard, T value, string methodName) where T: class
        {
            if (value is null) throw guard.CreateNullException(methodName);
            return value;
        }
    }
}
