double num1 = 0;
double num2 = 0;
double result = 0;

System.Console.WriteLine("====================");
System.Console.WriteLine("=Calculator Program=");
System.Console.WriteLine("====================");

System.Console.Write("Enter number 1: ");
num1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter number 2: ");
num2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter an option: \n+ : Add\n- : Substract\n* : Multiply\n/ : Divide \n");

switch(Console.ReadLine())
{
    case "+":
        result = num1 + num2;
        System.Console.WriteLine($"Your result: {num1} + {num2} = {result}");
        break;

    case "-":
        result = num1 - num2;
        System.Console.WriteLine($"Your result: {num1} - {num2} = {result}");
        break;

    case "*":
        result = num1 * num2;
        System.Console.WriteLine($"Your result: {num1} * {num2} = {result}");
        break;

    case "/":
        result = num1 / num2;
        System.Console.WriteLine($"Your result: {num1} / {num2} = {result}");
        break;
    
    default:
        System.Console.WriteLine("That was not a valid option");
        break;
};
