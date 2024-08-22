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
            failedTests += TestSize(37, "S"); // Should pass
            failedTests += TestSize(40, "M"); // Should pass
            failedTests += TestSize(43, "L"); // Should pass

            // Test case that is expected to fail based on original logic
            failedTests += TestSize(38, "M"); // Expected to fail (should return "S")
            failedTests += TestSize(38, "Invalid"); // Expected to fail (should return "S")

            // Invalid and extreme inputs
            failedTests += TestSize(-1, "Invalid"); // Invalid input
            failedTests += TestSize(int.MaxValue, "L"); // Extreme valid input, should be Large
            failedTests += TestSize(0, "S"); // Boundary case, should return Small

            Console.WriteLine($"Total failed tests: {failedTests}");
        }

        // Helper method to test T-shirt size
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
