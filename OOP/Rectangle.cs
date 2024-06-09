namespace OOP
{
    /// 
    /// Having the data fields and methods all in one class is called "Encapsulation"
    ///
    public class Rectangle
    {
        // Public fields start with capital
        public int Width;
        public int Height;

        /// Private fields start with underscore and lower letter 
        // private int _width;
        // private int _height;

        // Constructor
        // Must be named the same as class
        // Won't have 'return' like other methods
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int CalculateCircumference()
        {
            return 2 * Width + 2 * Height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
