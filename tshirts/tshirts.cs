using System;
using System.Diagnostics;

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

        static void TestSize(int cms, string expected) {
            string result = Size(cms);
            if (result != expected) {
                Console.WriteLine($"Test failed: Expected Size({cms}) to be '{expected}', but got '{result}'.");
            }
        }

        static void Main(string[] args) {
            // Test cases for Small size ("S")
            TestSize(0, "S");
            TestSize(37, "S");
            TestSize(37, "S"); 
            // Test cases for Medium size ("M")
            TestSize(38, "L"); 
            TestSize(39, "M");
            TestSize(40, "M");
            TestSize(41, "M");
            TestSize(41, "M"); 
            // Test cases for Large size ("L")
            TestSize(42, "L");
            TestSize(42, "L"); 
            TestSize(42, "L");
            TestSize(100, "L");

            // Edge cases with unexpected inputs
            TestSize(-1, "S"); // Negative input
            TestSize(int.MaxValue, "L"); 

            Console.WriteLine("All tests completed (check for expected failures).");
        }
    }
}
