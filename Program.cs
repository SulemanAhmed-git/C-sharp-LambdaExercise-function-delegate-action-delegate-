using System;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Lambda Expression and Delegate Exercises ===\n");
            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Lambda Expression Exercises");
                Console.WriteLine("2. Func Delegate Exercises");
                Console.WriteLine("3. Action Delegate Exercises");
                Console.WriteLine("0. Exit");
                Console.Write("\nSelect: ");
                
                string? choice = Console.ReadLine();
                Console.WriteLine();
                
                switch (choice)
                {
                    case "1":
                        LambdaExercise.Run();
                        break;
                    case "2":
                        FuncDelegateExercise.Run();
                        break;
                    case "3":
                        ActionDelegateExercise.Run();
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid selection.\n");
                        break;
                }
                
                if (!exit && choice != null && choice != "0")
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

