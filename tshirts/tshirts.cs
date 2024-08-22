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
            // Test cases
            Console.WriteLine(Size(37) == "S" ? "Test passed" : "Test failed");
            Console.WriteLine(Size(40) == "M" ? "Test passed" : "Test failed");
            Console.WriteLine(Size(43) == "L" ? "Test passed" : "Test failed");
            Console.WriteLine(Size(38) == "S" ? "Test passed" : "Test failed");
            Console.WriteLine(Size(-1) == "Invalid" ? "Test passed" : "Test failed");
            Console.WriteLine(Size(Convert.ToInt32("$$$")) == "Invalid" ? "Test passed" : "Test failed");

            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
