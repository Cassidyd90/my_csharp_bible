
namespace OOP
{
    public class Triangle
    {
        private int TriangleBase;
        private int TriangleHeight;

        public static int CountOfInstances {get; private set;}

        public Triangle(int new_base, int new_height)
        {
            TriangleBase = new_base;
            TriangleHeight = new_height;
            ++CountOfInstances;
        }

        public float CalculateArea() => (TriangleBase * TriangleHeight) / 2;

        public string TriangleAsString() => $"Base is {TriangleBase}, height is {TriangleHeight}";

        public static string DescribeGenerally() => $"Triangle measurements.";
  
    }
}
