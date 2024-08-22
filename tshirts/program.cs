using System;

namespace TshirtSpace
{
    public class Tshirt
    {
        // Method to determine T-shirt size based on cms
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All tests will be executed using xUnit. Please run 'dotnet test' to see results.");
        }
    }
}

