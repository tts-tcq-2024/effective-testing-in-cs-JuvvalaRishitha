using System;

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
            // Create a flag to check if any test passed unexpectedly
            bool anyTestPassed = false;

            // Test cases
            anyTestPassed |= AssertFailing(Size(37), "S"); // Should pass, expected failure
            anyTestPassed |= AssertFailing(Size(40), "M"); // Should pass, expected failure
            anyTestPassed |= AssertFailing(Size(43), "L"); // Should pass, expected failure
            anyTestPassed |= AssertFailing(Size(38), "Invalid"); // Expected to fail based on original logic
            anyTestPassed |= AssertFailing(Size(-1), "Invalid"); // This should fail based on logic
            anyTestPassed |= AssertFailing(Size(0), "Invalid"); // This should fail, expected failure
            anyTestPassed |= AssertFailing(Size(int.MaxValue), "L"); // Should pass, expected failure

            // If any test passed unexpectedly, throw an exception
            if (anyTestPassed) {
                throw new Exception("One or more tests passed when they should have failed!");
            }
        }

        static bool AssertFailing(string result, string expected) {
            if (result != expected) {
                Console.WriteLine($"Test failed as expected: Expected '{expected}', but got '{result}'.");
                return false; // Indicates the test failed as expected
            }
            Console.WriteLine($"FALSE POSITIVE! Test passed unexpectedly: Expected '{expected}', got '{result}'.");
            return true; // Indicates the test passed unexpectedly
        }
    }
}

