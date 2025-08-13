using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using LNIQ_Assignment_01;
using LNIQ_Assignment_01.Data;
using static System.Net.Mime.MediaTypeNames;
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

            #region 13. Get the products with the most expensive price in each category.
            //var Result = ProductList
            //    .GroupBy(p => p.ProductName)
            //    .Select(g => new
            //    {
            //        Product = g.Key,
            //        MostExpensivePrice = g.Max(p => p.UnitPrice)
            //    });
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Prduct: {item.Product}, Most Expensive Price: {item.MostExpensivePrice:c}");
            //    
            //}
            #endregion

            #region 14. Get the average price of each category's products.
            //var Result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    });
            //
            //foreach (var item in Result)
            //{ 
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:c}");
            //}
            #endregion

            #endregion

            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var Result = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();
            //
            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var Result = ProductList
            //   .Select(p => p.ProductName[0])
            //   .Union(CustomerList.Select(c => c.CustomerName[0]))
            //   .Distinct();
            //
            //foreach (var letter in Result)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductList
            //    .Select(p => p.ProductName[0])
            //    .Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //
            //foreach (var letter in Result)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductList
            //    .Select(p => p.ProductName[0])
            //    .Except(CustomerList.Select(c => c.CustomerName[0]));
            //
            //foreach (var letter in Result)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductList
            //    .Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
            //    .Concat(CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var Result = CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);
            //
            //foreach (var order in Result)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var Result = CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);
            //
            //foreach (var order in Result)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers
            //    .TakeWhile((n, index) => n >= index);
            //
            //foreach (var number in Result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers
            //    .SkipWhile(n => n % 3 != 0);
            //
            //foreach (var number in Result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers
            //    .SkipWhile((n, index) => n >= index);
            //foreach (var number in Result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //bool containsEi = words.Any(word => word.Contains("ei"));
            //Console.WriteLine($"Any word contains 'ei': {containsEi}");
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var Result = ProductList
            //    .Where(p => p.UnitsInStock == 0)
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any())
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.ToList()
            //    });
            //
            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var Result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0))
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.ToList()
            //    });
            //
            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //} 
            #endregion
            #endregion

            #region LINQ – Grouping Operators
            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers
            //    .GroupBy(n => n % 5)
            //    .Select(g => new
            //    {
            //        Remainder = g.Key,
            //        Numbers = g.ToList()
            //    });       
            //
            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of: {group.Remainder} when divided by 5 : ");
            //    foreach (var number in group.Numbers)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words
            //    .GroupBy(word => word[0])
            //    .Select(g => new
            //    {
            //        FirstLetter = g.Key,
            //        Words = g.ToList()
            //    });
            //
            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Words starting with '{group.FirstLetter}':");
            //    foreach (var word in group.Words)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion

            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var Result = Arr
            //    .GroupBy(word => new string(word.OrderBy(c => c).ToArray()))
            //    .Select(g => new
            //    {
            //        SortedWord = g.Key,
            //        Words = g.ToList()
            //    });
            //
            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Words with the same characters: {group.SortedWord}");
            //    foreach (var word in group.Words)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion
            #endregion

            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var Result = ProductList
            //    .Select(p => p.ProductName);
            //
            //foreach (var name in Result)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words
            //    .Select(word => new
            //    {
            //        UpperCase = word.ToUpper(),
            //        LowerCase = word.ToLower()
            //    });
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Uppercase: {item.UpperCase}, Lowercase: {item.LowerCase}");
            //}
            #endregion
            #endregion
        }
    }
}
