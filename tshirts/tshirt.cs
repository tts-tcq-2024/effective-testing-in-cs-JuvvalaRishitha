using System;
using Xunit;

namespace TshirtSpace
{
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

    public class TshirtTests
    {
        [Fact]
        public void TestSize_WhenCmsIs37_ReturnsS()
        {
            Assert.Equal("S", tshirt.Size(37));
        }

        [Fact]
        public void TestSize_WhenCmsIs40_ReturnsM()
        {
            Assert.Equal("M", tshirt.Size(40));
        }

        [Fact]
        public void TestSize_WhenCmsIs43_ReturnsL()
        {
            Assert.Equal("L", tshirt.Size(43));
        }

        [Fact]
        public void TestSize_WhenCmsIs38_ReturnsL() 
        {
            
            Assert.Equal("S", tshirt.Size(38)); 
        }

        [Fact]
        public void TestSize_WhenCmsIsNegative_ReturnsS()
        {
            Assert.Equal("S", tshirt.Size(-1)); // Edge case
        }

        [Fact]
        public void TestSize_WhenCmsIsZero_ReturnsS()
        {
            Assert.Equal("S", tshirt.Size(0));
        }

        [Fact]
        public void TestSize_WhenCmsIsMaxValue_ReturnsL()
        {
            Assert.Equal("L", tshirt.Size(int.MaxValue));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The Main method can remain empty for testing purposes
        }
    }
}
