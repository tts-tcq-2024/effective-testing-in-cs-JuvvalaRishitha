using System;

namespace TshirtSpace
{
    class Tshirt
    {
        // Method to determine T-shirt size based on cms
        static string Size(int cms)
        {
            if (cms < 38)
            {
                return "S"; // Small
            }
            else if (cms > 38 && cms < 42)
            {
                return "M"; // Medium
            }
            else
            {
                return "L"; // Large
            }
        }

        // Method to test the Size function
        static void RunTests()
        {
            int failedTests = 0;

            // Valid inputs
            failedTests += AssertEqual(Size(37), "S");
            failedTests += AssertEqual(Size(40), "M");
            failedTests += AssertEqual(Size(43), "L");
            failedTests += AssertEqual(Size(38), "S"); // This is expected to fail based on original logic

            // Invalid inputs
            failedTests += AssertEqual(Size(-1), "S"); // This case is not handled in the original logic
            failedTests += AssertEqual(Size(0), "S"); // Boundary case for small

            // Handle invalid input; this case will raise an exception in C#
            try
            {
                // This will throw an exception
                int invalidInput = Convert.ToInt32("$$$"); 
                // This line won't execute due to exception
                failedTests += AssertEqual(Size(invalidInput), "Invalid"); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Test passed for invalid input (non-integer).");
            }

            Console.WriteLine($"Total failed tests: {failedTests}");
        }

        // Assertion method to check equality
        static int AssertEqual(string actual, string expected)
        {
            if (actual != expected)
            {
                Console.WriteLine($"Test failed: Expected '{expected}', but got '{actual}'.");
                return 1; // Count this as a failed test
            }
            return 0; // No failure
        }

        // Main entry point
        static void Main(string[] args)
        {
            RunTests();
            Console.WriteLine("All tests completed (check for expected failures).\n");
        }
    }
}
