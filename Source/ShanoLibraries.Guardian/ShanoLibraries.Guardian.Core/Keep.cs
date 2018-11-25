using System;

namespace ShanoLibraries.Guardian.Core
{
    public static class Keep
    {
        class IntermediateGuardian : IIntermediateGuard
        {
            public Exception CreateNullException(string valueName) => new Exception($"Intermediate value of {valueName} is null.");
            public string GetQualifiedValueName(string valueName) => $"Intermediate value of '{valueName}'";
        }
        class ReturningGuardian : IReturningGuard
        {
            public Exception CreateNullException(string valueName) => new Exception($"Method {valueName}() tried to return null.");
            public string GetQualifiedValueName(string valueName) => $"Return value of {valueName}";
        }
        class ArgumentGuardian : IArgumentGuard
        {
            public Exception CreateNullException(string valueName) => throw new ArgumentNullException(valueName);
            public string GetQualifiedValueName(string valueName) => $"Value of argument '{valueName}'";
        }

        public static IIntermediateGuard Intermediate { get; } = new IntermediateGuardian();
        public static IReturningGuard Returning { get; } = new ReturningGuardian();
        public static IArgumentGuard Argument { get; } = new ArgumentGuardian();
    }
}
