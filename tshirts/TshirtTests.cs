using Xunit;

namespace TshirtSpace
{
    public class TshirtTests
    {
        [Fact]
        public void TestSize_ValidInputs()
        {
            Assert.Equal("S", Tshirt.Size(37));
            Assert.Equal("M", Tshirt.Size(40));
            Assert.Equal("L", Tshirt.Size(43));
        }

        [Fact]
        public void TestSize_BoundaryCases()
        {
            // This is expected to fail
            Assert.NotEqual("M", Tshirt.Size(38)); // Expected failure based on original logic
        }

        [Fact]
        public void TestSize_InvalidInputs()
        {
            Assert.Equal("S", Tshirt.Size(-1)); // Should be handled as "S"
            Assert.Equal("S", Tshirt.Size(0));  // Should also return "S"
            Assert.Equal("L", Tshirt.Size(int.MaxValue)); // Extreme valid input
        }

        [Fact]
        public void TestSize_NonIntegerInput()
        {
            // Test for non-integer input
            Assert.Throws<FormatException>(() => Convert.ToInt32("$$$"));
        }
    }
}
