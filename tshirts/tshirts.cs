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

            // Test for boundary cases
            failedTests += AssertEqual(Size(38), "L"); // This is expected to fail based on the original logic.

            // Invalid input tests - these are expected to fail based on current logic.
            failedTests += AssertEqual(Size(-1), "S"); // Negative input, expected behavior is undefined
            failedTests += AssertEqual(Size(0), "S"); // Zero cms, expected behavior is undefined

            // Exception for invalid input
            try
            {
                int invalidInput = Convert.ToInt32("$$$"); // This will throw an exception.
                // This line won't execute because of the exception above.
                failedTests += AssertEqual(Size(invalidInput), "Invalid");
            }
            catch (FormatException)
            {
                Console.WriteLine("Test passed for invalid input (non-integer).");
            }

            // Final output for test results
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
