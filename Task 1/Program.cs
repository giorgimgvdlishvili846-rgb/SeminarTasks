Console.WriteLine("Enter first number:!");
int firstNumber; // უბრალოდ ვქმნით ცვლადს, Parse-ის გარეშე
while (!int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid input! Please enter a valid integer:");
    Console.ResetColor();
}

Console.WriteLine("Enter second number:!");
int secondNumber; // აქაც იგივე, Parse-ის გარეშე
while (!int.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid input! Please enter a valid integer:");
    Console.ResetColor();
}
double sum = (double)(firstNumber + secondNumber)/2;
Console.WriteLine($"The sum is {sum}");