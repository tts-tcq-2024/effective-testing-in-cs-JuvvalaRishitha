using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S"; // Small
            } else if(cms > 38 && cms < 42) {
                return "M"; // Medium
            } else {
                return "L"; // Large
            }
        }

        static void Main(string[] args) {
            // Existing test cases
            //Debug.Assert(Size(37) == "S");
            //Debug.Assert(Size(40) == "M");
            //Debug.Assert(Size(43) == "L");

            // New test cases designed to fail
            Debug.Assert(Size(38) == "S"); // This should return "M", expecting failure
            Debug.Assert(Size(42) == "M"); // This should return "L", expecting failure
            Debug.Assert(Size(100) == "M"); // This should return "L", expecting failure
            Debug.Assert(Size(0) == "M"); // This should return "S", expecting failure
            Debug.Assert(Size(-10) == "S"); // This should return "S", but let's assume we're checking against invalid here
            
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
