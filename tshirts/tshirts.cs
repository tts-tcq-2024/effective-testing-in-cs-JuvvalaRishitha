using System;

namespace TshirtSpace
{
    class Tshirt
    {
        // Method to determine T-shirt size based on cms
        static string Size(object cms)
        {
            // Handle invalid input types
            if (cms is not int)
            {
                return "Invalid";
            }

            int cmsValue = (int)cms;

            if (cmsValue < 38)
            {
                return "S"; // Small
            }
            else if (cmsValue > 38 && cmsValue < 42)
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
            // Test cases
            try
            {
                Assert(Size(37), "S");
                Assert(Size(40), "M");
                Assert(Size(43), "L");
                Assert(Size(38), "S"); // Expected to return "S", but according to original logic this may be a confusion
                Assert(Size(-1), "Invalid");
                Assert(Size("$$$"), "Invalid");

                Console.WriteLine("All is well (maybe!)\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
            }
        }

        // Helper method to assert the output
        static void Assert(string actual, string expected)
        {
            if (actual != expected)
            {
                throw new Exception($"Assertion failed: expected '{expected}', but got '{actual}'.");
            }
        }
    }
}
