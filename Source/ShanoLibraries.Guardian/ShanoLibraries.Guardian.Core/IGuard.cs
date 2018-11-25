using System;

namespace ShanoLibraries.Guardian.Core
{
    public interface IGuard
    {
        string GetQualifiedValueName(string valueName);

        Exception CreateNullException(string valueName);
    }
}
