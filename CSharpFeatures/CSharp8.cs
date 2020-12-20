using System;

namespace CSharpFeatures
{
    public static class CSharp8
    {
        public static int NullCoalescing()
        {
            #region NullCoalescing

            // Before C# 8
            int? oldVal = null;
            if (oldVal == null)
            {
                oldVal = 1;
            }

            // With C# 8
            int? newVal = null;
            newVal ??= 1;

            // Print something in try.net console
            Console.WriteLine($"oldVal = {oldVal}");
            Console.WriteLine($"newVal = {newVal}");

            #endregion

            return 0;
        }

        public static int SwitchExpressions()
        {
            #region SwitchExpressions

            // Before C# 8
            var oldColor = GetColorBefore(nameof(Color.Blue));

            // With C# 8
            var newColor = GetColorAfter(nameof(Color.Blue));

            // Print something in try.net console
            Console.WriteLine($"oldColor = {oldColor}");
            Console.WriteLine($"newColor = {newColor}");

            #endregion

            return 0;
        }

        private static Color GetColorBefore(string color)
        {
            switch (color)
            {
                case nameof(Color.Red):
                    return Color.Red;

                case nameof(Color.Green):
                    return Color.Green;

                case nameof(Color.Blue):
                    return Color.Blue;

                default:
                    throw new ArgumentException(message: "invalid enum value", paramName: nameof(color));
            };
        }

        private static Color GetColorAfter(string color)
        {
            return color switch
            {
                nameof(Color.Red) => Color.Red,
                nameof(Color.Green) => Color.Green,
                nameof(Color.Blue) => Color.Blue,
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(color)),
            };
        }

        public enum Color
        {
            Red,
            Green,
            Blue
        }
    }
}
