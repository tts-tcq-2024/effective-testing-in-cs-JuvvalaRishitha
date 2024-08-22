using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }

        static void Main(string[] args) {
            // Test cases for Small size ("S")
            Debug.Assert(Size(0) == "S", "Test failed: Expected Size(0) to be 'S', but got " + Size(0));
            Debug.Assert(Size(37) == "S", "Test failed: Expected Size(37) to be 'S', but got " + Size(37));
            Debug.Assert(Size(37.9f) == "S", "Test failed: Expected Size(37.9) to be 'S', but got " + Size(37.9f));

            // Test cases for Medium size ("M")
            Debug.Assert(Size(38) == "M", "Test failed: Expected Size(38) to be 'M', but got " + Size(38));
            Debug.Assert(Size(40) == "M", "Test failed: Expected Size(40) to be 'M', but got " + Size(40));
            Debug.Assert(Size(41) == "M", "Test failed: Expected Size(41) to be 'M', but got " + Size(41));
            Debug.Assert(Size(41.9f) == "M", "Test failed: Expected Size(41.9) to be 'M', but got " + Size(41.9f));

            // Test cases for Large size ("L")
            Debug.Assert(Size(42) == "M", "Test failed: Expected Size(42) to be 'M', but got " + Size(42)); // Expected to fail due to original logic
            Debug.Assert(Size(42.1f) == "L", "Test failed: Expected Size(42.1) to be 'L', but got " + Size(42.1f));
            Debug.Assert(Size(43) == "L", "Test failed: Expected Size(43) to be 'L', but got " + Size(43));
            Debug.Assert(Size(100) == "L", "Test failed: Expected Size(100) to be 'L', but got " + Size(100));

            // Edge cases with unexpected inputs
            Debug.Assert(Size(-1) == "S", "Test failed: Expected Size(-1) to be 'S', but got " + Size(-1)); // Negative input
            Debug.Assert(Size(int.MaxValue) == "L", "Test failed: Expected Size(Int32.MaxValue) to be 'L', but got " + Size(int.MaxValue)); // Extremely large input

            Console.WriteLine("All tests completed (maybe some failed due to existing bugs).");
        }
    }
}
