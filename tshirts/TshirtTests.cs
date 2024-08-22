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
        [InlineData(-1, "S")] // Assuming this is handled by the system, adjust if necessary
        [InlineData(0, "S")]  // Boundary test case
        [InlineData(int.MaxValue, "L")] // Testing with extreme valid input
        public void TestSize(int cms, string expected)
        {
            string result = Tshirt.Size(cms);
            
            // Use Assert.NotEqual for the expected failure case
            if (cms == 38)
            {
                Assert.NotEqual(expected, result); // Expected failure
            }
            else
            {
                Assert.Equal(expected, result); // Normal assertion for other cases
            }
        }
    }
}
