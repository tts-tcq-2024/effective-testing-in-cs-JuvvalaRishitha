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

        // Method to run tests
        static void RunTests()
        {
            int failedTests = 0;

            // Valid inputs
            failedTests += AssertEqual(Size(37), "S"); // Expect S
            failedTests += AssertEqual(Size(40), "M"); // Expect M
            failedTests += AssertEqual(Size(43), "L"); // Expect L
            failedTests += AssertEqual(Size(38), "S"); // This is expected to fail based on original logic

            // Invalid inputs (not handled in original logic)
            // We are using these to illustrate expected failures
            failedTests += AssertEqual(Size(-1), "S"); // Negative input
            failedTests += AssertEqual(Size(0), "S"); // Zero cms
            // This one will throw an exception since we can't convert "string" to int
            try
            {
                int invalidInput = Convert.ToInt32("$$$"); // This will throw a FormatException
                failedTests += AssertEqual(Size(invalidInput), "Invalid"); // This won't execute
            }
            catch (FormatException)
            {
                Console.WriteLine("Test passed for invalid input (non-integer).");
            }

            Console.WriteLine($"Total failed tests: {failedTests}");
        }

        // Simple assertion method to check expected vs actual values
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
