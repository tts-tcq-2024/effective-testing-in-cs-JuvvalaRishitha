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

            // Test cases
            failedTests += AssertEqual(Size(37), "S");
            failedTests += AssertEqual(Size(40), "M");
            failedTests += AssertEqual(Size(43), "L");
            failedTests += AssertEqual(Size(38), "S"); // This is expected to fail based on original logic
            failedTests += AssertEqual(Size(-1), "Invalid"); // Not handled in the original logic
            failedTests += AssertEqual(Size(0), "S"); // Boundary case for small

            // Handle invalid input; this case will raise an exception in C#
            try
            {
                int invalidInput = Convert.ToInt32("$$$"); // This will throw an exception
                failedTests += AssertEqual(Size(invalidInput), "Invalid"); // This line won't execute due to exception
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
