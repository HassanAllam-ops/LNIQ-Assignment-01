using LNIQ_Assignment_01;
using LNIQ_Assignment_01.Data;
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

            #region 2. Return a list of customers and how many orders each has.
            //var Result = CustomerList
            //    .Select(c => new
            //    {
            //        c.CustomerID,
            //        OrderCount = c.Orders.Count()
            //    });
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Customer ID: {item.CustomerID}, Order Count: {item.OrderCount}");
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var Result = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    ProductCount = g.Count()
            //});
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Products: {item.ProductCount}");
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.Sum(word => word.Length);
            //Console.WriteLine($"Total Caracters : {Result}");
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.Min(word => word.Length);
            //Console.WriteLine($"Shortest Word Length : {Result}");
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.Max(word => word.Length);
            //Console.WriteLine($"Longest Word Length : {Result}");
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.Average(word => word.Length);
            //Console.WriteLine($"Average Word Length : {Result}");
            #endregion

            #region 9. Get the total units in stock for each product category.
            //var Result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    });
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.TotalUnitsInStock}");
            //}
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var Result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = g.Min(p => p.UnitPrice)
            //    });
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice:c}");
            //}
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var Result =
            //from p in ProductList
            //group p by p.Category into g
            //let minPrice = g.Min(x => x.UnitPrice)
            //from h in g
            //where h.UnitPrice == minPrice
            //select h;
            //
            //foreach( var item in Result )
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.UnitPrice:c}");
            //}
            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var Result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        MostExpensivePrice = g.Max(p => p.UnitPrice)  
            //    });
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item.MostExpensivePrice:c}");
            //}
            #endregion

            #endregion
        }
    }
}
