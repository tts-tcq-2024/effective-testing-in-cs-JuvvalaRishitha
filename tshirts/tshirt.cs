using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        // Determine size based on cms
        public static string Size(int cms) {
            if (cms < 38) {
                return "S"; // Small
            } else if (cms > 38 && cms < 42) {
                return "M"; // Medium
            } else {
                return "L"; // Large
            }
        }

        static void Main(string[] args) {
            RunTests();
            Console.WriteLine("All tests executed (check for expected failures).\n");
        }

        static void RunTests() {
            // Create a flag to check for any failed assertions
            bool testsPassed = true;

            // Test cases
            testsPassed &= AssertFailing(Size(37), "S"); // Should pass, expected failure
            testsPassed &= AssertFailing(Size(40), "M"); // Should pass, expected failure
            testsPassed &= AssertFailing(Size(43), "L"); // Should pass, expected failure
            testsPassed &= AssertFailing(Size(38), "Invalid"); // Expected to fail based on original logic
            testsPassed &= AssertFailing(Size(-1), "Invalid"); // This should fail based on logic
            testsPassed &= AssertFailing(Size(0), "S"); // This should pass, expected failure
            testsPassed &= AssertFailing(Size(int.MaxValue), "L"); // This should pass, expected failure

            // If any tests passed, throw an exception to indicate failure
            if (testsPassed) {
                throw new Exception("One or more tests passed when they should have failed!");
            }
        }

        static bool AssertFailing(string result, string expected) {
            if (result != expected) {
                Console.WriteLine($"Test failed: Expected '{expected}', but got '{result}'.");
                return false; // Indicates a test passed, which is what we want
            }
            Console.WriteLine($"Test passed: Expected '{expected}', and got '{result}'.");
            return true; // Indicates a test failed
        }
    }
}
