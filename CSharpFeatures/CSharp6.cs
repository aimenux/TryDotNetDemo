using System;
using System.Collections.Generic;

namespace CSharpFeatures
{
    public static class CSharp6
    {
        public static int Dictionaries()
        {
            #region Dictionaries

            // Before C# 6
            var oldDic = new Dictionary<int, string>
            {
                { 1 , "a"},
                { 2 , "b"},
                { 3 , "c"},
            };

            // With C# 6
            var newDic = new Dictionary<int, string>
            {
                [1] = "a",
                [2] = "b",
                [3] = "c"
            };

            // Print something in try.net console
            Console.WriteLine($"oldDic[1] = {oldDic[1]}");
            Console.WriteLine($"newDic[1] = {newDic[1]}");

            #endregion

            return 0;
        }

        public static int Collections()
        {
            #region Collections

            // Before C# 6
            var oldObj = new List<Person>()
            {
                new Person("Vincent", "VanGogh"),
                new Person("Leonardo", "DaVinci")
            };

            // With C# 6
            var newObj = new List<Person>()
            {
                { "Vincent", "VanGogh" },
                { "Leonardo", "DaVinci" }
            };

            // Print something in try.net console
            Console.WriteLine($"oldObj[1] = {oldObj[1]}");
            Console.WriteLine($"newObj[1] = {newObj[1]}");

            #endregion

            return 0;
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string firstname, string lastname)
            {
                FirstName = firstname;
                LastName = lastname;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}";
            }
        }

        public static void Add(this List<Person> persons, string firstname, string lastname)
        {
            persons.Add(new Person(firstname, lastname));
        }
    }
}
