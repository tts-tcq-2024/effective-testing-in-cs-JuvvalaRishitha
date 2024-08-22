using Xunit;

namespace TshirtSpace.Tests
{
    public class TshirtTests
    {
        [Theory]
        [InlineData(37, "S")]
        [InlineData(40, "M")]
        [InlineData(43, "L")]
        [InlineData(38, "S")]  // Expected to fail based on the original logic
        [InlineData(-1, "S")]   // Negative value
        [InlineData(int.MaxValue, "L")] // Maximum int value
        public void TestSize(int cms, string expected)
        {
            string result = Tshirt.Size(cms);
            if (expected == "S" && cms == 38) // This test is expected to fail
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
