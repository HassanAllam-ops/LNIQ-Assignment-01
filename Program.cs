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
        }
    }
}
