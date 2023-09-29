

namespace ICT3101_Calculator
{
    static class Program
    {
        static void Main()
        {
            bool endApp = false;
            Calculator calculator = new Calculator();
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            while (!endApp)
            {
                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                var numInput1 = Console.ReadLine();

                double cleanNum1;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type second number, and then press Enter: ");
                var numInput2 = Console.ReadLine();

                double cleanNum2;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to type the third number.
                Console.Write("Type third number, and then press Enter: ");
                var numInput3 = Console.ReadLine();

                double cleanNum3;
                while (!double.TryParse(numInput3, out cleanNum3))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput3 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\tf - Factorial");
                Console.WriteLine("\taot - Area of Triangle");
                Console.WriteLine("\taoc - Area of Circle");
                Console.WriteLine("\tufa - Unknown Function A");
                Console.WriteLine("\tufb - Unknown Function B");
                Console.WriteLine("\tmtbf - Mean Time Before Failure");
                Console.WriteLine("\tavailability - Availability");
                Console.WriteLine("\tcfi - Current Failure Intensity");
                Console.WriteLine("\tnef - Number of Expected Failures");
                Console.WriteLine("\tdd - Defect Density");
                Console.WriteLine("\tssi - SSI for second release");
                Console.WriteLine("\tmagic - Magic Number");
                Console.Write("Your option? ");

                string? op = Console.ReadLine();

                try
                {
                    var result = calculator.DoOperation(cleanNum1, cleanNum2, cleanNum3, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'q' and Enter to quit the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "q") endApp = true;

                Console.WriteLine("\n"); // Friendly line spacing.
            }
        }
    }
}
