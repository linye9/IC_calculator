// Exercise Week 1
//Create a calculator .NET console application with requirements:
//1.Calculator should be able to do Add, Subtract and Multiply
//2. Create an abstract base class called CalculatorBase, which contains Add,
//Subtract and Multiply function. All 3 function takes EXACTLY 2 interger
//arguments as input.
//3. Inherit the Abstract base class with a class called Calculator, which 
//overrides Add, Subtract and Multiply function from base class
//4.Call each of the calculator functions from Program.cs file


using IC_calculator;

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

    switch (op)
    {
        case 1:
            Console.WriteLine($"result: {left} + {right} = " + calculator.Add(left, right));
            break;
        case 2:
            Console.WriteLine($"result: {left} - {right} = " + calculator.Subtract(left, right));
            break;
        case 3:
            Console.WriteLine($"result: {left} * {right} = " + calculator.Multiply(left, right));
            break;
    }

}
