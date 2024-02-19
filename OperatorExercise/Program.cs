namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1:\n");

            // Step 1
            int a = 17;
            int b = 4;

            // Step 2
            int sum = a + b;
            int minus = a - b;
            int multiply = a * b;

            // Step 3
            int quotient = a / b;
            int remainder = a % b;

            // Step 4
            Console.WriteLine($"{a} + {b} is {sum}.");
            Console.WriteLine($"{a} - {b} is {minus}.");
            Console.WriteLine($"{a} x {b} is {multiply}.");
            Console.WriteLine($"\n{a} / {b} is {quotient} with a remainder of {remainder}.");

            Console.WriteLine("\nExercise 2:\n");

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe area of a circle with radius of {radius} is {AreaOfCircle(radius)}");

            // Thought Exercise
            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // ouputs ? ---> should be 16

        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
