using System;
using System.Diagnostics;

namespace TshirtSpace
{
    class tshirt
    {
        // Method to determine T-shirt size based on measurements in cms
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
            // Existing test cases
            Debug.Assert(Size(37) == "S"); // This should pass
            Debug.Assert(Size(40) == "M"); // This should pass
            Debug.Assert(Size(43) == "L"); // This should pass

            // New test cases designed to fail
            Debug.Assert(Size(38) == "S"); // This will fail (expected "M")
            Debug.Assert(Size(42) == "M"); // This will fail (expected "L")
            Debug.Assert(Size(100) == "M"); // This will fail (expected "L")
            Debug.Assert(Size(0) == "M"); // This will fail (expected "S")
            Debug.Assert(Size(-10) == "S"); // This will pass (expected "S")

            Console.WriteLine("All is well (maybe!)");
        }
    }
}
