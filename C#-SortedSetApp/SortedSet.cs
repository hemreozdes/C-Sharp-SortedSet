using System.Collections.Generic;

namespace SortedSetApp
{
    internal class SortedSetApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many values do you want in a set?");
            string userNumber=Console.ReadLine();
            int number;
            int.TryParse(userNumber, out number);
            var A = new SortedSet<int>(CreateRandomNumbers(number));
            var B = new SortedSet<int>(CreateRandomNumbers(number));
            #region //Lists
            Console.WriteLine();
            Console.WriteLine("A");
            foreach (var item in A)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("B");
            foreach (var item in B)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();
            #endregion

            #region //Union
            SortedSet<int> C = new SortedSet<int>(A.Union(B));
            Console.WriteLine();
            Console.WriteLine("Union of A and B\n");
            foreach (var item in C)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine("\n\nCount of the Union: {0}", C.Count);
            #endregion

            #region //Intersect
            SortedSet<int> D = new SortedSet<int>(A.Intersect(B));
            Console.WriteLine();
            Console.WriteLine("\nIntersect of A and B\n");
            foreach (var item in D)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine("\n\nCount of the Intersect: {0}", D.Count);
            #endregion
            static List<int> CreateRandomNumbers(int num)
            {
                var list = new List<int>();
                var r = new Random();
                for (int i = 0; i < num; i++)
                {
                    list.Add(r.Next(0, 50));
                }
                return list;
            }
            Console.ReadKey();
        }
    }
}
