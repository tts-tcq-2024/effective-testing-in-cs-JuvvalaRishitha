using System;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if (cms < 38) {
                return "S"; // Small
            } else if (cms > 38 && cms < 42) {
                return "M"; // Medium
            } else {
                return "L"; // Large
            }
        }

        static void Main(string[] args) {
            int failedTests = 0;

            // Test cases for Small size ("S")
            failedTests += TestSize(0, "S");
            failedTests += TestSize(37, "S");

            // Test cases for Medium size ("M")
            failedTests += TestSize(38, "L"); // Expected to fail
            failedTests += TestSize(39, "M");
            failedTests += TestSize(40, "M");
            failedTests += TestSize(41, "M");

            // Test cases for Large size ("L")
            failedTests += TestSize(42, "L");
            failedTests += TestSize(42.1f, "L"); // This is technically incorrect
            failedTests += TestSize(100, "L");

            // Edge cases with unexpected inputs
            failedTests += TestSize(-1, "S"); // Negative input
            failedTests += TestSize(int.MaxValue, "L"); // Extremely large input

            Console.WriteLine("All tests completed. Total failed tests: " + failedTests);
        }

        static int TestSize(int cms, string expected) {
            string result = Size(cms);
            if (result != expected) {
                Console.WriteLine($"Test failed: Expected Size({cms}) to be '{expected}', but got '{result}'.");
                return 1; // Count this as a failed test
            }
            return 0; // No failure
        }
    }
}
