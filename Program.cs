using LNIQ_Assignment_01;
using static LNIQ_Assignment_01.ListGenerator;

namespace LINQ_Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //
            //foreach(var product in Result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit
            //var Result = ProductList
            //    .Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);
            //
            //foreach (var product in Result)
            //    {
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //
            //var Result = Arr
            //    .Where((s, i) => s.Length < i); 
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var Result = ProductList.FirstOrDefault
            //    (ProductList => ProductList.UnitsInStock == 0);
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductList.FirstOrDefault
            //        (P => P.UnitPrice > 1000);
            //Console.WriteLine(Result);
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr
            //    .Where(n => n > 5)
            //    .Skip(1)
            //    .FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr
            //.Where(n => n % 2 == 1).Count();
            //Console.WriteLine(Result);
            #endregion
            #endregion
        }
    }
}
