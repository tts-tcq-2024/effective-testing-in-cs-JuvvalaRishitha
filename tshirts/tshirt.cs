using System;
using Xunit;

namespace TshirtSpace
{
    public class Tshirt
    {
        public static string Size(int cms)
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
    }

    public class Program
    {
        static void Main(string[] args)
        {
            RunTests();
            Console.WriteLine("All tests completed (check for expected failures).\n");
        }

        static void RunTests()
        {
            // Valid inputs
            AssertSize(37, "S");
            AssertSize(40, "M");
            AssertSize(43, "L");
            AssertSize(38, "S"); // Expected to fail based on original logic

            // Invalid inputs
            AssertSize(-1, "Invalid"); // Edge case for invalid input
            AssertSize(0, "S"); // Boundary case for small
            AssertSize(int.MaxValue, "L"); // Extreme valid input
        }

        static void AssertSize(int cms, string expected)
        {
            string result = Tshirt.Size(cms);
            if (result != expected)
            {
                Console.WriteLine($"Test failed: Expected Size({cms}) to be '{expected}', but got '{result}'.");
            }
            else
            {
                Console.WriteLine($"Test passed: Size({cms}) is '{result}'.");
            }
        }

        static void AssertNotEqualSize(int cms, string unexpected)
        {
            string result = Tshirt.Size(cms);
            if (result == unexpected)
            {
                throw new Exception($"Test failed: Size({cms}) should not be '{unexpected}', but it is.");
            }
            Console.WriteLine($"Test passed: Size({cms}) is not '{unexpected}'.");
        }
    }
}
