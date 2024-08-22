using System;

namespace TshirtSpace
{
    class Tshirt
    {
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

        static void Main(string[] args)
        {
            // Test cases
            RunTests();
            Console.WriteLine("All tests completed (check for expected failures).\n");
        }

        static void RunTests()
        {
            int failedTests = 0;

            // Valid inputs
            failedTests += TestSize(37, "S");
            failedTests += TestSize(40, "M");
            failedTests += TestSize(43, "L");
            failedTests += TestSize(38, "S"); // Expected to fail based on original logic

            // Invalid inputs
            failedTests += TestSize(-1, "Invalid"); // We expect this to be handled, but it won't based on current logic
            failedTests += TestSize(int.MaxValue, "L"); // Extreme valid input
            failedTests += TestSize(0, "S"); // Boundary case for small
            failedTests += TestSize(38, "Invalid"); // Testing the edge case for input exactly 38

            // Non-integer input (not handled in current logic, so this will not be a test case here)
            // We will only test valid integer cases here

            Console.WriteLine($"Total failed tests: {failedTests}");
        }

        static int TestSize(int cms, string expected)
        {
            string result = Size(cms);
            if (result != expected)
            {
                Console.WriteLine($"Test failed: Expected Size({cms}) to be '{expected}', but got '{result}'.");
                return 1; // Count this as a failed test
            }
            return 0; // No failure
        }
    }
}
