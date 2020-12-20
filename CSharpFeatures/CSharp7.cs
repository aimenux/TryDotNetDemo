using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFeatures
{
    public static class CSharp7
    {
        public static int LocalFunctions()
        {
            #region LocalFunctions

            var numbers = Enumerable.Range(1, 10).Select(x => x).ToList();

            // Before C# 7
            var oldNumbers = FindNumberBefore(numbers);

            // With C# 7
            var newNumbers = FindNumberAfter(numbers);

            // Print something in try.net console
            Console.WriteLine($"oldNumbers = {string.Join(',', oldNumbers)}");
            Console.WriteLine($"newNumbers = {string.Join(',', newNumbers)}");

            #endregion

            return 0;
        }

        public static int Tuples()
        {
            #region Tuples

            // Before C# 7
            var oldProduct = GetProductBefore();

            // With C# 7
            var (id, description, price) = GetProductAfter();

            // Print something in try.net console
            Console.WriteLine($"oldProduct.Price = {oldProduct.Item3}");
            Console.WriteLine($"newProduct.Price = {price}");

            #endregion

            return 0;
        }

        private static IEnumerable<int> FindNumberBefore(IEnumerable<int> numbers)
        {
            Predicate<int> Predicate = n =>
            {
                if (n % 2 == 0)
                {
                    return n >= 0;
                }
                else
                {
                    return n % 5 == 0;
                }
            };

            return numbers.Where(n => Predicate(n));
        }

        private static IEnumerable<int> FindNumberAfter(IEnumerable<int> numbers)
        {
            bool Predicate(int n)
            {
                if (n % 2 == 0)
                {
                    return n >= 0;
                }
                else
                {
                    return n % 5 == 0;
                }
            };

            return numbers.Where(n => Predicate(n));
        }

        private static Tuple<int, string, decimal> GetProductBefore()
        {
            return new Tuple<int, string, decimal>(1, "Sugar", 1.5m);
        }

        private static (int, string, decimal) GetProductAfter()
        {
            return (1, "Sugar", 1.5m);
        }
    }
}
