using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExercise
{
    public static class LambdaExercise
    {
        public static void Run()
        {
            Console.WriteLine("=== Lambda Expression Exercises ===\n");
            
            Problem1();
            Console.WriteLine();
            
            Problem2();
            Console.WriteLine();
            
            Problem3();
            Console.WriteLine();
            
            Problem4();
            Console.WriteLine();
            
            // Problem 5
            Problem5();
        }
        
        /// <summary>
        /// Problem 1: Lambda expression that adds two integers
        /// Create a lambda expression that takes two integers and returns their sum.
        /// </summary>
        static void Problem1()
        {
            Console.WriteLine("Problem 1: Create a lambda expression that adds two integers.");
            Console.WriteLine("Example: Add(5, 3) => 8");
            
            // TODO: Write a lambda expression here
            // Func<int, int, int> add = ???;
            Func<int,int,int> add = (x,y) => x+y;
            
            
            // Test code (uncomment and test)
             Console.WriteLine($"Result: {add(5, 3)}");
             Console.WriteLine($"Result: {add(10, 20)}");
        }
        
        /// <summary>
        /// Problem 2: Filter strings from a list by length
        /// Create a lambda expression that filters strings from a list that are 5 or more characters long.
        /// </summary>
        static void Problem2()
        {
            Console.WriteLine("Problem 2: Filter strings from a list that are 5 or more characters long.");
            
            List<string> words = new List<string> { "apple", "cat", "banana", "dog", "elephant", "fox" };
            Console.WriteLine("Original list: " + string.Join(", ", words));

            // TODO: Use Where with a lambda expression to filter strings with length >= 5
            var filteredWords = words.Where( word=> word.Length>=5).ToList();

            // Test code (uncomment and test)
             Console.WriteLine("Filtered result: " + string.Join(", ", filteredWords));
        }
        
        /// <summary>
        /// Problem 3: Square each element in a number list
        /// Create a lambda expression that squares each element in a number list to create a new list.
        /// </summary>
        static void Problem3()
        {
            Console.WriteLine("Problem 3: Square each element in a number list.");
            
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original list: " + string.Join(", ", numbers));
            
            // TODO: Use Select with a lambda expression to square each element
             var squares = numbers.Select(numb => numb*numb ).ToList();

            // Test code (uncomment and test)
             Console.WriteLine("Squared result: " + string.Join(", ", squares));
        }
        
        /// <summary>
        /// Problem 4: Check if an element meets a condition
        /// Create a lambda expression that checks if there are any numbers greater than 50 in a number list.
        /// </summary>
        static void Problem4()
        {
            Console.WriteLine("Problem 4: Check if there are any numbers greater than 50 in a number list.");
            
            List<int> numbers = new List<int> { 10, 23, 45, 67, 32, 89 };
            Console.WriteLine("Original list: " + string.Join(", ", numbers));
            
            // TODO: Use Any with a lambda expression to check if there are numbers > 50
             bool hasLargeNumber = numbers.Any(Bnumber => Bnumber > 50);



            // Test code (uncomment and test)
             Console.WriteLine($"Are there any numbers greater than 50? {hasLargeNumber}");
        }
        
        /// <summary>
        /// Problem 5: Sort a list
        /// Create a lambda expression that sorts a string list by length in descending order.
        /// </summary>
        static void Problem5()
        {
            Console.WriteLine("Problem 5: Sort a string list by length in descending order.");
            
            List<string> fruits = new List<string> { "apple", "kiwi", "banana", "strawberry", "grape" };
            Console.WriteLine("Original list: " + string.Join(", ", fruits));
            
            // TODO: Use OrderByDescending with a lambda expression to sort by length in descending order
             var sortedFruits = fruits.OrderByDescending(fruit => fruit.Length ).ToList();

            // Test code (uncomment and test)
             Console.WriteLine("Sorted result: " + string.Join(", ", sortedFruits));
        }
    }
}

