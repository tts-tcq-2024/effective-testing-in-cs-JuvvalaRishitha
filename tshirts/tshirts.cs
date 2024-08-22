using System;
using System.Diagnostics;

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

        // Main entry point
        static void Main(string[] args)
        {
            // Run test cases
            RunTests();
            Console.WriteLine("All tests completed (check for expected failures).\n");
        }

        // Method to run various tests
        static void RunTests()
        {
            int failedTests = 0;

            // Valid inputs
            failedTests += AssertEqual(Size(37), "S"); // Expected to pass
            failedTests += AssertEqual(Size(40), "M"); // Expected to pass
            failedTests += AssertEqual(Size(43), "L"); // Expected to pass

            // Expected failures based on the original logic
            failedTests += AssertNotEqual(Size(38), "M"); // Expected to fail (should return "S")
            failedTests += AssertNotEqual(Size(38), "Invalid"); // Expected to fail (should return "S")

            // Invalid inputs
            failedTests += AssertEqual(Size(-1), "Invalid"); // Invalid input
            failedTests += AssertEqual(Size(int.MaxValue), "L"); // Extreme valid input, should be Large
            failedTests += AssertEqual(Size(0), "S"); // Boundary case, should return Small

            Console.WriteLine($"Total failed tests: {failedTests}");
        }

        // Helper method to assert equality and return failure count
        static int AssertEqual(string actual, string expected)
        {
            if (actual != expected)
            {
                Console.WriteLine($"Assertion failed: expected '{expected}', but got '{actual}'.");
                return 1; // Count this as a failed test
            }
            return 0; // No failure
        }

        // Helper method to assert not equal and return failure count
        static int AssertNotEqual(string actual, string unexpected)
        {
            if (actual == unexpected)
            {
                Console.WriteLine($"Assertion failed: did not expect '{unexpected}', but got '{actual}'.");
                return 1; // Count this as a failed test
            }
            return 0; // No failure
        }
    }
}
