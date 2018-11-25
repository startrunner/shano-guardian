using ShanoLibraries.Guardian.Core;
using System;

namespace ShanoLibraries.Guardian.Demo
{
    class Program
    {
        public static Program SomeMethod(Program someParameter, int anotherParameter)
        {
            Keep.Argument
                .NotNull(someParameter, nameof(someParameter))
                .NotNull(someParameter, nameof(someParameter))
                .InRange(anotherParameter, (0, 12), nameof(anotherParameter));


            var value = new Program();

            return Keep.Returning.NotNull(value, nameof(SomeMethod));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
