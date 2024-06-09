
namespace OOP
{
    public class Triangle
    {
        private int TriangleBase;
        private int TriangleHeight;


        public Triangle(int new_base, int new_height)
        {
            TriangleBase = new_base;
            TriangleHeight = new_height;
        }

        public float CalculateArea()
        {
            return (TriangleBase * TriangleHeight) / 2;
        }

        public string TriangleAsString()
        {
            return $"Base is {TriangleBase}, height is {TriangleHeight}";
        }
    }
}
