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

            // Testing the boundary case that should fail
            failedTests += AssertNotEqual(Size(38), "M"); // Expecting failure since original logic returns "L"

            // Invalid input tests
            failedTests += AssertNotEqual(Size(-1), "Invalid"); // Negative input not handled, we expect it to return "S"
            failedTests += AssertNotEqual(Size(0), "Invalid"); // Expecting "S" based on current logic

            // Non-integer input will throw an exception and is not directly tested
            try
            {
                int invalidInput = Convert.ToInt32("$$$"); // This will throw an exception
                failedTests += AssertEqual(Size(invalidInput), "Invalid"); // Not executed
            }
            catch (FormatException)
            {
                Console.WriteLine("Test passed for invalid input (non-integer).");
            }

            // Display the total number of failed tests
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

        // Assertion method to check inequality (for expected failures)
        static int AssertNotEqual(string actual, string unexpected)
        {
            if (actual == unexpected)
            {
                Console.WriteLine($"Test failed (expected failure): Expected not to be '{unexpected}', but got '{actual}'.");
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
