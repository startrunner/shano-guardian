using System;

namespace ShanoLibraries.Guardian.Core
{
    internal static class GuardFailedMessage
    {
        static string TypeKind(Type type)
        {
            if (type.IsEnum) return "enum";
            else if (type.IsByRef == false) return "struct";
            else if (type.IsClass)
            {
                if (type.IsAbstract) return "abstract class";
                return "class";
            }
            else return "type";
        }

        public static string ValueType(Guard guard) =>
            guard == Guard.Argument ? "argument" :
            guard == Guard.Intermediate ? "intermediate value" :
            guard == Guard.ReturnValue ? "return value" :
            throw new NotImplementedException();

        public static string ExceptionMessage(Guard guard, Type objectType, string methodName, string valueName, string exceptionMessage) =>
            $"Guard for {ValueType(guard)} '{valueName}' in {ProcedureReference(methodName, objectType)} has failed:\n" +
            $"{exceptionMessage}";

        public static string ProcedureReference(string methodName, Type objectType)
        {
            string typeName = objectType.Name;
            string typeKind = TypeKind(objectType);

            return $"method '{methodName}' of {typeKind} '{typeName}'";
        }
    }
}
