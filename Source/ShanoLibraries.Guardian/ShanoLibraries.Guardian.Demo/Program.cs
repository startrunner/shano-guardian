using ShanoLibraries.Guardian.Core;
using ShanoLibraries.Guardian.Core.Guards;
using System;
using System.Runtime.ExceptionServices;

namespace ShanoLibraries.Guardian.Demo
{
    class Program
    {
        public void SomeMethod(string s, object someParameter, long anotherParameter)
        {
            Guard.Argument
                .Lambda(s, x => x.StartsWith("_"), nameof(s))
                .NotNull(someParameter, nameof(someParameter))
                .NonNegative(anotherParameter, nameof(anotherParameter));
        }
        static void Main(string[] args)
        {
            try { throw new Exception(); }
            catch (Exception e)
            {
                var info = ExceptionDispatchInfo.Capture(e);
            }
            new Program().SomeMethod("_goshu", new object(), -2);
            Console.WriteLine("Hello World!");
        }
    }
}
