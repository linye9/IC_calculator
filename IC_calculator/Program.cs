// Exercise Week 1
//Create a calculator .NET console application

using IC_calculator;
using static IC_calculator.CalculatorBase;

var calculator = new Calculator();

while (true)
{
    Console.WriteLine("--Choose an option to do calculation");
    Console.WriteLine("1 to ADD");
    Console.WriteLine("2 to Subtract");
    Console.WriteLine("3 to Multiply");

    int op;
    while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out op) || op > 3 || op < 1)
    {
        Console.WriteLine(" wrong option, do it again");
    }

    // input two operand
    Console.WriteLine("\nInput the first number: ");
    float left = calculator.Valid(Console.ReadLine());

    Console.WriteLine("Input the second number: ");
    float right = calculator.Valid(Console.ReadLine());

    switch ((Operator)op)
    {
        case Operator.Add:
            Console.WriteLine($"result: {left} + {right} = " + calculator.Add(left, right));
            break;
        case Operator.Subtract:
            Console.WriteLine($"result: {left} - {right} = " + calculator.Subtract(left, right));
            break;
        case Operator.Multiply:
            Console.WriteLine($"result: {left} * {right} = " + calculator.Multiply(left, right));
            break;
    }
}
