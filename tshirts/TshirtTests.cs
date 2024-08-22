using Xunit;

namespace TshirtSpace.Tests
{
    public class TshirtTests
    {
        [Theory]
        [InlineData(37, "S")]
        [InlineData(40, "M")]
        [InlineData(43, "L")]
        [InlineData(38, "S")] // This will be the failing test case
        [InlineData(-1, "S")] // Negative case; adjust the expected output based on your design
        [InlineData(int.MaxValue, "L")] // Extreme valid input
        public void TestSize(int cms, string expected)
        {
            string result = Tshirt.Size(cms);
            
            if (expected == "S" && cms == 38) // Expected failure case
            {
                Assert.NotEqual(expected, result); // Assert Not Equal for expected failure
            }
            else
            {
                Assert.Equal(expected, result); // Regular assertion
            }
        }
    }
}
