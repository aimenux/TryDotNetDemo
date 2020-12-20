using System;

namespace CSharpFeatures
{
    public static class Program
    {
        public static int Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            return region
            switch
            {
                nameof(CSharp6.Dictionaries) => CSharp6.Dictionaries(),
                nameof(CSharp6.Collections) => CSharp6.Collections(),
                nameof(CSharp7.LocalFunctions) => CSharp7.LocalFunctions(),
                nameof(CSharp7.Tuples) => CSharp7.Tuples(),
                nameof(CSharp8.NullCoalescing) => CSharp8.NullCoalescing(),
                nameof(CSharp8.SwitchExpressions) => CSharp8.SwitchExpressions(),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(region))
            };
        }
    }
}
