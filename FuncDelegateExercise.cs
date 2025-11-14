using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExercise
{
    public static class FuncDelegateExercise
    {
        public static void Run()
        {
            Console.WriteLine("=== Func Delegate Exercises ===\n");
            
            Problem1();
            Console.WriteLine();
            
            Problem2();
            Console.WriteLine();
        }
        
        /// <summary>
        /// Problem 1: Func delegate that returns string length
        /// Create a Func delegate that takes a string and returns its length,
        /// and print the length of multiple strings.
        /// </summary>
        static void Problem1()
        {
            Console.WriteLine("Problem 1: Create a Func delegate that returns the length of a string.");
            Console.WriteLine("Example: \"Hello\" => 5, \"World\" => 5");
            
            // TODO: Write a Func<string, int> delegate using a lambda expression
             Func<string, int> getLength = (arg) => arg.Length;



            // Test code (uncomment and test)
             string[] words = { "Hello", "World", "C#", "Programming" };
             foreach (var word in words)
            {
                Console.WriteLine($"Length of \"{word}\": {getLength(word)}");
        }
        }
        
        /// <summary>
        /// Problem 2: Func delegate that compares two numbers
        /// Create a Func delegate that takes two integers and returns the larger one.
        /// Use this delegate to implement a method that finds the maximum value in a list.
        /// </summary>
        static void Problem2()
        {
            Console.WriteLine("Problem 2: Create a Func delegate that returns the larger of two numbers.");
            
            // TODO: Write a Func<int, int, int> delegate using a lambda expression
             Func<int, int, int> getMax = (x,y) => (x>y)? x:y; 



            // TODO: Write code to find the maximum value in a list using getMax
            List<int> numbers = new List<int> { 5, 12, 3, 45, 23, 8, 67, 34 };
            int max = numbers[0];
            foreach (var num in numbers)
            {
                max = getMax(max, num);
            }
            Console.WriteLine($"Maximum value in list: {max}");
        }
       
        
        /// <summary>
        /// Bonus: Method that takes Func as a parameter
        /// This method takes a Func delegate as a parameter and applies it to each element of a list.
        /// </summary>
        static List<TResult> ApplyFunction<TSource, TResult>(List<TSource> items, Func<TSource, TResult> function)
        {
            List<TResult> results = new List<TResult>();
            foreach (var item in items)
            {
                results.Add(function(item));
            }
            return results;
        }
    }
}

