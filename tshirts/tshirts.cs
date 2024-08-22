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
            
            // Boundary case expected to fail
            failedTests += AssertEqual(Size(38), "S"); // Expected to fail

            // Invalid input tests (current logic does not handle these properly)
            failedTests += AssertEqual(Size(-1), "S"); // Negative input (undefined behavior)
            failedTests += AssertEqual(Size(0), "S"); // Zero cms (undefined behavior)

            // Exception handling for non-integer input
            try
            {
                int invalidInput = Convert.ToInt32("$$$"); // This will throw an exception
                failedTests += AssertEqual(Size(invalidInput), "Invalid"); // Not executed
            }
            catch (FormatException)
            {
                Console.WriteLine("Test passed for invalid input (non-integer).");
            }

            Console.WriteLine($"Total failed tests: {failedTests}");
        }

        // Assertion method to check expected vs actual values
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
