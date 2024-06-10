namespace OOP
{
    /// 
    /// Having the data fields and methods all in one class is called "Encapsulation"
    ///
    public class Rectangle
    {
        const int NumberOfSides = 4;
        // Public fields start with capital
        public readonly int Width;
        public readonly int Height;

        /// Private fields start with underscore and lower letter 
        // private int _width;
        // private int _height;

        // Constructor
        // Must be named the same as class
        // Won't have 'return' like other methods
        public Rectangle(int width, int height)
        {
            
            Width = GetLengthOrDefault(width, nameof(Width));
            Height = GetLengthOrDefault(height, nameof(Height));
        }
            

        private int GetLengthOrDefault(int length, string name)
        {
            // const because it will never change
            const int DefaultWidthHeight = 1;
            if (length <= 0)
            {
                Console.WriteLine($"{name} must be positive number.");
                return DefaultWidthHeight;
            }
            return length;

        }

        // Expression Body method
        // One return works, more than one return doesn't work
        public int CalculateCircumference() => 2 * Width + 2 * Height;


        public int CalculateArea() => Width * Height;
    }
}
