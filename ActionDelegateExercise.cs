using System;
using System.Collections.Generic;

namespace LambdaExercise
{
    public static class ActionDelegateExercise
    {
        public static void Run()
        {
            Console.WriteLine("=== Action Delegate Exercises ===\n");
            
            Problem1();
            Console.WriteLine();
            
        }

        /// <summary>
        /// Problem 1: Action delegate that prints messages
        /// Create an Action delegate that takes a string and outputs it to the console in a specific format.
        /// Format: ">>> [message] <<<"
        /// </summary>
        static void Problem1()
        {
            Console.WriteLine("Problem 1: Create an Action delegate that prints messages in a specific format.");
            Console.WriteLine("Format: >>> [message] <<<");

            // TODO: Write an Action<string> delegate using a lambda expression
            Action<string> printMessage = (arg) => Console.WriteLine(arg);



            // Test code (uncomment and test)
             printMessage("Hello");
             printMessage("C# Programming");
             printMessage("Action Delegate");

            // Test code Output:
            // >>> Hello <<<
            // >>> C# Programming <<<
            // >>> Action Delegate <<<
        }
    }
}

