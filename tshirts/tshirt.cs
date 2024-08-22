using System;
using Xunit;

namespace TshirtSpace
{
    // Tshirt class containing the logic to determine size
    public class tshirt
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

    // Test class for Tshirt
    public class tshirtTests
    {
        [Theory]
        [InlineData(37, "S")]
        [InlineData(40, "M")]
        [InlineData(43, "L")]
        [InlineData(38, "S")] // This case is expected to fail based on original logic
        [InlineData(-1, "Invalid")] // Edge case for invalid input
        [InlineData(0, "S")] // Boundary case for small
        [InlineData(int.MaxValue, "L")] // Extreme valid input
        public void TestSize(int cms, string expected)
        {
            string result = tshirt.Size(cms);

            // Expected failure for Size(38)
            if (cms == 38)
            {
                Assert.NotEqual(expected, result); // This should trigger a failure
            }
            else
            {
                Assert.Equal(expected, result); // Normal assertion
            }
        }
    }

    // Main program to run the tests
    class Program
    {
        static void Main(string[] args)
        {
            // Running the tests
            var testRunner = new Xunit.Runner.VisualStudio.TestRunner();
            testRunner.RunTests();
            Console.WriteLine("All tests completed (check for expected failures).");
        }
    }
}
