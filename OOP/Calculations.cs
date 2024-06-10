
namespace OOP
{
    /// static because does not hold values
    /// a bit like callable functions in python 
    /// can only have static methods
    static class Calculations
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a , int b) => a - b;
        public static int Multiply(int a, int b) => a * b;

    }
}
