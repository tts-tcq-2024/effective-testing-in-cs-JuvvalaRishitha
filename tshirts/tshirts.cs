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
            // Valid inputs
            AssertEqual(Size(37), "S"); // Expected to pass
            AssertEqual(Size(40), "M"); // Expected to pass
            AssertEqual(Size(43), "L"); // Expected to pass

            // Expected failures based on the original logic
            AssertEqual(Size(38), "M"); // Expected to fail (should return "S")
            AssertEqual(Size(38), "Invalid"); // Expected to fail (should return "S")

            // Invalid inputs
            AssertEqual(Size(-1), "Invalid"); // Invalid input
            AssertEqual(Size(int.MaxValue), "L"); // Extreme valid input, should be Large
            AssertEqual(Size(0), "S"); // Boundary case, should return Small

            Console.WriteLine("All test assertions completed.");
        }

        // Helper method to assert equality and throw if not
        static void AssertEqual(string actual, string expected)
        {
            Debug.Assert(actual == expected, $"Assertion failed: expected '{expected}', but got '{actual}'.");
            if (actual != expected)
            {
                throw new Exception($"Assertion failed: expected '{expected}', but got '{actual}'.");
            }
        }
    }
}
