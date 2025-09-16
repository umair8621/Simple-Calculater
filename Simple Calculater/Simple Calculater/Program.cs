using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-Console Calculater-");

        Console.Write("Enter 1st number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter 2nd number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Operation: + , - , * , / ");
        string operation = Console.ReadLine();

        double result;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                if(num2 != 0)
                {
                    result = num1 / num2;
                }else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }
        Console.WriteLine($"Result: {result}");

    }
}








//double result = operation switch
//{
//    "+" => num1 + num2,
//    "-" => num1 - num2,
//    "*" => num1 * num2,
//    "/" => num1 / num2,
//    _ => throw new InvalidOperationException("Invalid operation")
//};