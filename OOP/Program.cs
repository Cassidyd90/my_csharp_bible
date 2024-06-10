namespace OOP
{
    class Program
    {

        static void Main()
        {
            // Rectangle stuff
            var rectangle_1 = new Rectangle(-1, 10);
            var rectangle_2 = new Rectangle(10, 25);

            Console.WriteLine($"Width is {rectangle_1.Width}");
            Console.WriteLine($"Width is {rectangle_1.Height}");
            Console.WriteLine($"Area of rectangle is {rectangle_1.CalculateArea()}");
            Console.WriteLine($"Circumference of rectangle is {rectangle_1.CalculateCircumference()}");

            // Triangle Stuff
            var triangle_1 = new Triangle(15, 25);
            var triangle_2 = new Triangle(15, 35);

            Console.WriteLine($"Area of triangle is {triangle_1.CalculateArea()}");
            Console.WriteLine(triangle_1.TriangleAsString());
            Console.WriteLine(Triangle.DescribeGenerally());
            Console.WriteLine($"Count of triangles created is {Triangle.CountOfInstances}");


            // Hotel Booking stuff
            var customer_1 = new HotelBooking("Dylan", new DateTime(1990, 12, 19), 10);
 
            Console.WriteLine($"Booking for {customer_1.GuestName} on {customer_1.StartDate.DayOfWeek} until {customer_1.EndDate.DayOfWeek}");

            var person1 = new Person("Dylan", 1990);
            Console.WriteLine(person1.Description);

            Console.WriteLine($"1 + 2 = {Calculations.Add(1, 2)}");
            Console.WriteLine($"1 - 2 = {Calculations.Subtract(1, 2)}");
            Console.WriteLine($"2 * 2 = {Calculations.Multiply(2, 2)}");
        }

    }
}

   
